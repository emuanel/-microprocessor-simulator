 using System.Windows.Forms;

namespace Mikroprocesor
{
    public struct rejestr
    {
        public Button[] tabH;
        public Button[] tabL;
        public int h;   //wartosc rejestru H
        public int l;   //wartosc rejestru L
        public Label hLabel;
        public Label lLabel;
    }


    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
       
        public rejestr ax;
        public rejestr bx;
        public rejestr cx;
        public rejestr dx;
        public rejestr stala;

        public Button[] ahButtons; public Button[] alButtons;
        public Button[] bhButtons; public Button[] blButtons;
        public Button[] chButtons; public Button[] clButtons;
        public Button[] dhButtons; public Button[] dlButtons;

        public int liczbaRozkazowDoWykonania = 0;
        public int biezacyRozkaz = 0; 

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
            this.components = new System.ComponentModel.Container();
            this.AX_textbox = new System.Windows.Forms.TextBox();
            this.BX_textbox = new System.Windows.Forms.TextBox();
            this.CX_textbox = new System.Windows.Forms.TextBox();
            this.DX_textbox = new System.Windows.Forms.TextBox();
            this.AL_textbox = new System.Windows.Forms.TextBox();
            this.AH_textbox = new System.Windows.Forms.TextBox();
            this.BL_textbox = new System.Windows.Forms.TextBox();
            this.BH_textbox = new System.Windows.Forms.TextBox();
            this.CL_textbox = new System.Windows.Forms.TextBox();
            this.CH_textbox = new System.Windows.Forms.TextBox();
            this.DL_textbox = new System.Windows.Forms.TextBox();
            this.DH_textbox = new System.Windows.Forms.TextBox();
            this.ah7 = new System.Windows.Forms.Button();
            this.ah6 = new System.Windows.Forms.Button();
            this.ah5 = new System.Windows.Forms.Button();
            this.ah4 = new System.Windows.Forms.Button();
            this.ah3 = new System.Windows.Forms.Button();
            this.ah2 = new System.Windows.Forms.Button();
            this.ah1 = new System.Windows.Forms.Button();
            this.ah0 = new System.Windows.Forms.Button();
            this.al0 = new System.Windows.Forms.Button();
            this.al1 = new System.Windows.Forms.Button();
            this.al2 = new System.Windows.Forms.Button();
            this.al3 = new System.Windows.Forms.Button();
            this.al4 = new System.Windows.Forms.Button();
            this.al5 = new System.Windows.Forms.Button();
            this.al6 = new System.Windows.Forms.Button();
            this.al7 = new System.Windows.Forms.Button();
            this.bh0 = new System.Windows.Forms.Button();
            this.bh1 = new System.Windows.Forms.Button();
            this.bh2 = new System.Windows.Forms.Button();
            this.bh3 = new System.Windows.Forms.Button();
            this.bh4 = new System.Windows.Forms.Button();
            this.bh5 = new System.Windows.Forms.Button();
            this.bh6 = new System.Windows.Forms.Button();
            this.bh7 = new System.Windows.Forms.Button();
            this.bl0 = new System.Windows.Forms.Button();
            this.bl1 = new System.Windows.Forms.Button();
            this.bl2 = new System.Windows.Forms.Button();
            this.bl3 = new System.Windows.Forms.Button();
            this.bl4 = new System.Windows.Forms.Button();
            this.bl5 = new System.Windows.Forms.Button();
            this.bl6 = new System.Windows.Forms.Button();
            this.bl7 = new System.Windows.Forms.Button();
            this.ch0 = new System.Windows.Forms.Button();
            this.ch1 = new System.Windows.Forms.Button();
            this.ch2 = new System.Windows.Forms.Button();
            this.ch3 = new System.Windows.Forms.Button();
            this.ch4 = new System.Windows.Forms.Button();
            this.ch5 = new System.Windows.Forms.Button();
            this.ch6 = new System.Windows.Forms.Button();
            this.ch7 = new System.Windows.Forms.Button();
            this.cl0 = new System.Windows.Forms.Button();
            this.cl1 = new System.Windows.Forms.Button();
            this.cl2 = new System.Windows.Forms.Button();
            this.cl3 = new System.Windows.Forms.Button();
            this.cl4 = new System.Windows.Forms.Button();
            this.cl5 = new System.Windows.Forms.Button();
            this.cl6 = new System.Windows.Forms.Button();
            this.cl7 = new System.Windows.Forms.Button();
            this.dh0 = new System.Windows.Forms.Button();
            this.dh1 = new System.Windows.Forms.Button();
            this.dh2 = new System.Windows.Forms.Button();
            this.dh3 = new System.Windows.Forms.Button();
            this.dh4 = new System.Windows.Forms.Button();
            this.dh5 = new System.Windows.Forms.Button();
            this.dh6 = new System.Windows.Forms.Button();
            this.dh7 = new System.Windows.Forms.Button();
            this.dl0 = new System.Windows.Forms.Button();
            this.dl1 = new System.Windows.Forms.Button();
            this.dl2 = new System.Windows.Forms.Button();
            this.dl3 = new System.Windows.Forms.Button();
            this.dl4 = new System.Windows.Forms.Button();
            this.dl5 = new System.Windows.Forms.Button();
            this.dl6 = new System.Windows.Forms.Button();
            this.dl7 = new System.Windows.Forms.Button();
            this.rejestr1_textbox = new System.Windows.Forms.TextBox();
            this.rozkaz_textbox = new System.Windows.Forms.TextBox();
            this.rejestr2_textbox = new System.Windows.Forms.TextBox();
            this.lista_textbox = new System.Windows.Forms.TextBox();
            this.dodaj_button = new System.Windows.Forms.Button();
            this.krokowa_button = new System.Windows.Forms.Button();
            this.calosc_button = new System.Windows.Forms.Button();
            this.wyczysc_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.AH_label = new System.Windows.Forms.Label();
            this.AL_label = new System.Windows.Forms.Label();
            this.BL_label = new System.Windows.Forms.Label();
            this.BH_label = new System.Windows.Forms.Label();
            this.CL_label = new System.Windows.Forms.Label();
            this.CH_label = new System.Windows.Forms.Label();
            this.DL_label = new System.Windows.Forms.Label();
            this.DH_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r1_DL = new System.Windows.Forms.RadioButton();
            this.r1_DH = new System.Windows.Forms.RadioButton();
            this.r1_CL = new System.Windows.Forms.RadioButton();
            this.r1_CH = new System.Windows.Forms.RadioButton();
            this.r1_BL = new System.Windows.Forms.RadioButton();
            this.r1_BH = new System.Windows.Forms.RadioButton();
            this.r1_AL = new System.Windows.Forms.RadioButton();
            this.r1_AH = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r2_DL = new System.Windows.Forms.RadioButton();
            this.r2_DH = new System.Windows.Forms.RadioButton();
            this.r2_CL = new System.Windows.Forms.RadioButton();
            this.r2_CH = new System.Windows.Forms.RadioButton();
            this.r2_BL = new System.Windows.Forms.RadioButton();
            this.r2_BH = new System.Windows.Forms.RadioButton();
            this.r2_AL = new System.Windows.Forms.RadioButton();
            this.r2_AH = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SUB = new System.Windows.Forms.RadioButton();
            this.ADD = new System.Windows.Forms.RadioButton();
            this.MOV = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_stala = new System.Windows.Forms.TextBox();
            this.checkBox_stala = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AX_textbox
            // 
            this.AX_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AX_textbox.Location = new System.Drawing.Point(14, 13);
            this.AX_textbox.Multiline = true;
            this.AX_textbox.Name = "AX_textbox";
            this.AX_textbox.Size = new System.Drawing.Size(101, 28);
            this.AX_textbox.TabIndex = 1;
            this.AX_textbox.Text = "Rejestr AX";
            this.AX_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BX_textbox
            // 
            this.BX_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BX_textbox.Location = new System.Drawing.Point(14, 122);
            this.BX_textbox.Multiline = true;
            this.BX_textbox.Name = "BX_textbox";
            this.BX_textbox.Size = new System.Drawing.Size(101, 28);
            this.BX_textbox.TabIndex = 2;
            this.BX_textbox.Text = "Rejestr BX";
            this.BX_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CX_textbox
            // 
            this.CX_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CX_textbox.Location = new System.Drawing.Point(14, 232);
            this.CX_textbox.Multiline = true;
            this.CX_textbox.Name = "CX_textbox";
            this.CX_textbox.Size = new System.Drawing.Size(101, 28);
            this.CX_textbox.TabIndex = 3;
            this.CX_textbox.Text = "Rejestr CX";
            this.CX_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DX_textbox
            // 
            this.DX_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DX_textbox.Location = new System.Drawing.Point(14, 342);
            this.DX_textbox.Multiline = true;
            this.DX_textbox.Name = "DX_textbox";
            this.DX_textbox.Size = new System.Drawing.Size(101, 28);
            this.DX_textbox.TabIndex = 4;
            this.DX_textbox.Text = "Rejestr DX";
            this.DX_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AL_textbox
            // 
            this.AL_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AL_textbox.Location = new System.Drawing.Point(14, 78);
            this.AL_textbox.Multiline = true;
            this.AL_textbox.Name = "AL_textbox";
            this.AL_textbox.Size = new System.Drawing.Size(36, 26);
            this.AL_textbox.TabIndex = 5;
            this.AL_textbox.Text = "AL";
            this.AL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AH_textbox
            // 
            this.AH_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AH_textbox.Location = new System.Drawing.Point(14, 46);
            this.AH_textbox.Multiline = true;
            this.AH_textbox.Name = "AH_textbox";
            this.AH_textbox.Size = new System.Drawing.Size(36, 26);
            this.AH_textbox.TabIndex = 6;
            this.AH_textbox.Text = "AH";
            this.AH_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BL_textbox
            // 
            this.BL_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BL_textbox.Location = new System.Drawing.Point(14, 188);
            this.BL_textbox.Multiline = true;
            this.BL_textbox.Name = "BL_textbox";
            this.BL_textbox.Size = new System.Drawing.Size(36, 26);
            this.BL_textbox.TabIndex = 7;
            this.BL_textbox.Text = "BL";
            this.BL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BH_textbox
            // 
            this.BH_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BH_textbox.Location = new System.Drawing.Point(14, 155);
            this.BH_textbox.Multiline = true;
            this.BH_textbox.Name = "BH_textbox";
            this.BH_textbox.Size = new System.Drawing.Size(36, 26);
            this.BH_textbox.TabIndex = 8;
            this.BH_textbox.Text = "BH";
            this.BH_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CL_textbox
            // 
            this.CL_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CL_textbox.Location = new System.Drawing.Point(14, 298);
            this.CL_textbox.Multiline = true;
            this.CL_textbox.Name = "CL_textbox";
            this.CL_textbox.Size = new System.Drawing.Size(36, 26);
            this.CL_textbox.TabIndex = 9;
            this.CL_textbox.Text = "CL";
            this.CL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CH_textbox
            // 
            this.CH_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CH_textbox.Location = new System.Drawing.Point(14, 266);
            this.CH_textbox.Multiline = true;
            this.CH_textbox.Name = "CH_textbox";
            this.CH_textbox.Size = new System.Drawing.Size(36, 26);
            this.CH_textbox.TabIndex = 10;
            this.CH_textbox.Text = "CH";
            this.CH_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DL_textbox
            // 
            this.DL_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DL_textbox.Location = new System.Drawing.Point(14, 407);
            this.DL_textbox.Multiline = true;
            this.DL_textbox.Name = "DL_textbox";
            this.DL_textbox.Size = new System.Drawing.Size(36, 26);
            this.DL_textbox.TabIndex = 11;
            this.DL_textbox.Text = "DL";
            this.DL_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DH_textbox
            // 
            this.DH_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DH_textbox.Location = new System.Drawing.Point(14, 375);
            this.DH_textbox.Multiline = true;
            this.DH_textbox.Name = "DH_textbox";
            this.DH_textbox.Size = new System.Drawing.Size(36, 26);
            this.DH_textbox.TabIndex = 12;
            this.DH_textbox.Text = "DH";
            this.DH_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ah7
            // 
            this.ah7.Location = new System.Drawing.Point(67, 47);
            this.ah7.Name = "ah7";
            this.ah7.Size = new System.Drawing.Size(21, 26);
            this.ah7.TabIndex = 13;
            this.ah7.Text = "0";
            this.ah7.UseVisualStyleBackColor = true;
            this.ah7.Click += new System.EventHandler(this.ahClick);
            // 
            // ah6
            // 
            this.ah6.Location = new System.Drawing.Point(94, 47);
            this.ah6.Name = "ah6";
            this.ah6.Size = new System.Drawing.Size(21, 26);
            this.ah6.TabIndex = 14;
            this.ah6.Text = "0";
            this.ah6.UseVisualStyleBackColor = true;
            this.ah6.Click += new System.EventHandler(this.ahClick);
            // 
            // ah5
            // 
            this.ah5.Location = new System.Drawing.Point(121, 47);
            this.ah5.Name = "ah5";
            this.ah5.Size = new System.Drawing.Size(21, 26);
            this.ah5.TabIndex = 15;
            this.ah5.Text = "0";
            this.ah5.UseVisualStyleBackColor = true;
            this.ah5.Click += new System.EventHandler(this.ahClick);
            // 
            // ah4
            // 
            this.ah4.Location = new System.Drawing.Point(148, 47);
            this.ah4.Name = "ah4";
            this.ah4.Size = new System.Drawing.Size(21, 26);
            this.ah4.TabIndex = 16;
            this.ah4.Text = "0";
            this.ah4.UseVisualStyleBackColor = true;
            this.ah4.Click += new System.EventHandler(this.ahClick);
            // 
            // ah3
            // 
            this.ah3.Location = new System.Drawing.Point(175, 47);
            this.ah3.Name = "ah3";
            this.ah3.Size = new System.Drawing.Size(21, 26);
            this.ah3.TabIndex = 17;
            this.ah3.Text = "0";
            this.ah3.UseVisualStyleBackColor = true;
            this.ah3.Click += new System.EventHandler(this.ahClick);
            // 
            // ah2
            // 
            this.ah2.Location = new System.Drawing.Point(202, 47);
            this.ah2.Name = "ah2";
            this.ah2.Size = new System.Drawing.Size(21, 26);
            this.ah2.TabIndex = 18;
            this.ah2.Text = "0";
            this.ah2.UseVisualStyleBackColor = true;
            this.ah2.Click += new System.EventHandler(this.ahClick);
            // 
            // ah1
            // 
            this.ah1.Location = new System.Drawing.Point(229, 47);
            this.ah1.Name = "ah1";
            this.ah1.Size = new System.Drawing.Size(21, 26);
            this.ah1.TabIndex = 19;
            this.ah1.Text = "0";
            this.ah1.UseVisualStyleBackColor = true;
            this.ah1.Click += new System.EventHandler(this.ahClick);
            // 
            // ah0
            // 
            this.ah0.Location = new System.Drawing.Point(256, 47);
            this.ah0.Name = "ah0";
            this.ah0.Size = new System.Drawing.Size(21, 26);
            this.ah0.TabIndex = 20;
            this.ah0.Text = "0";
            this.ah0.UseVisualStyleBackColor = true;
            this.ah0.Click += new System.EventHandler(this.ahClick);
            // 
            // al0
            // 
            this.al0.Location = new System.Drawing.Point(256, 79);
            this.al0.Name = "al0";
            this.al0.Size = new System.Drawing.Size(21, 26);
            this.al0.TabIndex = 28;
            this.al0.Text = "0";
            this.al0.UseVisualStyleBackColor = true;
            this.al0.Click += new System.EventHandler(this.alClick);
            // 
            // al1
            // 
            this.al1.Location = new System.Drawing.Point(229, 79);
            this.al1.Name = "al1";
            this.al1.Size = new System.Drawing.Size(21, 26);
            this.al1.TabIndex = 27;
            this.al1.Text = "0";
            this.al1.UseVisualStyleBackColor = true;
            this.al1.Click += new System.EventHandler(this.alClick);
            // 
            // al2
            // 
            this.al2.Location = new System.Drawing.Point(202, 79);
            this.al2.Name = "al2";
            this.al2.Size = new System.Drawing.Size(21, 26);
            this.al2.TabIndex = 26;
            this.al2.Text = "0";
            this.al2.UseVisualStyleBackColor = true;
            this.al2.Click += new System.EventHandler(this.alClick);
            // 
            // al3
            // 
            this.al3.Location = new System.Drawing.Point(175, 79);
            this.al3.Name = "al3";
            this.al3.Size = new System.Drawing.Size(21, 26);
            this.al3.TabIndex = 25;
            this.al3.Text = "0";
            this.al3.UseVisualStyleBackColor = true;
            this.al3.Click += new System.EventHandler(this.alClick);
            // 
            // al4
            // 
            this.al4.Location = new System.Drawing.Point(148, 79);
            this.al4.Name = "al4";
            this.al4.Size = new System.Drawing.Size(21, 26);
            this.al4.TabIndex = 24;
            this.al4.Text = "0";
            this.al4.UseVisualStyleBackColor = true;
            this.al4.Click += new System.EventHandler(this.alClick);
            // 
            // al5
            // 
            this.al5.Location = new System.Drawing.Point(121, 79);
            this.al5.Name = "al5";
            this.al5.Size = new System.Drawing.Size(21, 26);
            this.al5.TabIndex = 23;
            this.al5.Text = "0";
            this.al5.UseVisualStyleBackColor = true;
            this.al5.Click += new System.EventHandler(this.alClick);
            // 
            // al6
            // 
            this.al6.Location = new System.Drawing.Point(94, 79);
            this.al6.Name = "al6";
            this.al6.Size = new System.Drawing.Size(21, 26);
            this.al6.TabIndex = 22;
            this.al6.Text = "0";
            this.al6.UseVisualStyleBackColor = true;
            this.al6.Click += new System.EventHandler(this.alClick);
            // 
            // al7
            // 
            this.al7.Location = new System.Drawing.Point(67, 79);
            this.al7.Name = "al7";
            this.al7.Size = new System.Drawing.Size(21, 26);
            this.al7.TabIndex = 21;
            this.al7.Text = "0";
            this.al7.UseVisualStyleBackColor = true;
            this.al7.Click += new System.EventHandler(this.alClick);
            // 
            // bh0
            // 
            this.bh0.Location = new System.Drawing.Point(256, 156);
            this.bh0.Name = "bh0";
            this.bh0.Size = new System.Drawing.Size(21, 26);
            this.bh0.TabIndex = 36;
            this.bh0.Text = "0";
            this.bh0.UseVisualStyleBackColor = true;
            this.bh0.Click += new System.EventHandler(this.bhClick);
            // 
            // bh1
            // 
            this.bh1.Location = new System.Drawing.Point(229, 156);
            this.bh1.Name = "bh1";
            this.bh1.Size = new System.Drawing.Size(21, 26);
            this.bh1.TabIndex = 35;
            this.bh1.Text = "0";
            this.bh1.UseVisualStyleBackColor = true;
            this.bh1.Click += new System.EventHandler(this.bhClick);
            // 
            // bh2
            // 
            this.bh2.Location = new System.Drawing.Point(202, 156);
            this.bh2.Name = "bh2";
            this.bh2.Size = new System.Drawing.Size(21, 26);
            this.bh2.TabIndex = 34;
            this.bh2.Text = "0";
            this.bh2.UseVisualStyleBackColor = true;
            this.bh2.Click += new System.EventHandler(this.bhClick);
            // 
            // bh3
            // 
            this.bh3.Location = new System.Drawing.Point(175, 156);
            this.bh3.Name = "bh3";
            this.bh3.Size = new System.Drawing.Size(21, 26);
            this.bh3.TabIndex = 33;
            this.bh3.Text = "0";
            this.bh3.UseVisualStyleBackColor = true;
            this.bh3.Click += new System.EventHandler(this.bhClick);
            // 
            // bh4
            // 
            this.bh4.Location = new System.Drawing.Point(148, 156);
            this.bh4.Name = "bh4";
            this.bh4.Size = new System.Drawing.Size(21, 26);
            this.bh4.TabIndex = 32;
            this.bh4.Text = "0";
            this.bh4.UseVisualStyleBackColor = true;
            this.bh4.Click += new System.EventHandler(this.bhClick);
            // 
            // bh5
            // 
            this.bh5.Location = new System.Drawing.Point(121, 156);
            this.bh5.Name = "bh5";
            this.bh5.Size = new System.Drawing.Size(21, 26);
            this.bh5.TabIndex = 31;
            this.bh5.Text = "0";
            this.bh5.UseVisualStyleBackColor = true;
            this.bh5.Click += new System.EventHandler(this.bhClick);
            // 
            // bh6
            // 
            this.bh6.Location = new System.Drawing.Point(94, 156);
            this.bh6.Name = "bh6";
            this.bh6.Size = new System.Drawing.Size(21, 26);
            this.bh6.TabIndex = 30;
            this.bh6.Text = "0";
            this.bh6.UseVisualStyleBackColor = true;
            this.bh6.Click += new System.EventHandler(this.bhClick);
            // 
            // bh7
            // 
            this.bh7.Location = new System.Drawing.Point(67, 156);
            this.bh7.Name = "bh7";
            this.bh7.Size = new System.Drawing.Size(21, 26);
            this.bh7.TabIndex = 29;
            this.bh7.Text = "0";
            this.bh7.UseVisualStyleBackColor = true;
            this.bh7.Click += new System.EventHandler(this.bhClick);
            // 
            // bl0
            // 
            this.bl0.Location = new System.Drawing.Point(256, 189);
            this.bl0.Name = "bl0";
            this.bl0.Size = new System.Drawing.Size(21, 26);
            this.bl0.TabIndex = 44;
            this.bl0.Text = "0";
            this.bl0.UseVisualStyleBackColor = true;
            this.bl0.Click += new System.EventHandler(this.blClick);
            // 
            // bl1
            // 
            this.bl1.Location = new System.Drawing.Point(229, 189);
            this.bl1.Name = "bl1";
            this.bl1.Size = new System.Drawing.Size(21, 26);
            this.bl1.TabIndex = 43;
            this.bl1.Text = "0";
            this.bl1.UseVisualStyleBackColor = true;
            this.bl1.Click += new System.EventHandler(this.blClick);
            // 
            // bl2
            // 
            this.bl2.Location = new System.Drawing.Point(202, 189);
            this.bl2.Name = "bl2";
            this.bl2.Size = new System.Drawing.Size(21, 26);
            this.bl2.TabIndex = 42;
            this.bl2.Text = "0";
            this.bl2.UseVisualStyleBackColor = true;
            this.bl2.Click += new System.EventHandler(this.blClick);
            // 
            // bl3
            // 
            this.bl3.Location = new System.Drawing.Point(175, 189);
            this.bl3.Name = "bl3";
            this.bl3.Size = new System.Drawing.Size(21, 26);
            this.bl3.TabIndex = 41;
            this.bl3.Text = "0";
            this.bl3.UseVisualStyleBackColor = true;
            this.bl3.Click += new System.EventHandler(this.blClick);
            // 
            // bl4
            // 
            this.bl4.Location = new System.Drawing.Point(148, 189);
            this.bl4.Name = "bl4";
            this.bl4.Size = new System.Drawing.Size(21, 26);
            this.bl4.TabIndex = 40;
            this.bl4.Text = "0";
            this.bl4.UseVisualStyleBackColor = true;
            this.bl4.Click += new System.EventHandler(this.blClick);
            // 
            // bl5
            // 
            this.bl5.Location = new System.Drawing.Point(121, 189);
            this.bl5.Name = "bl5";
            this.bl5.Size = new System.Drawing.Size(21, 26);
            this.bl5.TabIndex = 39;
            this.bl5.Text = "0";
            this.bl5.UseVisualStyleBackColor = true;
            this.bl5.Click += new System.EventHandler(this.blClick);
            // 
            // bl6
            // 
            this.bl6.Location = new System.Drawing.Point(94, 189);
            this.bl6.Name = "bl6";
            this.bl6.Size = new System.Drawing.Size(21, 26);
            this.bl6.TabIndex = 38;
            this.bl6.Text = "0";
            this.bl6.UseVisualStyleBackColor = true;
            this.bl6.Click += new System.EventHandler(this.blClick);
            // 
            // bl7
            // 
            this.bl7.Location = new System.Drawing.Point(67, 189);
            this.bl7.Name = "bl7";
            this.bl7.Size = new System.Drawing.Size(21, 26);
            this.bl7.TabIndex = 37;
            this.bl7.Text = "0";
            this.bl7.UseVisualStyleBackColor = true;
            this.bl7.Click += new System.EventHandler(this.blClick);
            // 
            // ch0
            // 
            this.ch0.Location = new System.Drawing.Point(256, 266);
            this.ch0.Name = "ch0";
            this.ch0.Size = new System.Drawing.Size(21, 26);
            this.ch0.TabIndex = 52;
            this.ch0.Text = "0";
            this.ch0.UseVisualStyleBackColor = true;
            this.ch0.Click += new System.EventHandler(this.chClick);
            // 
            // ch1
            // 
            this.ch1.Location = new System.Drawing.Point(229, 266);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(21, 26);
            this.ch1.TabIndex = 51;
            this.ch1.Text = "0";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.Click += new System.EventHandler(this.chClick);
            // 
            // ch2
            // 
            this.ch2.Location = new System.Drawing.Point(202, 266);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(21, 26);
            this.ch2.TabIndex = 50;
            this.ch2.Text = "0";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.Click += new System.EventHandler(this.chClick);
            // 
            // ch3
            // 
            this.ch3.Location = new System.Drawing.Point(175, 266);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(21, 26);
            this.ch3.TabIndex = 49;
            this.ch3.Text = "0";
            this.ch3.UseVisualStyleBackColor = true;
            this.ch3.Click += new System.EventHandler(this.chClick);
            // 
            // ch4
            // 
            this.ch4.Location = new System.Drawing.Point(148, 266);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(21, 26);
            this.ch4.TabIndex = 48;
            this.ch4.Text = "0";
            this.ch4.UseVisualStyleBackColor = true;
            this.ch4.Click += new System.EventHandler(this.chClick);
            // 
            // ch5
            // 
            this.ch5.Location = new System.Drawing.Point(121, 266);
            this.ch5.Name = "ch5";
            this.ch5.Size = new System.Drawing.Size(21, 26);
            this.ch5.TabIndex = 47;
            this.ch5.Text = "0";
            this.ch5.UseVisualStyleBackColor = true;
            this.ch5.Click += new System.EventHandler(this.chClick);
            // 
            // ch6
            // 
            this.ch6.Location = new System.Drawing.Point(94, 266);
            this.ch6.Name = "ch6";
            this.ch6.Size = new System.Drawing.Size(21, 26);
            this.ch6.TabIndex = 46;
            this.ch6.Text = "0";
            this.ch6.UseVisualStyleBackColor = true;
            this.ch6.Click += new System.EventHandler(this.chClick);
            // 
            // ch7
            // 
            this.ch7.Location = new System.Drawing.Point(67, 266);
            this.ch7.Name = "ch7";
            this.ch7.Size = new System.Drawing.Size(21, 26);
            this.ch7.TabIndex = 45;
            this.ch7.Text = "0";
            this.ch7.UseVisualStyleBackColor = true;
            this.ch7.Click += new System.EventHandler(this.chClick);
            // 
            // cl0
            // 
            this.cl0.Location = new System.Drawing.Point(256, 298);
            this.cl0.Name = "cl0";
            this.cl0.Size = new System.Drawing.Size(21, 26);
            this.cl0.TabIndex = 60;
            this.cl0.Text = "0";
            this.cl0.UseVisualStyleBackColor = true;
            this.cl0.Click += new System.EventHandler(this.clClick);
            // 
            // cl1
            // 
            this.cl1.Location = new System.Drawing.Point(229, 298);
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(21, 26);
            this.cl1.TabIndex = 59;
            this.cl1.Text = "0";
            this.cl1.UseVisualStyleBackColor = true;
            this.cl1.Click += new System.EventHandler(this.clClick);
            // 
            // cl2
            // 
            this.cl2.Location = new System.Drawing.Point(202, 298);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(21, 26);
            this.cl2.TabIndex = 58;
            this.cl2.Text = "0";
            this.cl2.UseVisualStyleBackColor = true;
            this.cl2.Click += new System.EventHandler(this.clClick);
            // 
            // cl3
            // 
            this.cl3.Location = new System.Drawing.Point(175, 298);
            this.cl3.Name = "cl3";
            this.cl3.Size = new System.Drawing.Size(21, 26);
            this.cl3.TabIndex = 57;
            this.cl3.Text = "0";
            this.cl3.UseVisualStyleBackColor = true;
            this.cl3.Click += new System.EventHandler(this.clClick);
            // 
            // cl4
            // 
            this.cl4.Location = new System.Drawing.Point(148, 298);
            this.cl4.Name = "cl4";
            this.cl4.Size = new System.Drawing.Size(21, 26);
            this.cl4.TabIndex = 56;
            this.cl4.Text = "0";
            this.cl4.UseVisualStyleBackColor = true;
            this.cl4.Click += new System.EventHandler(this.clClick);
            // 
            // cl5
            // 
            this.cl5.Location = new System.Drawing.Point(121, 298);
            this.cl5.Name = "cl5";
            this.cl5.Size = new System.Drawing.Size(21, 26);
            this.cl5.TabIndex = 55;
            this.cl5.Text = "0";
            this.cl5.UseVisualStyleBackColor = true;
            this.cl5.Click += new System.EventHandler(this.clClick);
            // 
            // cl6
            // 
            this.cl6.Location = new System.Drawing.Point(94, 298);
            this.cl6.Name = "cl6";
            this.cl6.Size = new System.Drawing.Size(21, 26);
            this.cl6.TabIndex = 54;
            this.cl6.Text = "0";
            this.cl6.UseVisualStyleBackColor = true;
            this.cl6.Click += new System.EventHandler(this.clClick);
            // 
            // cl7
            // 
            this.cl7.Location = new System.Drawing.Point(67, 298);
            this.cl7.Name = "cl7";
            this.cl7.Size = new System.Drawing.Size(21, 26);
            this.cl7.TabIndex = 53;
            this.cl7.Text = "0";
            this.cl7.UseVisualStyleBackColor = true;
            this.cl7.Click += new System.EventHandler(this.clClick);
            // 
            // dh0
            // 
            this.dh0.Location = new System.Drawing.Point(256, 376);
            this.dh0.Name = "dh0";
            this.dh0.Size = new System.Drawing.Size(21, 26);
            this.dh0.TabIndex = 68;
            this.dh0.Text = "0";
            this.dh0.UseVisualStyleBackColor = true;
            this.dh0.Click += new System.EventHandler(this.dhClick);
            // 
            // dh1
            // 
            this.dh1.Location = new System.Drawing.Point(229, 376);
            this.dh1.Name = "dh1";
            this.dh1.Size = new System.Drawing.Size(21, 26);
            this.dh1.TabIndex = 67;
            this.dh1.Text = "0";
            this.dh1.UseVisualStyleBackColor = true;
            this.dh1.Click += new System.EventHandler(this.dhClick);
            // 
            // dh2
            // 
            this.dh2.Location = new System.Drawing.Point(202, 376);
            this.dh2.Name = "dh2";
            this.dh2.Size = new System.Drawing.Size(21, 26);
            this.dh2.TabIndex = 66;
            this.dh2.Text = "0";
            this.dh2.UseVisualStyleBackColor = true;
            this.dh2.Click += new System.EventHandler(this.dhClick);
            // 
            // dh3
            // 
            this.dh3.Location = new System.Drawing.Point(175, 376);
            this.dh3.Name = "dh3";
            this.dh3.Size = new System.Drawing.Size(21, 26);
            this.dh3.TabIndex = 65;
            this.dh3.Text = "0";
            this.dh3.UseVisualStyleBackColor = true;
            this.dh3.Click += new System.EventHandler(this.dhClick);
            // 
            // dh4
            // 
            this.dh4.Location = new System.Drawing.Point(148, 376);
            this.dh4.Name = "dh4";
            this.dh4.Size = new System.Drawing.Size(21, 26);
            this.dh4.TabIndex = 64;
            this.dh4.Text = "0";
            this.dh4.UseVisualStyleBackColor = true;
            this.dh4.Click += new System.EventHandler(this.dhClick);
            // 
            // dh5
            // 
            this.dh5.Location = new System.Drawing.Point(121, 376);
            this.dh5.Name = "dh5";
            this.dh5.Size = new System.Drawing.Size(21, 26);
            this.dh5.TabIndex = 63;
            this.dh5.Text = "0";
            this.dh5.UseVisualStyleBackColor = true;
            this.dh5.Click += new System.EventHandler(this.dhClick);
            // 
            // dh6
            // 
            this.dh6.Location = new System.Drawing.Point(94, 376);
            this.dh6.Name = "dh6";
            this.dh6.Size = new System.Drawing.Size(21, 26);
            this.dh6.TabIndex = 62;
            this.dh6.Text = "0";
            this.dh6.UseVisualStyleBackColor = true;
            this.dh6.Click += new System.EventHandler(this.dhClick);
            // 
            // dh7
            // 
            this.dh7.Location = new System.Drawing.Point(67, 376);
            this.dh7.Name = "dh7";
            this.dh7.Size = new System.Drawing.Size(21, 26);
            this.dh7.TabIndex = 61;
            this.dh7.Text = "0";
            this.dh7.UseVisualStyleBackColor = true;
            this.dh7.Click += new System.EventHandler(this.dhClick);
            // 
            // dl0
            // 
            this.dl0.Location = new System.Drawing.Point(256, 409);
            this.dl0.Name = "dl0";
            this.dl0.Size = new System.Drawing.Size(21, 26);
            this.dl0.TabIndex = 76;
            this.dl0.Text = "0";
            this.dl0.UseVisualStyleBackColor = true;
            this.dl0.Click += new System.EventHandler(this.dlClick);
            // 
            // dl1
            // 
            this.dl1.Location = new System.Drawing.Point(229, 409);
            this.dl1.Name = "dl1";
            this.dl1.Size = new System.Drawing.Size(21, 26);
            this.dl1.TabIndex = 75;
            this.dl1.Text = "0";
            this.dl1.UseVisualStyleBackColor = true;
            this.dl1.Click += new System.EventHandler(this.dlClick);
            // 
            // dl2
            // 
            this.dl2.Location = new System.Drawing.Point(202, 409);
            this.dl2.Name = "dl2";
            this.dl2.Size = new System.Drawing.Size(21, 26);
            this.dl2.TabIndex = 74;
            this.dl2.Text = "0";
            this.dl2.UseVisualStyleBackColor = true;
            this.dl2.Click += new System.EventHandler(this.dlClick);
            // 
            // dl3
            // 
            this.dl3.Location = new System.Drawing.Point(175, 409);
            this.dl3.Name = "dl3";
            this.dl3.Size = new System.Drawing.Size(21, 26);
            this.dl3.TabIndex = 73;
            this.dl3.Text = "0";
            this.dl3.UseVisualStyleBackColor = true;
            this.dl3.Click += new System.EventHandler(this.dlClick);
            // 
            // dl4
            // 
            this.dl4.Location = new System.Drawing.Point(148, 409);
            this.dl4.Name = "dl4";
            this.dl4.Size = new System.Drawing.Size(21, 26);
            this.dl4.TabIndex = 72;
            this.dl4.Text = "0";
            this.dl4.UseVisualStyleBackColor = true;
            this.dl4.Click += new System.EventHandler(this.dlClick);
            // 
            // dl5
            // 
            this.dl5.Location = new System.Drawing.Point(121, 409);
            this.dl5.Name = "dl5";
            this.dl5.Size = new System.Drawing.Size(21, 26);
            this.dl5.TabIndex = 71;
            this.dl5.Text = "0";
            this.dl5.UseVisualStyleBackColor = true;
            this.dl5.Click += new System.EventHandler(this.dlClick);
            // 
            // dl6
            // 
            this.dl6.Location = new System.Drawing.Point(94, 409);
            this.dl6.Name = "dl6";
            this.dl6.Size = new System.Drawing.Size(21, 26);
            this.dl6.TabIndex = 70;
            this.dl6.Text = "0";
            this.dl6.UseVisualStyleBackColor = true;
            this.dl6.Click += new System.EventHandler(this.dlClick);
            // 
            // dl7
            // 
            this.dl7.Location = new System.Drawing.Point(67, 409);
            this.dl7.Name = "dl7";
            this.dl7.Size = new System.Drawing.Size(21, 26);
            this.dl7.TabIndex = 69;
            this.dl7.Text = "0";
            this.dl7.UseVisualStyleBackColor = true;
            this.dl7.Click += new System.EventHandler(this.dlClick);
            // 
            // rejestr1_textbox
            // 
            this.rejestr1_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejestr1_textbox.Location = new System.Drawing.Point(499, 15);
            this.rejestr1_textbox.Multiline = true;
            this.rejestr1_textbox.Name = "rejestr1_textbox";
            this.rejestr1_textbox.Size = new System.Drawing.Size(142, 26);
            this.rejestr1_textbox.TabIndex = 77;
            this.rejestr1_textbox.Text = "Wybór rejestru 1";
            this.rejestr1_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rozkaz_textbox
            // 
            this.rozkaz_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozkaz_textbox.Location = new System.Drawing.Point(340, 15);
            this.rozkaz_textbox.Multiline = true;
            this.rozkaz_textbox.Name = "rozkaz_textbox";
            this.rozkaz_textbox.Size = new System.Drawing.Size(142, 26);
            this.rozkaz_textbox.TabIndex = 78;
            this.rozkaz_textbox.Text = "Wybór rozkazu";
            this.rozkaz_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rejestr2_textbox
            // 
            this.rejestr2_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejestr2_textbox.Location = new System.Drawing.Point(662, 15);
            this.rejestr2_textbox.Multiline = true;
            this.rejestr2_textbox.Name = "rejestr2_textbox";
            this.rejestr2_textbox.Size = new System.Drawing.Size(145, 26);
            this.rejestr2_textbox.TabIndex = 79;
            this.rejestr2_textbox.Text = "Wybór rejestru 2";
            this.rejestr2_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lista_textbox
            // 
            this.lista_textbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lista_textbox.Location = new System.Drawing.Point(915, 15);
            this.lista_textbox.Multiline = true;
            this.lista_textbox.Name = "lista_textbox";
            this.lista_textbox.Size = new System.Drawing.Size(205, 291);
            this.lista_textbox.TabIndex = 99;
            // 
            // dodaj_button
            // 
            this.dodaj_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dodaj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_button.Location = new System.Drawing.Point(804, 118);
            this.dodaj_button.Name = "dodaj_button";
            this.dodaj_button.Size = new System.Drawing.Size(100, 72);
            this.dodaj_button.TabIndex = 100;
            this.dodaj_button.Text = "Dodaj rozkaz do programu";
            this.dodaj_button.UseVisualStyleBackColor = false;
            this.dodaj_button.Click += new System.EventHandler(this.dodaj_button_Click);
            // 
            // krokowa_button
            // 
            this.krokowa_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.krokowa_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krokowa_button.Location = new System.Drawing.Point(1134, 51);
            this.krokowa_button.Name = "krokowa_button";
            this.krokowa_button.Size = new System.Drawing.Size(115, 74);
            this.krokowa_button.TabIndex = 101;
            this.krokowa_button.Text = "Tryb pracy krokowej";
            this.krokowa_button.UseVisualStyleBackColor = false;
            this.krokowa_button.Click += new System.EventHandler(this.krokowa_button_Click);
            // 
            // calosc_button
            // 
            this.calosc_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calosc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calosc_button.Location = new System.Drawing.Point(1134, 131);
            this.calosc_button.Name = "calosc_button";
            this.calosc_button.Size = new System.Drawing.Size(115, 73);
            this.calosc_button.TabIndex = 102;
            this.calosc_button.Text = "Tryb całościowego wykonania";
            this.calosc_button.UseVisualStyleBackColor = false;
            this.calosc_button.Click += new System.EventHandler(this.calosc_button_Click);
            // 
            // wyczysc_button
            // 
            this.wyczysc_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wyczysc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczysc_button.Location = new System.Drawing.Point(962, 315);
            this.wyczysc_button.Name = "wyczysc_button";
            this.wyczysc_button.Size = new System.Drawing.Size(123, 47);
            this.wyczysc_button.TabIndex = 103;
            this.wyczysc_button.Text = "Wyczyść listę rozkazów";
            this.wyczysc_button.UseVisualStyleBackColor = false;
            this.wyczysc_button.Click += new System.EventHandler(this.wyczysc_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_button.Location = new System.Drawing.Point(1033, 406);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(93, 27);
            this.reset_button.TabIndex = 104;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.resetButtonClick);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.Location = new System.Drawing.Point(1148, 407);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(83, 26);
            this.exit_button.TabIndex = 105;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // AH_label
            // 
            this.AH_label.AutoSize = true;
            this.AH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AH_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AH_label.Location = new System.Drawing.Point(283, 52);
            this.AH_label.Name = "AH_label";
            this.AH_label.Size = new System.Drawing.Size(18, 20);
            this.AH_label.TabIndex = 122;
            this.AH_label.Text = "0";
            // 
            // AL_label
            // 
            this.AL_label.AutoSize = true;
            this.AL_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AL_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AL_label.Location = new System.Drawing.Point(283, 83);
            this.AL_label.Name = "AL_label";
            this.AL_label.Size = new System.Drawing.Size(18, 20);
            this.AL_label.TabIndex = 123;
            this.AL_label.Text = "0";
            // 
            // BL_label
            // 
            this.BL_label.AutoSize = true;
            this.BL_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BL_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BL_label.Location = new System.Drawing.Point(283, 193);
            this.BL_label.Name = "BL_label";
            this.BL_label.Size = new System.Drawing.Size(18, 20);
            this.BL_label.TabIndex = 125;
            this.BL_label.Text = "0";
            // 
            // BH_label
            // 
            this.BH_label.AutoSize = true;
            this.BH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BH_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BH_label.Location = new System.Drawing.Point(283, 162);
            this.BH_label.Name = "BH_label";
            this.BH_label.Size = new System.Drawing.Size(18, 20);
            this.BH_label.TabIndex = 124;
            this.BH_label.Text = "0";
            // 
            // CL_label
            // 
            this.CL_label.AutoSize = true;
            this.CL_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CL_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CL_label.Location = new System.Drawing.Point(283, 303);
            this.CL_label.Name = "CL_label";
            this.CL_label.Size = new System.Drawing.Size(18, 20);
            this.CL_label.TabIndex = 127;
            this.CL_label.Text = "0";
            // 
            // CH_label
            // 
            this.CH_label.AutoSize = true;
            this.CH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CH_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CH_label.Location = new System.Drawing.Point(283, 272);
            this.CH_label.Name = "CH_label";
            this.CH_label.Size = new System.Drawing.Size(18, 20);
            this.CH_label.TabIndex = 126;
            this.CH_label.Text = "0";
            // 
            // DL_label
            // 
            this.DL_label.AutoSize = true;
            this.DL_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DL_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DL_label.Location = new System.Drawing.Point(283, 413);
            this.DL_label.Name = "DL_label";
            this.DL_label.Size = new System.Drawing.Size(18, 20);
            this.DL_label.TabIndex = 129;
            this.DL_label.Text = "0";
            // 
            // DH_label
            // 
            this.DH_label.AutoSize = true;
            this.DH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DH_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DH_label.Location = new System.Drawing.Point(283, 382);
            this.DH_label.Name = "DH_label";
            this.DH_label.Size = new System.Drawing.Size(18, 20);
            this.DH_label.TabIndex = 128;
            this.DH_label.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r1_DL);
            this.groupBox1.Controls.Add(this.r1_DH);
            this.groupBox1.Controls.Add(this.r1_CL);
            this.groupBox1.Controls.Add(this.r1_CH);
            this.groupBox1.Controls.Add(this.r1_BL);
            this.groupBox1.Controls.Add(this.r1_BH);
            this.groupBox1.Controls.Add(this.r1_AL);
            this.groupBox1.Controls.Add(this.r1_AH);
            this.groupBox1.Location = new System.Drawing.Point(540, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(53, 267);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // r1_DL
            // 
            this.r1_DL.AutoSize = true;
            this.r1_DL.Location = new System.Drawing.Point(7, 227);
            this.r1_DL.Name = "r1_DL";
            this.r1_DL.Size = new System.Drawing.Size(39, 17);
            this.r1_DL.TabIndex = 133;
            this.r1_DL.TabStop = true;
            this.r1_DL.Text = "DL";
            this.r1_DL.UseVisualStyleBackColor = true;
            // 
            // r1_DH
            // 
            this.r1_DH.AutoSize = true;
            this.r1_DH.Location = new System.Drawing.Point(7, 198);
            this.r1_DH.Name = "r1_DH";
            this.r1_DH.Size = new System.Drawing.Size(41, 17);
            this.r1_DH.TabIndex = 132;
            this.r1_DH.TabStop = true;
            this.r1_DH.Text = "DH";
            this.r1_DH.UseVisualStyleBackColor = true;
            // 
            // r1_CL
            // 
            this.r1_CL.AutoSize = true;
            this.r1_CL.Location = new System.Drawing.Point(7, 169);
            this.r1_CL.Name = "r1_CL";
            this.r1_CL.Size = new System.Drawing.Size(38, 17);
            this.r1_CL.TabIndex = 5;
            this.r1_CL.TabStop = true;
            this.r1_CL.Text = "CL";
            this.r1_CL.UseVisualStyleBackColor = true;
            // 
            // r1_CH
            // 
            this.r1_CH.AutoSize = true;
            this.r1_CH.Location = new System.Drawing.Point(7, 140);
            this.r1_CH.Name = "r1_CH";
            this.r1_CH.Size = new System.Drawing.Size(40, 17);
            this.r1_CH.TabIndex = 4;
            this.r1_CH.TabStop = true;
            this.r1_CH.Text = "CH";
            this.r1_CH.UseVisualStyleBackColor = true;
            // 
            // r1_BL
            // 
            this.r1_BL.AutoSize = true;
            this.r1_BL.Location = new System.Drawing.Point(7, 111);
            this.r1_BL.Name = "r1_BL";
            this.r1_BL.Size = new System.Drawing.Size(38, 17);
            this.r1_BL.TabIndex = 3;
            this.r1_BL.TabStop = true;
            this.r1_BL.Text = "BL";
            this.r1_BL.UseVisualStyleBackColor = true;
            // 
            // r1_BH
            // 
            this.r1_BH.AutoSize = true;
            this.r1_BH.Location = new System.Drawing.Point(7, 82);
            this.r1_BH.Name = "r1_BH";
            this.r1_BH.Size = new System.Drawing.Size(40, 17);
            this.r1_BH.TabIndex = 2;
            this.r1_BH.TabStop = true;
            this.r1_BH.Text = "BH";
            this.r1_BH.UseVisualStyleBackColor = true;
            // 
            // r1_AL
            // 
            this.r1_AL.AutoSize = true;
            this.r1_AL.Location = new System.Drawing.Point(7, 53);
            this.r1_AL.Name = "r1_AL";
            this.r1_AL.Size = new System.Drawing.Size(38, 17);
            this.r1_AL.TabIndex = 1;
            this.r1_AL.TabStop = true;
            this.r1_AL.Text = "AL";
            this.r1_AL.UseVisualStyleBackColor = true;
            // 
            // r1_AH
            // 
            this.r1_AH.AutoSize = true;
            this.r1_AH.Checked = true;
            this.r1_AH.Location = new System.Drawing.Point(7, 24);
            this.r1_AH.Name = "r1_AH";
            this.r1_AH.Size = new System.Drawing.Size(40, 17);
            this.r1_AH.TabIndex = 0;
            this.r1_AH.TabStop = true;
            this.r1_AH.Text = "AH";
            this.r1_AH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.r2_DL);
            this.groupBox2.Controls.Add(this.r2_DH);
            this.groupBox2.Controls.Add(this.r2_CL);
            this.groupBox2.Controls.Add(this.r2_CH);
            this.groupBox2.Controls.Add(this.r2_BL);
            this.groupBox2.Controls.Add(this.r2_BH);
            this.groupBox2.Controls.Add(this.r2_AL);
            this.groupBox2.Controls.Add(this.r2_AH);
            this.groupBox2.Location = new System.Drawing.Point(703, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(53, 267);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            // 
            // r2_DL
            // 
            this.r2_DL.AutoSize = true;
            this.r2_DL.Location = new System.Drawing.Point(7, 227);
            this.r2_DL.Name = "r2_DL";
            this.r2_DL.Size = new System.Drawing.Size(39, 17);
            this.r2_DL.TabIndex = 133;
            this.r2_DL.TabStop = true;
            this.r2_DL.Text = "DL";
            this.r2_DL.UseVisualStyleBackColor = true;
            // 
            // r2_DH
            // 
            this.r2_DH.AutoSize = true;
            this.r2_DH.Location = new System.Drawing.Point(7, 198);
            this.r2_DH.Name = "r2_DH";
            this.r2_DH.Size = new System.Drawing.Size(41, 17);
            this.r2_DH.TabIndex = 132;
            this.r2_DH.TabStop = true;
            this.r2_DH.Text = "DH";
            this.r2_DH.UseVisualStyleBackColor = true;
            // 
            // r2_CL
            // 
            this.r2_CL.AutoSize = true;
            this.r2_CL.Location = new System.Drawing.Point(7, 169);
            this.r2_CL.Name = "r2_CL";
            this.r2_CL.Size = new System.Drawing.Size(38, 17);
            this.r2_CL.TabIndex = 5;
            this.r2_CL.TabStop = true;
            this.r2_CL.Text = "CL";
            this.r2_CL.UseVisualStyleBackColor = true;
            // 
            // r2_CH
            // 
            this.r2_CH.AutoSize = true;
            this.r2_CH.Location = new System.Drawing.Point(7, 140);
            this.r2_CH.Name = "r2_CH";
            this.r2_CH.Size = new System.Drawing.Size(40, 17);
            this.r2_CH.TabIndex = 4;
            this.r2_CH.TabStop = true;
            this.r2_CH.Text = "CH";
            this.r2_CH.UseVisualStyleBackColor = true;
            // 
            // r2_BL
            // 
            this.r2_BL.AutoSize = true;
            this.r2_BL.Location = new System.Drawing.Point(7, 111);
            this.r2_BL.Name = "r2_BL";
            this.r2_BL.Size = new System.Drawing.Size(38, 17);
            this.r2_BL.TabIndex = 3;
            this.r2_BL.TabStop = true;
            this.r2_BL.Text = "BL";
            this.r2_BL.UseVisualStyleBackColor = true;
            // 
            // r2_BH
            // 
            this.r2_BH.AutoSize = true;
            this.r2_BH.Checked = true;
            this.r2_BH.Location = new System.Drawing.Point(7, 82);
            this.r2_BH.Name = "r2_BH";
            this.r2_BH.Size = new System.Drawing.Size(40, 17);
            this.r2_BH.TabIndex = 2;
            this.r2_BH.TabStop = true;
            this.r2_BH.Text = "BH";
            this.r2_BH.UseVisualStyleBackColor = true;
            // 
            // r2_AL
            // 
            this.r2_AL.AutoSize = true;
            this.r2_AL.Location = new System.Drawing.Point(7, 53);
            this.r2_AL.Name = "r2_AL";
            this.r2_AL.Size = new System.Drawing.Size(38, 17);
            this.r2_AL.TabIndex = 1;
            this.r2_AL.TabStop = true;
            this.r2_AL.Text = "AL";
            this.r2_AL.UseVisualStyleBackColor = true;
            // 
            // r2_AH
            // 
            this.r2_AH.AutoSize = true;
            this.r2_AH.Location = new System.Drawing.Point(7, 24);
            this.r2_AH.Name = "r2_AH";
            this.r2_AH.Size = new System.Drawing.Size(40, 17);
            this.r2_AH.TabIndex = 0;
            this.r2_AH.TabStop = true;
            this.r2_AH.Text = "AH";
            this.r2_AH.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SUB);
            this.groupBox3.Controls.Add(this.ADD);
            this.groupBox3.Controls.Add(this.MOV);
            this.groupBox3.Location = new System.Drawing.Point(369, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(86, 108);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            // 
            // SUB
            // 
            this.SUB.AutoSize = true;
            this.SUB.Location = new System.Drawing.Point(19, 71);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(47, 17);
            this.SUB.TabIndex = 2;
            this.SUB.TabStop = true;
            this.SUB.Text = "SUB";
            this.SUB.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            this.ADD.AutoSize = true;
            this.ADD.Location = new System.Drawing.Point(19, 48);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(48, 17);
            this.ADD.TabIndex = 1;
            this.ADD.TabStop = true;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            // 
            // MOV
            // 
            this.MOV.AutoSize = true;
            this.MOV.Checked = true;
            this.MOV.Location = new System.Drawing.Point(19, 24);
            this.MOV.Name = "MOV";
            this.MOV.Size = new System.Drawing.Size(49, 17);
            this.MOV.TabIndex = 0;
            this.MOV.TabStop = true;
            this.MOV.Text = "MOV";
            this.MOV.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_stala
            // 
            this.textBox_stala.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_stala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_stala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox_stala.Location = new System.Drawing.Point(741, 356);
            this.textBox_stala.MaxLength = 3;
            this.textBox_stala.Multiline = true;
            this.textBox_stala.Name = "textBox_stala";
            this.textBox_stala.Size = new System.Drawing.Size(46, 24);
            this.textBox_stala.TabIndex = 133;
            this.textBox_stala.Text = "0";
            this.textBox_stala.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox_stala
            // 
            this.checkBox_stala.AutoSize = true;
            this.checkBox_stala.Location = new System.Drawing.Point(703, 364);
            this.checkBox_stala.Name = "checkBox_stala";
            this.checkBox_stala.Size = new System.Drawing.Size(15, 14);
            this.checkBox_stala.TabIndex = 134;
            this.checkBox_stala.UseVisualStyleBackColor = true;
            this.checkBox_stala.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(662, 325);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 26);
            this.textBox2.TabIndex = 135;
            this.textBox2.Text = "Stała";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 445);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox_stala);
            this.Controls.Add(this.textBox_stala);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DL_label);
            this.Controls.Add(this.DH_label);
            this.Controls.Add(this.CL_label);
            this.Controls.Add(this.CH_label);
            this.Controls.Add(this.BL_label);
            this.Controls.Add(this.BH_label);
            this.Controls.Add(this.AL_label);
            this.Controls.Add(this.AH_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.wyczysc_button);
            this.Controls.Add(this.calosc_button);
            this.Controls.Add(this.krokowa_button);
            this.Controls.Add(this.dodaj_button);
            this.Controls.Add(this.lista_textbox);
            this.Controls.Add(this.rejestr2_textbox);
            this.Controls.Add(this.rozkaz_textbox);
            this.Controls.Add(this.rejestr1_textbox);
            this.Controls.Add(this.dl0);
            this.Controls.Add(this.dl1);
            this.Controls.Add(this.dl2);
            this.Controls.Add(this.dl3);
            this.Controls.Add(this.dl4);
            this.Controls.Add(this.dl5);
            this.Controls.Add(this.dl6);
            this.Controls.Add(this.dl7);
            this.Controls.Add(this.dh0);
            this.Controls.Add(this.dh1);
            this.Controls.Add(this.dh2);
            this.Controls.Add(this.dh3);
            this.Controls.Add(this.dh4);
            this.Controls.Add(this.dh5);
            this.Controls.Add(this.dh6);
            this.Controls.Add(this.dh7);
            this.Controls.Add(this.cl0);
            this.Controls.Add(this.cl1);
            this.Controls.Add(this.cl2);
            this.Controls.Add(this.cl3);
            this.Controls.Add(this.cl4);
            this.Controls.Add(this.cl5);
            this.Controls.Add(this.cl6);
            this.Controls.Add(this.cl7);
            this.Controls.Add(this.ch0);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.ch5);
            this.Controls.Add(this.ch6);
            this.Controls.Add(this.ch7);
            this.Controls.Add(this.bl0);
            this.Controls.Add(this.bl1);
            this.Controls.Add(this.bl2);
            this.Controls.Add(this.bl3);
            this.Controls.Add(this.bl4);
            this.Controls.Add(this.bl5);
            this.Controls.Add(this.bl6);
            this.Controls.Add(this.bl7);
            this.Controls.Add(this.bh0);
            this.Controls.Add(this.bh1);
            this.Controls.Add(this.bh2);
            this.Controls.Add(this.bh3);
            this.Controls.Add(this.bh4);
            this.Controls.Add(this.bh5);
            this.Controls.Add(this.bh6);
            this.Controls.Add(this.bh7);
            this.Controls.Add(this.al0);
            this.Controls.Add(this.al1);
            this.Controls.Add(this.al2);
            this.Controls.Add(this.al3);
            this.Controls.Add(this.al4);
            this.Controls.Add(this.al5);
            this.Controls.Add(this.al6);
            this.Controls.Add(this.al7);
            this.Controls.Add(this.ah0);
            this.Controls.Add(this.ah1);
            this.Controls.Add(this.ah2);
            this.Controls.Add(this.ah3);
            this.Controls.Add(this.ah4);
            this.Controls.Add(this.ah5);
            this.Controls.Add(this.ah6);
            this.Controls.Add(this.ah7);
            this.Controls.Add(this.DH_textbox);
            this.Controls.Add(this.DL_textbox);
            this.Controls.Add(this.CH_textbox);
            this.Controls.Add(this.CL_textbox);
            this.Controls.Add(this.BH_textbox);
            this.Controls.Add(this.BL_textbox);
            this.Controls.Add(this.AH_textbox);
            this.Controls.Add(this.AL_textbox);
            this.Controls.Add(this.DX_textbox);
            this.Controls.Add(this.CX_textbox);
            this.Controls.Add(this.BX_textbox);
            this.Controls.Add(this.AX_textbox);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AX_textbox;
        private System.Windows.Forms.TextBox BX_textbox;
        private System.Windows.Forms.TextBox CX_textbox;
        private System.Windows.Forms.TextBox DX_textbox;
        private System.Windows.Forms.TextBox AL_textbox;
        private System.Windows.Forms.TextBox AH_textbox;
        private System.Windows.Forms.TextBox BL_textbox;
        private System.Windows.Forms.TextBox BH_textbox;
        private System.Windows.Forms.TextBox CL_textbox;
        private System.Windows.Forms.TextBox CH_textbox;
        private System.Windows.Forms.TextBox DL_textbox;
        private System.Windows.Forms.TextBox DH_textbox;
        private System.Windows.Forms.Button ah7;
        private System.Windows.Forms.Button ah6;
        private System.Windows.Forms.Button ah5;
        private System.Windows.Forms.Button ah4;
        private System.Windows.Forms.Button ah3;
        private System.Windows.Forms.Button ah2;
        private System.Windows.Forms.Button ah1;
        private System.Windows.Forms.Button ah0;
        private System.Windows.Forms.Button al0;
        private System.Windows.Forms.Button al1;
        private System.Windows.Forms.Button al2;
        private System.Windows.Forms.Button al3;
        private System.Windows.Forms.Button al4;
        private System.Windows.Forms.Button al5;
        private System.Windows.Forms.Button al6;
        private System.Windows.Forms.Button al7;
        private System.Windows.Forms.Button bh0;
        private System.Windows.Forms.Button bh1;
        private System.Windows.Forms.Button bh2;
        private System.Windows.Forms.Button bh3;
        private System.Windows.Forms.Button bh4;
        private System.Windows.Forms.Button bh5;
        private System.Windows.Forms.Button bh6;
        private System.Windows.Forms.Button bh7;
        private System.Windows.Forms.Button bl0;
        private System.Windows.Forms.Button bl1;
        private System.Windows.Forms.Button bl2;
        private System.Windows.Forms.Button bl3;
        private System.Windows.Forms.Button bl4;
        private System.Windows.Forms.Button bl5;
        private System.Windows.Forms.Button bl6;
        private System.Windows.Forms.Button bl7;
        private System.Windows.Forms.Button ch0;
        private System.Windows.Forms.Button ch1;
        private System.Windows.Forms.Button ch2;
        private System.Windows.Forms.Button ch3;
        private System.Windows.Forms.Button ch4;
        private System.Windows.Forms.Button ch5;
        private System.Windows.Forms.Button ch6;
        private System.Windows.Forms.Button ch7;
        private System.Windows.Forms.Button cl0;
        private System.Windows.Forms.Button cl1;
        private System.Windows.Forms.Button cl2;
        private System.Windows.Forms.Button cl3;
        private System.Windows.Forms.Button cl4;
        private System.Windows.Forms.Button cl5;
        private System.Windows.Forms.Button cl6;
        private System.Windows.Forms.Button cl7;
        private System.Windows.Forms.Button dh0;
        private System.Windows.Forms.Button dh1;
        private System.Windows.Forms.Button dh2;
        private System.Windows.Forms.Button dh3;
        private System.Windows.Forms.Button dh4;
        private System.Windows.Forms.Button dh5;
        private System.Windows.Forms.Button dh6;
        private System.Windows.Forms.Button dh7;
        private System.Windows.Forms.Button dl0;
        private System.Windows.Forms.Button dl1;
        private System.Windows.Forms.Button dl2;
        private System.Windows.Forms.Button dl3;
        private System.Windows.Forms.Button dl4;
        private System.Windows.Forms.Button dl5;
        private System.Windows.Forms.Button dl6;
        private System.Windows.Forms.Button dl7;
        private System.Windows.Forms.TextBox rejestr1_textbox;
        private System.Windows.Forms.TextBox rozkaz_textbox;
        private System.Windows.Forms.TextBox rejestr2_textbox;
        private System.Windows.Forms.TextBox lista_textbox;
        private System.Windows.Forms.Button dodaj_button;
        private System.Windows.Forms.Button krokowa_button;
        private System.Windows.Forms.Button calosc_button;
        private System.Windows.Forms.Button wyczysc_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button exit_button;
        private Label AH_label;
        private Label AL_label;
        private Label BL_label;
        private Label BH_label;
        private Label CL_label;
        private Label CH_label;
        private Label DL_label;
        private Label DH_label;
        private GroupBox groupBox1;
        private RadioButton r1_AL;
        private RadioButton r1_AH;
        private RadioButton r1_DL;
        private RadioButton r1_DH;
        private RadioButton r1_CL;
        private RadioButton r1_CH;
        private RadioButton r1_BL;
        private RadioButton r1_BH;
        private GroupBox groupBox2;
        private RadioButton r2_DL;
        private RadioButton r2_DH;
        private RadioButton r2_CL;
        private RadioButton r2_CH;
        private RadioButton r2_BL;
        private RadioButton r2_BH;
        private RadioButton r2_AL;
        private RadioButton r2_AH;
        private GroupBox groupBox3;
        private RadioButton SUB;
        private RadioButton ADD;
        private RadioButton MOV;
        private Timer timer1;
        private TextBox textBox_stala;
        private CheckBox checkBox_stala;
        private TextBox textBox2;
    }
}

