using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class Field
    {
        public static void Field4x4(Button[] buttons)
        {
            buttons[0].Visible = false;
            buttons[1].Visible = false;
            buttons[2].Visible = false;
            buttons[3].Visible = false;
            buttons[4].Visible = false;
            buttons[5].Visible = false;

            buttons[6].Visible = false;
            buttons[11].Visible = false;

            buttons[12].Visible = false;
            buttons[17].Visible = false;

            buttons[18].Visible = false;
            buttons[23].Visible = false;

            buttons[24].Visible = false;
            buttons[29].Visible = false;

            buttons[30].Visible = false;
            buttons[31].Visible = false;
            buttons[32].Visible = false;
            buttons[33].Visible = false;
            buttons[34].Visible = false;
            buttons[35].Visible = false;
        }

        public static void Field5x6(Button[] buttons)
        {
            Field6x6(buttons);
            buttons[5].Visible = false;
            buttons[11].Visible = false;
            buttons[17].Visible = false;
            buttons[23].Visible = false;
            buttons[29].Visible = false;
            buttons[35].Visible = false;
        }

        public static void Field6x6(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Visible = true;
            }
        }

    }
}
