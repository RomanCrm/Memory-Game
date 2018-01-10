using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public enum ButtonsCount
    {
        Max = 36,
        Min = 16,
        Mid = 30
    }

    enum Index
    {
        Zero = 0,
        First = 1
    }

    public partial class MemoryForm : Form
    {
        Button[] buttons;
        List<Button> visibleButtons;
        List<Button> copyVB;

        Card card;

        List<Image> images;

        Random rnd;
        int rndNum;

        int sizeField;

        Timer timerGame;
        TimeSpan time;

        Timer stopCards;

        Timer sleep;

        List<int> indecies1;
        List<int> indecies2;

        int scores;
        int moves;

        int countOpndCrds;

        bool isEnd;

        Game game;

        public MemoryForm()
        {
            buttons = new Button[(int)ButtonsCount.Max];
            visibleButtons = new List<Button>();
            copyVB = new List<Button>();

            card = new Card();

            rnd = new Random();
            rndNum = 0;

            sizeField = 0;

            timerGame = new System.Windows.Forms.Timer();
            timerGame.Interval = 1000;
            timerGame.Tick += Timer_Tick;

            time = new TimeSpan(0, 0, 0);

            sleep = new Timer();

            InitializeComponent();
            InitializeButtons();

            game = SaveBest.Open();

            labelBT.Text = game.Time;
            labelBS.Text = game.Scores.ToString();

            labelScore.Text = "0";
            label3.Text = "0";
            labelTime.Text = "00:00:00";

            buttonStop.Enabled = false;

            indecies1 = new List<int>();
            indecies2 = new List<int>();

            scores = 0;
            moves = 0;

            countOpndCrds = 0;

            isEnd = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, 1);
            time = time.Add(timeSpan);
            labelTime.Text = time.ToString();
        }

        public void InitializeButtons()
        {
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[9] = button10;
            buttons[10] = button11;
            buttons[11] = button12;
            buttons[12] = button13;
            buttons[13] = button14;
            buttons[14] = button15;
            buttons[15] = button16;
            buttons[16] = button17;
            buttons[17] = button18;
            buttons[18] = button19;
            buttons[19] = button20;
            buttons[20] = button21;
            buttons[21] = button22;
            buttons[22] = button23;
            buttons[23] = button24;
            buttons[24] = button25;
            buttons[25] = button26;
            buttons[26] = button27;
            buttons[27] = button28;
            buttons[28] = button29;
            buttons[29] = button30;
            buttons[30] = button31;
            buttons[31] = button32;
            buttons[32] = button33;
            buttons[33] = button34;
            buttons[34] = button35;
            buttons[35] = button36;
        }

        /// <summary>
        /// Fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Radio4x4(object sender, EventArgs e)
        {
            Field.Field4x4(buttons);
            sizeField = (int)ButtonsCount.Min;
        }
        private void Radio5x6(object sender, EventArgs e)
        {
            Field.Field5x6(buttons);
            sizeField = (int)ButtonsCount.Mid;
        }
        private void Radio6x6(object sender, EventArgs e)
        {
            Field.Field6x6(buttons);
            sizeField = (int)ButtonsCount.Max;
        }

        /// <summary>
        /// Start game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartClick(object sender, EventArgs e)
        {
            timerGame.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;

            if (!radio1.Checked && !radio2.Checked && !radio3.Checked)
            {
                Field.Field4x4(buttons);
                SavePicturesButtons(ButtonsCount.Min);

                radio1.Checked = true;
            }
            else
            {
                SavePicturesButtons((ButtonsCount)sizeField);
            }
            groupField.Enabled = false;
        }

        private void SavePicturesButtons(ButtonsCount buttonsCount)
        {
            images = new List<Image>();
            images = Card.RandomCards((int)buttonsCount);

            // save visible buttons
            foreach (Button button in buttons)
            {
                if (button.Visible)
                {
                    visibleButtons.Add(button);
                }
            }

            // random pictures to random indecies
            for (int i = 0; i < images.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    rndNum = rnd.Next(0, (int)buttonsCount);
                    while (visibleButtons[rndNum].Image != null)
                    {
                        rndNum = rnd.Next(0, (int)buttonsCount);
                    }
                    visibleButtons[rndNum].Image = images[i];
                }
            }

            copyVB = visibleButtons.CopyButtons();

            foreach (Button button in visibleButtons)
            {
                button.Image = null;
            }

            // image tree for all buttons
            foreach (Button button in buttons)
            {
                if (button.Visible)
                {
                    button.Image = Card.ImageTree;
                }
            }

            // add event Click to all visible buttons
            PlusClickToAll();
        }

        private void PlusClickToAll()
        {
            foreach (Button button in buttons)
            {
                button.Click += ClickOnAllVisiblButtons;
            }
        }

        private void ClickOnAllVisiblButtons(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;

            int idxOfPBForButtons = 0;
            int idxInVBForVB = 0;

            idxOfPBForButtons = buttons.ToList().IndexOf(pressedButton);

            if (indecies1.Count == 0)
            {
                idxInVBForVB = InnerCycle(pressedButton, idxOfPBForButtons, idxInVBForVB);
            }
            else
            {
                if (indecies1[(int)Index.Zero] != idxOfPBForButtons)
                {
                    idxInVBForVB = InnerCycle(pressedButton, idxOfPBForButtons, idxInVBForVB);
                }
            }
        }

        private int InnerCycle(Button pressedButton, int idxOfPBForButtons, int idxInVBForVB)
        {
            foreach (Button vbutton in copyVB)
            {
                if (vbutton.Tag == pressedButton.Tag)
                {
                    idxInVBForVB = copyVB.IndexOf(vbutton);
                    break;
                }
            }
            buttons[idxOfPBForButtons].Image = null;
            buttons[idxOfPBForButtons].Image = copyVB[idxInVBForVB].Image;

            moves++;
            label3.Text = moves.ToString();

            indecies1.Add(idxOfPBForButtons);
            indecies2.Add(idxInVBForVB);

            if ((indecies1.Count + indecies2.Count) == 4)
            {
                stopCards = new System.Windows.Forms.Timer();
                stopCards.Interval = 200;
                stopCards.Tick += StopCards_Tick;
                stopCards.Start();
            }

            return idxInVBForVB;
        }

        private void StopCards_Tick(object sender, EventArgs e)
        {
            if (stopCards.Enabled)
            {
                stopCards.Stop();
                CheckForAMatch();

                if (countOpndCrds == sizeField)
                {
                    isEnd = true;
                    timerGame.Stop();
                    label4.Visible = true;

                    Game game = new Game { Scores = int.Parse(labelScore.Text), Time = labelTime.Text };
                    SaveBest.Save(game, labelBT, labelBS);
                }
            }
        }

        private void CheckForAMatch()
        {
            foreach (Button button in buttons)
            {
                if (button.Visible)
                {
                    button.Click -= ClickOnAllVisiblButtons;
                }
            }

            if (buttons[indecies1[(int)Index.Zero]].Image.Tag == buttons[indecies1[(int)Index.First]].Image.Tag)
            {
                buttons[indecies1[(int)Index.Zero]].Image = null;
                buttons[indecies1[(int)Index.First]].Image = null;

                buttons[indecies1[(int)Index.Zero]].Visible = false;
                buttons[indecies1[(int)Index.First]].Visible = false;

                indecies1.Clear();
                indecies2.Clear();

                scores++;
                countOpndCrds += 2;
                labelScore.Text = scores.ToString();
            }
            else
            {
                buttons[indecies1[(int)Index.Zero]].Image = Card.ImageTree;
                buttons[indecies1[(int)Index.First]].Image = Card.ImageTree;

                indecies1.Clear();
                indecies2.Clear();
            }

            sleep.Interval = 10;
            sleep.Tick += TimerSleepCards;
            sleep.Start();
        }

        private void TimerSleepCards(object sender, EventArgs e)
        {
            if (sleep.Enabled)
            {
                sleep.Stop();
                foreach (Button button in buttons)
                {
                    if (button.Visible)
                    {
                        button.Click += ClickOnAllVisiblButtons;
                    }
                }
            }
        }

        private void PauseResumeGame(object sender, EventArgs e)
        {
            if (timerGame.Enabled)
            {
                timerGame.Stop();
                labelTime.Text = "Pause";
            }
            else
            {
                if (!isEnd)
                {
                    timerGame.Start();
                }
            }
        }
    }

}