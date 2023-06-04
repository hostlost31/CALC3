namespace CALC3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num1 = new System.Windows.Forms.Button();
            this.DECKBOX = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.but_point = new System.Windows.Forms.Button();
            this.but_RESULT = new System.Windows.Forms.Button();
            this.but_Plus = new System.Windows.Forms.Button();
            this.but_minus = new System.Windows.Forms.Button();
            this.but_umno = new System.Windows.Forms.Button();
            this.but_inversia = new System.Windows.Forms.Button();
            this.but_mod = new System.Windows.Forms.Button();
            this.but_delenie = new System.Windows.Forms.Button();
            this.but_BackSpace = new System.Windows.Forms.Button();
            this.but_Pi = new System.Windows.Forms.Button();
            this.but_ClearFULL = new System.Windows.Forms.Button();
            this.but_e = new System.Windows.Forms.Button();
            this.but_MC = new System.Windows.Forms.Button();
            this.but_MR = new System.Windows.Forms.Button();
            this.but_MS = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_DAG = new System.Windows.Forms.Button();
            this.but_RAD = new System.Windows.Forms.Button();
            this.but_coth = new System.Windows.Forms.Button();
            this.but_csch = new System.Windows.Forms.Button();
            this.but_sech = new System.Windows.Forms.Button();
            this.but_tanh = new System.Windows.Forms.Button();
            this.but_cosh = new System.Windows.Forms.Button();
            this.but_sinh = new System.Windows.Forms.Button();
            this.but_cot1 = new System.Windows.Forms.Button();
            this.but_cot = new System.Windows.Forms.Button();
            this.but_LN = new System.Windows.Forms.Button();
            this.but_csc1 = new System.Windows.Forms.Button();
            this.but_csc = new System.Windows.Forms.Button();
            this.but_2qrt = new System.Windows.Forms.Button();
            this.but_10qrt = new System.Windows.Forms.Button();
            this.but_sec1 = new System.Windows.Forms.Button();
            this.but_sec = new System.Windows.Forms.Button();
            this.but_qrt = new System.Windows.Forms.Button();
            this.but_sqrtY = new System.Windows.Forms.Button();
            this.but_tan1 = new System.Windows.Forms.Button();
            this.but_tan = new System.Windows.Forms.Button();
            this.but_sqrt3 = new System.Windows.Forms.Button();
            this.but_sqrt = new System.Windows.Forms.Button();
            this.but_cos1 = new System.Windows.Forms.Button();
            this.but_cos = new System.Windows.Forms.Button();
            this.but_qrt3 = new System.Windows.Forms.Button();
            this.but_qrt2 = new System.Windows.Forms.Button();
            this.but_sin1 = new System.Windows.Forms.Button();
            this.but_sin = new System.Windows.Forms.Button();
            this.but_skob2 = new System.Windows.Forms.Button();
            this.but_skob1 = new System.Windows.Forms.Button();
            this.UNITBOX = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 317);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(59, 47);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // DECKBOX
            // 
            this.DECKBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DECKBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DECKBOX.Location = new System.Drawing.Point(5, 27);
            this.DECKBOX.Name = "DECKBOX";
            this.DECKBOX.Size = new System.Drawing.Size(594, 62);
            this.DECKBOX.TabIndex = 1;
            this.DECKBOX.Text = "0";
            this.DECKBOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox1_KeyUp);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(77, 317);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(59, 47);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(142, 317);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(59, 47);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 264);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(59, 47);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(77, 264);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(59, 47);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(142, 264);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(59, 47);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 211);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(59, 47);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(77, 211);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(59, 47);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(142, 211);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(59, 47);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(77, 370);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(59, 47);
            this.num0.TabIndex = 10;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_point
            // 
            this.but_point.Location = new System.Drawing.Point(142, 370);
            this.but_point.Name = "but_point";
            this.but_point.Size = new System.Drawing.Size(59, 47);
            this.but_point.TabIndex = 11;
            this.but_point.Text = ",";
            this.but_point.UseVisualStyleBackColor = true;
            this.but_point.Click += new System.EventHandler(this.butZAPAT_Click);
            // 
            // but_RESULT
            // 
            this.but_RESULT.Location = new System.Drawing.Point(207, 370);
            this.but_RESULT.Name = "but_RESULT";
            this.but_RESULT.Size = new System.Drawing.Size(59, 47);
            this.but_RESULT.TabIndex = 12;
            this.but_RESULT.Text = "=";
            this.but_RESULT.UseVisualStyleBackColor = true;
            this.but_RESULT.Click += new System.EventHandler(this.butRESULT_Click);
            // 
            // but_Plus
            // 
            this.but_Plus.Location = new System.Drawing.Point(207, 315);
            this.but_Plus.Name = "but_Plus";
            this.but_Plus.Size = new System.Drawing.Size(59, 47);
            this.but_Plus.TabIndex = 14;
            this.but_Plus.Text = "+";
            this.but_Plus.UseVisualStyleBackColor = true;
            this.but_Plus.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_minus
            // 
            this.but_minus.Location = new System.Drawing.Point(207, 264);
            this.but_minus.Name = "but_minus";
            this.but_minus.Size = new System.Drawing.Size(59, 47);
            this.but_minus.TabIndex = 15;
            this.but_minus.Text = "-";
            this.but_minus.UseVisualStyleBackColor = true;
            this.but_minus.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_umno
            // 
            this.but_umno.Location = new System.Drawing.Point(207, 211);
            this.but_umno.Name = "but_umno";
            this.but_umno.Size = new System.Drawing.Size(59, 47);
            this.but_umno.TabIndex = 16;
            this.but_umno.Text = "*";
            this.but_umno.UseVisualStyleBackColor = true;
            this.but_umno.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_inversia
            // 
            this.but_inversia.Location = new System.Drawing.Point(12, 370);
            this.but_inversia.Name = "but_inversia";
            this.but_inversia.Size = new System.Drawing.Size(59, 47);
            this.but_inversia.TabIndex = 20;
            this.but_inversia.Text = "+/-";
            this.but_inversia.UseVisualStyleBackColor = true;
            this.but_inversia.Click += new System.EventHandler(this.but_inversia_Click);
            // 
            // but_mod
            // 
            this.but_mod.Location = new System.Drawing.Point(280, 368);
            this.but_mod.Name = "but_mod";
            this.but_mod.Size = new System.Drawing.Size(59, 47);
            this.but_mod.TabIndex = 21;
            this.but_mod.Text = "%";
            this.but_mod.UseVisualStyleBackColor = true;
            this.but_mod.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_delenie
            // 
            this.but_delenie.Location = new System.Drawing.Point(207, 158);
            this.but_delenie.Name = "but_delenie";
            this.but_delenie.Size = new System.Drawing.Size(59, 47);
            this.but_delenie.TabIndex = 22;
            this.but_delenie.Text = "/";
            this.but_delenie.UseVisualStyleBackColor = true;
            this.but_delenie.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_BackSpace
            // 
            this.but_BackSpace.Location = new System.Drawing.Point(207, 105);
            this.but_BackSpace.Name = "but_BackSpace";
            this.but_BackSpace.Size = new System.Drawing.Size(59, 47);
            this.but_BackSpace.TabIndex = 23;
            this.but_BackSpace.Text = "<<";
            this.but_BackSpace.UseVisualStyleBackColor = true;
            this.but_BackSpace.Click += new System.EventHandler(this.But_BackSpace);
            // 
            // but_Pi
            // 
            this.but_Pi.Location = new System.Drawing.Point(77, 105);
            this.but_Pi.Name = "but_Pi";
            this.but_Pi.Size = new System.Drawing.Size(59, 47);
            this.but_Pi.TabIndex = 24;
            this.but_Pi.Text = "π";
            this.but_Pi.UseVisualStyleBackColor = true;
            this.but_Pi.Click += new System.EventHandler(this.but_Pi_Click);
            // 
            // but_ClearFULL
            // 
            this.but_ClearFULL.Location = new System.Drawing.Point(142, 105);
            this.but_ClearFULL.Name = "but_ClearFULL";
            this.but_ClearFULL.Size = new System.Drawing.Size(59, 47);
            this.but_ClearFULL.TabIndex = 25;
            this.but_ClearFULL.Text = "CE";
            this.but_ClearFULL.UseVisualStyleBackColor = true;
            this.but_ClearFULL.Click += new System.EventHandler(this.but_ClearFULL_Click);
            // 
            // but_e
            // 
            this.but_e.Location = new System.Drawing.Point(12, 105);
            this.but_e.Name = "but_e";
            this.but_e.Size = new System.Drawing.Size(59, 47);
            this.but_e.TabIndex = 26;
            this.but_e.Text = "e";
            this.but_e.UseVisualStyleBackColor = true;
            this.but_e.Click += new System.EventHandler(this.but_e_Click);
            // 
            // but_MC
            // 
            this.but_MC.Location = new System.Drawing.Point(77, 158);
            this.but_MC.Name = "but_MC";
            this.but_MC.Size = new System.Drawing.Size(59, 47);
            this.but_MC.TabIndex = 28;
            this.but_MC.Text = "MC";
            this.but_MC.UseVisualStyleBackColor = true;
            this.but_MC.Click += new System.EventHandler(this.M_Clear_Button_Click);
            // 
            // but_MR
            // 
            this.but_MR.Location = new System.Drawing.Point(12, 158);
            this.but_MR.Name = "but_MR";
            this.but_MR.Size = new System.Drawing.Size(59, 47);
            this.but_MR.TabIndex = 29;
            this.but_MR.Text = "MR";
            this.but_MR.UseVisualStyleBackColor = true;
            this.but_MR.Click += new System.EventHandler(this.M_Result_Button_Click);
            // 
            // but_MS
            // 
            this.but_MS.Location = new System.Drawing.Point(142, 158);
            this.but_MS.Name = "but_MS";
            this.but_MS.Size = new System.Drawing.Size(59, 47);
            this.but_MS.TabIndex = 31;
            this.but_MS.Text = "MS";
            this.but_MS.UseVisualStyleBackColor = true;
            this.but_MS.Click += new System.EventHandler(this.M_Plus_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandartToolStripMenuItem,
            this.EngineeringToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // StandartToolStripMenuItem
            // 
            this.StandartToolStripMenuItem.Name = "StandartToolStripMenuItem";
            this.StandartToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.StandartToolStripMenuItem.Text = "Standart";
            this.StandartToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click);
            // 
            // EngineeringToolStripMenuItem
            // 
            this.EngineeringToolStripMenuItem.Name = "EngineeringToolStripMenuItem";
            this.EngineeringToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.EngineeringToolStripMenuItem.Text = "engineering";
            this.EngineeringToolStripMenuItem.Click += new System.EventHandler(this.EngineeringToolStripMenuItem_Click);
            // 
            // but_DAG
            // 
            this.but_DAG.Location = new System.Drawing.Point(468, 0);
            this.but_DAG.Name = "but_DAG";
            this.but_DAG.Size = new System.Drawing.Size(59, 24);
            this.but_DAG.TabIndex = 45;
            this.but_DAG.Text = "dag";
            this.but_DAG.UseVisualStyleBackColor = true;
            this.but_DAG.Click += new System.EventHandler(this.but_DAG_Click);
            // 
            // but_RAD
            // 
            this.but_RAD.Location = new System.Drawing.Point(533, 0);
            this.but_RAD.Name = "but_RAD";
            this.but_RAD.Size = new System.Drawing.Size(59, 24);
            this.but_RAD.TabIndex = 65;
            this.but_RAD.Text = "rad";
            this.but_RAD.UseVisualStyleBackColor = true;
            this.but_RAD.Click += new System.EventHandler(this.but_RAD_Click);
            // 
            // but_coth
            // 
            this.but_coth.Location = new System.Drawing.Point(540, 370);
            this.but_coth.Name = "but_coth";
            this.but_coth.Size = new System.Drawing.Size(59, 47);
            this.but_coth.TabIndex = 125;
            this.but_coth.Text = "coth";
            this.but_coth.UseVisualStyleBackColor = true;
            this.but_coth.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_csch
            // 
            this.but_csch.Location = new System.Drawing.Point(540, 317);
            this.but_csch.Name = "but_csch";
            this.but_csch.Size = new System.Drawing.Size(59, 47);
            this.but_csch.TabIndex = 124;
            this.but_csch.Text = "csch";
            this.but_csch.UseVisualStyleBackColor = true;
            this.but_csch.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_sech
            // 
            this.but_sech.Location = new System.Drawing.Point(540, 264);
            this.but_sech.Name = "but_sech";
            this.but_sech.Size = new System.Drawing.Size(59, 47);
            this.but_sech.TabIndex = 123;
            this.but_sech.Text = "sech";
            this.but_sech.UseVisualStyleBackColor = true;
            this.but_sech.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_tanh
            // 
            this.but_tanh.Location = new System.Drawing.Point(540, 211);
            this.but_tanh.Name = "but_tanh";
            this.but_tanh.Size = new System.Drawing.Size(59, 47);
            this.but_tanh.TabIndex = 122;
            this.but_tanh.Text = "tanh";
            this.but_tanh.UseVisualStyleBackColor = true;
            this.but_tanh.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_cosh
            // 
            this.but_cosh.Location = new System.Drawing.Point(540, 158);
            this.but_cosh.Name = "but_cosh";
            this.but_cosh.Size = new System.Drawing.Size(59, 47);
            this.but_cosh.TabIndex = 121;
            this.but_cosh.Text = "cosh";
            this.but_cosh.UseVisualStyleBackColor = true;
            this.but_cosh.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_sinh
            // 
            this.but_sinh.Location = new System.Drawing.Point(540, 105);
            this.but_sinh.Name = "but_sinh";
            this.but_sinh.Size = new System.Drawing.Size(59, 47);
            this.but_sinh.TabIndex = 120;
            this.but_sinh.Text = "sinh";
            this.but_sinh.UseVisualStyleBackColor = true;
            this.but_sinh.Click += new System.EventHandler(this.but_TrigonomANDTrigH_Click);
            // 
            // but_cot1
            // 
            this.but_cot1.Location = new System.Drawing.Point(475, 370);
            this.but_cot1.Name = "but_cot1";
            this.but_cot1.Size = new System.Drawing.Size(59, 47);
            this.but_cot1.TabIndex = 119;
            this.but_cot1.Text = "cot^-1";
            this.but_cot1.UseVisualStyleBackColor = true;
            this.but_cot1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_cot
            // 
            this.but_cot.Location = new System.Drawing.Point(410, 370);
            this.but_cot.Name = "but_cot";
            this.but_cot.Size = new System.Drawing.Size(59, 47);
            this.but_cot.TabIndex = 118;
            this.but_cot.Text = "cot";
            this.but_cot.UseVisualStyleBackColor = true;
            this.but_cot.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_LN
            // 
            this.but_LN.Location = new System.Drawing.Point(345, 370);
            this.but_LN.Name = "but_LN";
            this.but_LN.Size = new System.Drawing.Size(59, 47);
            this.but_LN.TabIndex = 116;
            this.but_LN.Text = "ln";
            this.but_LN.UseVisualStyleBackColor = true;
            this.but_LN.Click += new System.EventHandler(this.but_LN_Click);
            // 
            // but_csc1
            // 
            this.but_csc1.Location = new System.Drawing.Point(475, 317);
            this.but_csc1.Name = "but_csc1";
            this.but_csc1.Size = new System.Drawing.Size(59, 47);
            this.but_csc1.TabIndex = 115;
            this.but_csc1.Text = "csc^-1";
            this.but_csc1.UseVisualStyleBackColor = true;
            this.but_csc1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_csc
            // 
            this.but_csc.Location = new System.Drawing.Point(410, 317);
            this.but_csc.Name = "but_csc";
            this.but_csc.Size = new System.Drawing.Size(59, 47);
            this.but_csc.TabIndex = 114;
            this.but_csc.Text = "csc";
            this.but_csc.UseVisualStyleBackColor = true;
            this.but_csc.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_2qrt
            // 
            this.but_2qrt.Location = new System.Drawing.Point(345, 315);
            this.but_2qrt.Name = "but_2qrt";
            this.but_2qrt.Size = new System.Drawing.Size(59, 47);
            this.but_2qrt.TabIndex = 113;
            this.but_2qrt.Text = "2^x";
            this.but_2qrt.UseVisualStyleBackColor = true;
            this.but_2qrt.Click += new System.EventHandler(this.PowX2);
            // 
            // but_10qrt
            // 
            this.but_10qrt.Location = new System.Drawing.Point(280, 315);
            this.but_10qrt.Name = "but_10qrt";
            this.but_10qrt.Size = new System.Drawing.Size(59, 47);
            this.but_10qrt.TabIndex = 112;
            this.but_10qrt.Text = "10^x";
            this.but_10qrt.UseVisualStyleBackColor = true;
            this.but_10qrt.Click += new System.EventHandler(this.PowX);
            // 
            // but_sec1
            // 
            this.but_sec1.Location = new System.Drawing.Point(475, 264);
            this.but_sec1.Name = "but_sec1";
            this.but_sec1.Size = new System.Drawing.Size(59, 47);
            this.but_sec1.TabIndex = 111;
            this.but_sec1.Text = "sec^-1";
            this.but_sec1.UseVisualStyleBackColor = true;
            this.but_sec1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_sec
            // 
            this.but_sec.Location = new System.Drawing.Point(410, 264);
            this.but_sec.Name = "but_sec";
            this.but_sec.Size = new System.Drawing.Size(59, 47);
            this.but_sec.TabIndex = 110;
            this.but_sec.Text = "sec";
            this.but_sec.UseVisualStyleBackColor = true;
            this.but_sec.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_qrt
            // 
            this.but_qrt.Location = new System.Drawing.Point(280, 264);
            this.but_qrt.Name = "but_qrt";
            this.but_qrt.Size = new System.Drawing.Size(59, 47);
            this.but_qrt.TabIndex = 109;
            this.but_qrt.Text = "x^y";
            this.but_qrt.UseVisualStyleBackColor = true;
            this.but_qrt.Click += new System.EventHandler(this.but_qrt_Click_1);
            // 
            // but_sqrtY
            // 
            this.but_sqrtY.Location = new System.Drawing.Point(345, 264);
            this.but_sqrtY.Name = "but_sqrtY";
            this.but_sqrtY.Size = new System.Drawing.Size(59, 47);
            this.but_sqrtY.TabIndex = 108;
            this.but_sqrtY.Text = "х^(1/y)";
            this.but_sqrtY.UseVisualStyleBackColor = true;
            this.but_sqrtY.Click += new System.EventHandler(this.but_Sqrt1x_Click);
            // 
            // but_tan1
            // 
            this.but_tan1.Location = new System.Drawing.Point(475, 211);
            this.but_tan1.Name = "but_tan1";
            this.but_tan1.Size = new System.Drawing.Size(59, 47);
            this.but_tan1.TabIndex = 107;
            this.but_tan1.Text = "tan^-1";
            this.but_tan1.UseVisualStyleBackColor = true;
            this.but_tan1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_tan
            // 
            this.but_tan.Location = new System.Drawing.Point(410, 211);
            this.but_tan.Name = "but_tan";
            this.but_tan.Size = new System.Drawing.Size(59, 47);
            this.but_tan.TabIndex = 106;
            this.but_tan.Text = "tan";
            this.but_tan.UseVisualStyleBackColor = true;
            this.but_tan.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_sqrt3
            // 
            this.but_sqrt3.Location = new System.Drawing.Point(345, 211);
            this.but_sqrt3.Name = "but_sqrt3";
            this.but_sqrt3.Size = new System.Drawing.Size(59, 47);
            this.but_sqrt3.TabIndex = 105;
            this.but_sqrt3.Text = "х^(1/3)";
            this.but_sqrt3.UseVisualStyleBackColor = true;
            this.but_sqrt3.Click += new System.EventHandler(this.but_QRT_Click);
            // 
            // but_sqrt
            // 
            this.but_sqrt.Location = new System.Drawing.Point(280, 211);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(59, 47);
            this.but_sqrt.TabIndex = 104;
            this.but_sqrt.Text = "x^(1/2)";
            this.but_sqrt.UseVisualStyleBackColor = true;
            this.but_sqrt.Click += new System.EventHandler(this.but_QRT_Click);
            // 
            // but_cos1
            // 
            this.but_cos1.Location = new System.Drawing.Point(475, 158);
            this.but_cos1.Name = "but_cos1";
            this.but_cos1.Size = new System.Drawing.Size(59, 47);
            this.but_cos1.TabIndex = 103;
            this.but_cos1.Text = "cos^-1";
            this.but_cos1.UseVisualStyleBackColor = true;
            this.but_cos1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_cos
            // 
            this.but_cos.Location = new System.Drawing.Point(410, 158);
            this.but_cos.Name = "but_cos";
            this.but_cos.Size = new System.Drawing.Size(59, 47);
            this.but_cos.TabIndex = 102;
            this.but_cos.Text = "cos";
            this.but_cos.UseVisualStyleBackColor = true;
            this.but_cos.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_qrt3
            // 
            this.but_qrt3.Location = new System.Drawing.Point(345, 158);
            this.but_qrt3.Name = "but_qrt3";
            this.but_qrt3.Size = new System.Drawing.Size(59, 47);
            this.but_qrt3.TabIndex = 101;
            this.but_qrt3.Text = "х^3";
            this.but_qrt3.UseVisualStyleBackColor = true;
            this.but_qrt3.Click += new System.EventHandler(this.but_QRT_Click);
            // 
            // but_qrt2
            // 
            this.but_qrt2.Location = new System.Drawing.Point(280, 158);
            this.but_qrt2.Name = "but_qrt2";
            this.but_qrt2.Size = new System.Drawing.Size(59, 47);
            this.but_qrt2.TabIndex = 100;
            this.but_qrt2.Text = "x^2";
            this.but_qrt2.UseVisualStyleBackColor = true;
            this.but_qrt2.Click += new System.EventHandler(this.but_QRT_Click);
            // 
            // but_sin1
            // 
            this.but_sin1.Location = new System.Drawing.Point(475, 105);
            this.but_sin1.Name = "but_sin1";
            this.but_sin1.Size = new System.Drawing.Size(59, 47);
            this.but_sin1.TabIndex = 99;
            this.but_sin1.Text = "sin^-1";
            this.but_sin1.UseVisualStyleBackColor = true;
            this.but_sin1.Click += new System.EventHandler(this.TrigFormMinus1);
            // 
            // but_sin
            // 
            this.but_sin.Location = new System.Drawing.Point(410, 105);
            this.but_sin.Name = "but_sin";
            this.but_sin.Size = new System.Drawing.Size(59, 47);
            this.but_sin.TabIndex = 98;
            this.but_sin.Text = "sin";
            this.but_sin.UseVisualStyleBackColor = true;
            this.but_sin.Click += new System.EventHandler(this.but_TrigonomForm_Click);
            // 
            // but_skob2
            // 
            this.but_skob2.Location = new System.Drawing.Point(345, 105);
            this.but_skob2.Name = "but_skob2";
            this.but_skob2.Size = new System.Drawing.Size(59, 47);
            this.but_skob2.TabIndex = 97;
            this.but_skob2.Text = ")";
            this.but_skob2.UseVisualStyleBackColor = true;
            this.but_skob2.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // but_skob1
            // 
            this.but_skob1.Location = new System.Drawing.Point(280, 105);
            this.but_skob1.Name = "but_skob1";
            this.but_skob1.Size = new System.Drawing.Size(59, 47);
            this.but_skob1.TabIndex = 96;
            this.but_skob1.Text = "(";
            this.but_skob1.UseVisualStyleBackColor = true;
            this.but_skob1.Click += new System.EventHandler(this.butNUMandOPERAND_Click);
            // 
            // UNITBOX
            // 
            this.UNITBOX.Location = new System.Drawing.Point(362, 3);
            this.UNITBOX.Name = "UNITBOX";
            this.UNITBOX.Size = new System.Drawing.Size(100, 20);
            this.UNITBOX.TabIndex = 126;
            this.UNITBOX.Text = "degree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 424);
            this.Controls.Add(this.UNITBOX);
            this.Controls.Add(this.but_coth);
            this.Controls.Add(this.but_csch);
            this.Controls.Add(this.but_sech);
            this.Controls.Add(this.but_tanh);
            this.Controls.Add(this.but_cosh);
            this.Controls.Add(this.but_sinh);
            this.Controls.Add(this.but_cot1);
            this.Controls.Add(this.but_cot);
            this.Controls.Add(this.but_LN);
            this.Controls.Add(this.but_csc1);
            this.Controls.Add(this.but_csc);
            this.Controls.Add(this.but_2qrt);
            this.Controls.Add(this.but_10qrt);
            this.Controls.Add(this.but_sec1);
            this.Controls.Add(this.but_sec);
            this.Controls.Add(this.but_qrt);
            this.Controls.Add(this.but_sqrtY);
            this.Controls.Add(this.but_tan1);
            this.Controls.Add(this.but_tan);
            this.Controls.Add(this.but_sqrt3);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_cos1);
            this.Controls.Add(this.but_cos);
            this.Controls.Add(this.but_qrt3);
            this.Controls.Add(this.but_qrt2);
            this.Controls.Add(this.but_sin1);
            this.Controls.Add(this.but_sin);
            this.Controls.Add(this.but_skob2);
            this.Controls.Add(this.but_skob1);
            this.Controls.Add(this.but_RAD);
            this.Controls.Add(this.but_DAG);
            this.Controls.Add(this.but_MS);
            this.Controls.Add(this.but_MR);
            this.Controls.Add(this.but_MC);
            this.Controls.Add(this.but_e);
            this.Controls.Add(this.but_ClearFULL);
            this.Controls.Add(this.but_Pi);
            this.Controls.Add(this.but_BackSpace);
            this.Controls.Add(this.but_delenie);
            this.Controls.Add(this.but_mod);
            this.Controls.Add(this.but_inversia);
            this.Controls.Add(this.but_umno);
            this.Controls.Add(this.but_minus);
            this.Controls.Add(this.but_Plus);
            this.Controls.Add(this.but_RESULT);
            this.Controls.Add(this.but_point);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.DECKBOX);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALC3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.TextBox DECKBOX;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button but_point;
        private System.Windows.Forms.Button but_RESULT;
        private System.Windows.Forms.Button but_Plus;
        private System.Windows.Forms.Button but_minus;
        private System.Windows.Forms.Button but_umno;
        private System.Windows.Forms.Button but_inversia;
        private System.Windows.Forms.Button but_mod;
        private System.Windows.Forms.Button but_delenie;
        private System.Windows.Forms.Button but_BackSpace;
        private System.Windows.Forms.Button but_Pi;
        private System.Windows.Forms.Button but_ClearFULL;
        private System.Windows.Forms.Button but_e;
        private System.Windows.Forms.Button but_MC;
        private System.Windows.Forms.Button but_MR;
        private System.Windows.Forms.Button but_MS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StandartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EngineeringToolStripMenuItem;
        private System.Windows.Forms.Button but_DAG;
        private System.Windows.Forms.Button but_RAD;
        private System.Windows.Forms.Button but_coth;
        private System.Windows.Forms.Button but_csch;
        private System.Windows.Forms.Button but_sech;
        private System.Windows.Forms.Button but_tanh;
        private System.Windows.Forms.Button but_cosh;
        private System.Windows.Forms.Button but_sinh;
        private System.Windows.Forms.Button but_cot1;
        private System.Windows.Forms.Button but_cot;
        private System.Windows.Forms.Button but_LN;
        private System.Windows.Forms.Button but_csc1;
        private System.Windows.Forms.Button but_csc;
        private System.Windows.Forms.Button but_2qrt;
        private System.Windows.Forms.Button but_10qrt;
        private System.Windows.Forms.Button but_sec1;
        private System.Windows.Forms.Button but_sec;
        private System.Windows.Forms.Button but_qrt;
        private System.Windows.Forms.Button but_sqrtY;
        private System.Windows.Forms.Button but_tan1;
        private System.Windows.Forms.Button but_tan;
        private System.Windows.Forms.Button but_sqrt3;
        private System.Windows.Forms.Button but_sqrt;
        private System.Windows.Forms.Button but_cos1;
        private System.Windows.Forms.Button but_cos;
        private System.Windows.Forms.Button but_qrt3;
        private System.Windows.Forms.Button but_qrt2;
        private System.Windows.Forms.Button but_sin1;
        private System.Windows.Forms.Button but_sin;
        private System.Windows.Forms.Button but_skob2;
        private System.Windows.Forms.Button but_skob1;
        private System.Windows.Forms.TextBox UNITBOX;
    }
}

