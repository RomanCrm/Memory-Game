namespace Memory
{
    partial class MemoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.groupField = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelBT = new System.Windows.Forms.Label();
            this.labelBS = new System.Windows.Forms.Label();
            this.groupField.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(692, 65);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 36);
            this.buttonStart.TabIndex = 31;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.StartClick);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.Location = new System.Drawing.Point(692, 129);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(101, 36);
            this.buttonStop.TabIndex = 32;
            this.buttonStop.Text = "Pause/Resume";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.PauseResumeGame);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(737, 241);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 20);
            this.labelTime.TabIndex = 33;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(753, 180);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 20);
            this.labelScore.TabIndex = 36;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(309, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(191, 25);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "Check Your Memory";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(6, 36);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(48, 21);
            this.radio1.TabIndex = 41;
            this.radio1.Text = "4x4";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.Radio4x4);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(6, 58);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(48, 21);
            this.radio2.TabIndex = 42;
            this.radio2.Text = "5x6";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.Radio5x6);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(6, 79);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(48, 21);
            this.radio3.TabIndex = 43;
            this.radio3.Text = "6x6";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.Radio6x6);
            // 
            // groupField
            // 
            this.groupField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupField.Controls.Add(this.radio2);
            this.groupField.Controls.Add(this.radio1);
            this.groupField.Controls.Add(this.radio3);
            this.groupField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupField.Location = new System.Drawing.Point(684, 297);
            this.groupField.Name = "groupField";
            this.groupField.Size = new System.Drawing.Size(109, 137);
            this.groupField.TabIndex = 45;
            this.groupField.TabStop = false;
            this.groupField.Text = "TypeOfField";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(20, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 46;
            this.button1.Tag = "1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(126, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 47;
            this.button2.Tag = "2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(232, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 48;
            this.button3.Tag = "3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(338, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 49;
            this.button4.Tag = "4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(444, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 50;
            this.button5.Tag = "5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(550, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 51;
            this.button6.Tag = "6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(20, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 57;
            this.button7.Tag = "7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(126, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 56;
            this.button8.Tag = "8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(232, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 55;
            this.button9.Tag = "9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(338, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 54;
            this.button10.Tag = "10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(444, 171);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 53;
            this.button11.Tag = "11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(550, 171);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 52;
            this.button12.Tag = "12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(20, 277);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 63;
            this.button13.Tag = "13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(126, 277);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 62;
            this.button14.Tag = "14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(232, 277);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 61;
            this.button15.Tag = "15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(338, 277);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 100);
            this.button16.TabIndex = 60;
            this.button16.Tag = "16";
            this.button16.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(444, 276);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 100);
            this.button17.TabIndex = 59;
            this.button17.Tag = "17";
            this.button17.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(550, 277);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 100);
            this.button18.TabIndex = 58;
            this.button18.Tag = "18";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(20, 383);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 100);
            this.button19.TabIndex = 69;
            this.button19.Tag = "19";
            this.button19.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(126, 383);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 100);
            this.button20.TabIndex = 68;
            this.button20.Tag = "20";
            this.button20.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Location = new System.Drawing.Point(232, 383);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 100);
            this.button21.TabIndex = 67;
            this.button21.Tag = "21";
            this.button21.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Location = new System.Drawing.Point(338, 383);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 100);
            this.button22.TabIndex = 66;
            this.button22.Tag = "22";
            this.button22.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.ForeColor = System.Drawing.Color.Black;
            this.button23.Location = new System.Drawing.Point(444, 383);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 100);
            this.button23.TabIndex = 65;
            this.button23.Tag = "23";
            this.button23.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.ForeColor = System.Drawing.Color.Black;
            this.button24.Location = new System.Drawing.Point(550, 383);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 100);
            this.button24.TabIndex = 64;
            this.button24.Tag = "24";
            this.button24.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(20, 489);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(100, 100);
            this.button25.TabIndex = 75;
            this.button25.Tag = "25";
            this.button25.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Location = new System.Drawing.Point(126, 489);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(100, 100);
            this.button26.TabIndex = 74;
            this.button26.Tag = "26";
            this.button26.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.ForeColor = System.Drawing.Color.Black;
            this.button27.Location = new System.Drawing.Point(232, 489);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 100);
            this.button27.TabIndex = 73;
            this.button27.Tag = "27";
            this.button27.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.ForeColor = System.Drawing.Color.Black;
            this.button28.Location = new System.Drawing.Point(338, 489);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(100, 100);
            this.button28.TabIndex = 72;
            this.button28.Tag = "28";
            this.button28.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.ForeColor = System.Drawing.Color.Black;
            this.button29.Location = new System.Drawing.Point(444, 489);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(100, 100);
            this.button29.TabIndex = 71;
            this.button29.Tag = "29";
            this.button29.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.ForeColor = System.Drawing.Color.Black;
            this.button30.Location = new System.Drawing.Point(550, 489);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(100, 100);
            this.button30.TabIndex = 70;
            this.button30.Tag = "30";
            this.button30.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.ForeColor = System.Drawing.Color.Black;
            this.button31.Location = new System.Drawing.Point(20, 595);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 100);
            this.button31.TabIndex = 81;
            this.button31.Tag = "31";
            this.button31.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.ForeColor = System.Drawing.Color.Black;
            this.button32.Location = new System.Drawing.Point(126, 595);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 100);
            this.button32.TabIndex = 80;
            this.button32.Tag = "32";
            this.button32.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.ForeColor = System.Drawing.Color.Black;
            this.button33.Location = new System.Drawing.Point(232, 595);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 100);
            this.button33.TabIndex = 79;
            this.button33.Tag = "33";
            this.button33.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.ForeColor = System.Drawing.Color.Black;
            this.button34.Location = new System.Drawing.Point(338, 595);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(100, 100);
            this.button34.TabIndex = 78;
            this.button34.Tag = "34";
            this.button34.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.ForeColor = System.Drawing.Color.Black;
            this.button35.Location = new System.Drawing.Point(444, 595);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(100, 100);
            this.button35.TabIndex = 77;
            this.button35.Tag = "35";
            this.button35.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.ForeColor = System.Drawing.Color.Black;
            this.button36.Location = new System.Drawing.Point(550, 595);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(100, 100);
            this.button36.TabIndex = 76;
            this.button36.Tag = "36";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button36.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(684, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Scores:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(684, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoves.Location = new System.Drawing.Point(684, 212);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(59, 20);
            this.labelMoves.TabIndex = 84;
            this.labelMoves.Text = "Moves:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(749, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 63);
            this.label4.TabIndex = 86;
            this.label4.Text = "Win!!!";
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBS);
            this.groupBox1.Controls.Add(this.labelBT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(684, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 126);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Moves:";
            // 
            // labelBT
            // 
            this.labelBT.AutoSize = true;
            this.labelBT.Location = new System.Drawing.Point(21, 47);
            this.labelBT.Name = "labelBT";
            this.labelBT.Size = new System.Drawing.Size(0, 17);
            this.labelBT.TabIndex = 2;
            // 
            // labelBS
            // 
            this.labelBS.AutoSize = true;
            this.labelBS.Location = new System.Drawing.Point(48, 97);
            this.labelBS.Name = "labelBS";
            this.labelBS.Size = new System.Drawing.Size(0, 17);
            this.labelBS.TabIndex = 3;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(837, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupField);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 800);
            this.Name = "MemoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoryGame";
            this.groupField.ResumeLayout(false);
            this.groupField.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.GroupBox groupField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBS;
        private System.Windows.Forms.Label labelBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

