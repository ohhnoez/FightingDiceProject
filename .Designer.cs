
using System;

namespace FightingDice
{
    partial class TestForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.d6 = new System.Windows.Forms.Button();
            this.d8 = new System.Windows.Forms.Button();
            this.d10 = new System.Windows.Forms.Button();
            this.d12 = new System.Windows.Forms.Button();
            this.d20 = new System.Windows.Forms.Button();
            this.d100 = new System.Windows.Forms.Button();
            this.txt_DiceCount = new System.Windows.Forms.TextBox();
            this.textBox_d6 = new System.Windows.Forms.TextBox();
            this.textBox_d8 = new System.Windows.Forms.TextBox();
            this.textBox_d10 = new System.Windows.Forms.TextBox();
            this.textBox_d12 = new System.Windows.Forms.TextBox();
            this.textBox_d20 = new System.Windows.Forms.TextBox();
            this.textBox_d100 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_d6Avg = new System.Windows.Forms.TextBox();
            this.textBox_d8Avg = new System.Windows.Forms.TextBox();
            this.textBox_d10Avg = new System.Windows.Forms.TextBox();
            this.textBox_d12Avg = new System.Windows.Forms.TextBox();
            this.textBox_d20Avg = new System.Windows.Forms.TextBox();
            this.textBox_d100Avg = new System.Windows.Forms.TextBox();
            this.testCombat = new System.Windows.Forms.Button();
            this.TextBoxAttackerWSBS = new System.Windows.Forms.TextBox();
            this.TextBoxAttackerStr = new System.Windows.Forms.TextBox();
            this.TextBoxAttackerAPM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GBAttack = new System.Windows.Forms.GroupBox();
            this.TextBoxAttackerCount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TextBoxAttackerToughness = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBoxAttackerAS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.GBDefend = new System.Windows.Forms.GroupBox();
            this.TextBoxDefenderCount = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TextBoxDefenderToughness = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBoxDefenderAS = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TextBoxDefenderWSBS = new System.Windows.Forms.TextBox();
            this.TextBoxDefenderAPM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TextBoxDefenderStr = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.GBResults = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDefLeft = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TextBoxCritWound = new System.Windows.Forms.TextBox();
            this.TextBoxWounds = new System.Windows.Forms.TextBox();
            this.TextBoxHits = new System.Windows.Forms.TextBox();
            this.ButtonAttackSH = new System.Windows.Forms.Button();
            this.ButtonDefendSH = new System.Windows.Forms.Button();
            this.ButtonResultsSH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBAttack.SuspendLayout();
            this.GBDefend.SuspendLayout();
            this.GBResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 616);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 35);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // d6
            // 
            this.d6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d6.Location = new System.Drawing.Point(20, 85);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(60, 60);
            this.d6.TabIndex = 1;
            this.d6.Text = "d6";
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click_1);
            // 
            // d8
            // 
            this.d8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d8.Location = new System.Drawing.Point(86, 85);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(60, 60);
            this.d8.TabIndex = 3;
            this.d8.Text = "d8";
            this.d8.UseVisualStyleBackColor = true;
            this.d8.Click += new System.EventHandler(this.d8_Click);
            // 
            // d10
            // 
            this.d10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d10.Location = new System.Drawing.Point(152, 85);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(60, 60);
            this.d10.TabIndex = 5;
            this.d10.Text = "d10";
            this.d10.UseVisualStyleBackColor = true;
            this.d10.Click += new System.EventHandler(this.d10_Click_1);
            // 
            // d12
            // 
            this.d12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d12.Location = new System.Drawing.Point(218, 87);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(60, 60);
            this.d12.TabIndex = 7;
            this.d12.Text = "d12";
            this.d12.UseVisualStyleBackColor = true;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d20
            // 
            this.d20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d20.Location = new System.Drawing.Point(284, 87);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(60, 60);
            this.d20.TabIndex = 9;
            this.d20.Text = "d20";
            this.d20.UseVisualStyleBackColor = true;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // d100
            // 
            this.d100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d100.Location = new System.Drawing.Point(349, 87);
            this.d100.Name = "d100";
            this.d100.Size = new System.Drawing.Size(60, 60);
            this.d100.TabIndex = 11;
            this.d100.Text = "d100";
            this.d100.UseVisualStyleBackColor = true;
            this.d100.Click += new System.EventHandler(this.d100_Click);
            // 
            // txt_DiceCount
            // 
            this.txt_DiceCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txt_DiceCount.Location = new System.Drawing.Point(128, 21);
            this.txt_DiceCount.Name = "txt_DiceCount";
            this.txt_DiceCount.Size = new System.Drawing.Size(57, 20);
            this.txt_DiceCount.TabIndex = 25;
            // 
            // textBox_d6
            // 
            this.textBox_d6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d6.Location = new System.Drawing.Point(20, 189);
            this.textBox_d6.Multiline = true;
            this.textBox_d6.Name = "textBox_d6";
            this.textBox_d6.ReadOnly = true;
            this.textBox_d6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d6.Size = new System.Drawing.Size(60, 250);
            this.textBox_d6.TabIndex = 26;
            // 
            // textBox_d8
            // 
            this.textBox_d8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_d8.Location = new System.Drawing.Point(86, 189);
            this.textBox_d8.Multiline = true;
            this.textBox_d8.Name = "textBox_d8";
            this.textBox_d8.ReadOnly = true;
            this.textBox_d8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d8.Size = new System.Drawing.Size(60, 250);
            this.textBox_d8.TabIndex = 27;
            // 
            // textBox_d10
            // 
            this.textBox_d10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_d10.Location = new System.Drawing.Point(152, 189);
            this.textBox_d10.Multiline = true;
            this.textBox_d10.Name = "textBox_d10";
            this.textBox_d10.ReadOnly = true;
            this.textBox_d10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d10.Size = new System.Drawing.Size(60, 250);
            this.textBox_d10.TabIndex = 28;
            // 
            // textBox_d12
            // 
            this.textBox_d12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_d12.Location = new System.Drawing.Point(218, 189);
            this.textBox_d12.Multiline = true;
            this.textBox_d12.Name = "textBox_d12";
            this.textBox_d12.ReadOnly = true;
            this.textBox_d12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d12.Size = new System.Drawing.Size(60, 250);
            this.textBox_d12.TabIndex = 29;
            // 
            // textBox_d20
            // 
            this.textBox_d20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_d20.Location = new System.Drawing.Point(284, 189);
            this.textBox_d20.Multiline = true;
            this.textBox_d20.Name = "textBox_d20";
            this.textBox_d20.ReadOnly = true;
            this.textBox_d20.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d20.Size = new System.Drawing.Size(60, 250);
            this.textBox_d20.TabIndex = 30;
            // 
            // textBox_d100
            // 
            this.textBox_d100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_d100.Location = new System.Drawing.Point(349, 189);
            this.textBox_d100.Multiline = true;
            this.textBox_d100.Name = "textBox_d100";
            this.textBox_d100.ReadOnly = true;
            this.textBox_d100.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d100.Size = new System.Drawing.Size(60, 250);
            this.textBox_d100.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose Dice Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Click dice to roll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 173);
            this.label5.MaximumSize = new System.Drawing.Size(60, 0);
            this.label5.MinimumSize = new System.Drawing.Size(60, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "d6";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 173);
            this.label6.MaximumSize = new System.Drawing.Size(60, 0);
            this.label6.MinimumSize = new System.Drawing.Size(60, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "d8";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 173);
            this.label7.MaximumSize = new System.Drawing.Size(60, 0);
            this.label7.MinimumSize = new System.Drawing.Size(60, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "d10";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 173);
            this.label8.MaximumSize = new System.Drawing.Size(60, 0);
            this.label8.MinimumSize = new System.Drawing.Size(60, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "d12";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 173);
            this.label9.MaximumSize = new System.Drawing.Size(60, 0);
            this.label9.MinimumSize = new System.Drawing.Size(60, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "d20";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 173);
            this.label10.MaximumSize = new System.Drawing.Size(60, 0);
            this.label10.MinimumSize = new System.Drawing.Size(60, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "d100";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Statistics";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Roll average";
            // 
            // textBox_d6Avg
            // 
            this.textBox_d6Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d6Avg.Location = new System.Drawing.Point(19, 480);
            this.textBox_d6Avg.Multiline = true;
            this.textBox_d6Avg.Name = "textBox_d6Avg";
            this.textBox_d6Avg.ReadOnly = true;
            this.textBox_d6Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d6Avg.TabIndex = 43;
            // 
            // textBox_d8Avg
            // 
            this.textBox_d8Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d8Avg.Location = new System.Drawing.Point(86, 480);
            this.textBox_d8Avg.Multiline = true;
            this.textBox_d8Avg.Name = "textBox_d8Avg";
            this.textBox_d8Avg.ReadOnly = true;
            this.textBox_d8Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d8Avg.TabIndex = 44;
            // 
            // textBox_d10Avg
            // 
            this.textBox_d10Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d10Avg.Location = new System.Drawing.Point(152, 480);
            this.textBox_d10Avg.Multiline = true;
            this.textBox_d10Avg.Name = "textBox_d10Avg";
            this.textBox_d10Avg.ReadOnly = true;
            this.textBox_d10Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d10Avg.TabIndex = 45;
            // 
            // textBox_d12Avg
            // 
            this.textBox_d12Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d12Avg.Location = new System.Drawing.Point(218, 480);
            this.textBox_d12Avg.Multiline = true;
            this.textBox_d12Avg.Name = "textBox_d12Avg";
            this.textBox_d12Avg.ReadOnly = true;
            this.textBox_d12Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d12Avg.TabIndex = 46;
            // 
            // textBox_d20Avg
            // 
            this.textBox_d20Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d20Avg.Location = new System.Drawing.Point(284, 480);
            this.textBox_d20Avg.Multiline = true;
            this.textBox_d20Avg.Name = "textBox_d20Avg";
            this.textBox_d20Avg.ReadOnly = true;
            this.textBox_d20Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d20Avg.TabIndex = 47;
            // 
            // textBox_d100Avg
            // 
            this.textBox_d100Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d100Avg.Location = new System.Drawing.Point(349, 480);
            this.textBox_d100Avg.Multiline = true;
            this.textBox_d100Avg.Name = "textBox_d100Avg";
            this.textBox_d100Avg.ReadOnly = true;
            this.textBox_d100Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d100Avg.TabIndex = 48;
            // 
            // testCombat
            // 
            this.testCombat.Location = new System.Drawing.Point(450, 541);
            this.testCombat.Name = "testCombat";
            this.testCombat.Size = new System.Drawing.Size(192, 20);
            this.testCombat.TabIndex = 49;
            this.testCombat.Text = "Test Combat";
            this.testCombat.UseVisualStyleBackColor = true;
            this.testCombat.Click += new System.EventHandler(this.testCombat_Click);
            // 
            // TextBoxAttackerWSBS
            // 
            this.TextBoxAttackerWSBS.Location = new System.Drawing.Point(114, 19);
            this.TextBoxAttackerWSBS.Name = "TextBoxAttackerWSBS";
            this.TextBoxAttackerWSBS.Size = new System.Drawing.Size(87, 20);
            this.TextBoxAttackerWSBS.TabIndex = 50;
            // 
            // TextBoxAttackerStr
            // 
            this.TextBoxAttackerStr.Location = new System.Drawing.Point(114, 44);
            this.TextBoxAttackerStr.Name = "TextBoxAttackerStr";
            this.TextBoxAttackerStr.Size = new System.Drawing.Size(87, 20);
            this.TextBoxAttackerStr.TabIndex = 51;
            // 
            // TextBoxAttackerAPM
            // 
            this.TextBoxAttackerAPM.Location = new System.Drawing.Point(114, 70);
            this.TextBoxAttackerAPM.Name = "TextBoxAttackerAPM";
            this.TextBoxAttackerAPM.Size = new System.Drawing.Size(87, 20);
            this.TextBoxAttackerAPM.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "WS/BS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Strength";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Attacks per model";
            // 
            // GBAttack
            // 
            this.GBAttack.Controls.Add(this.TextBoxAttackerCount);
            this.GBAttack.Controls.Add(this.label26);
            this.GBAttack.Controls.Add(this.TextBoxAttackerToughness);
            this.GBAttack.Controls.Add(this.label22);
            this.GBAttack.Controls.Add(this.TextBoxAttackerAS);
            this.GBAttack.Controls.Add(this.label20);
            this.GBAttack.Controls.Add(this.TextBoxAttackerWSBS);
            this.GBAttack.Controls.Add(this.label13);
            this.GBAttack.Controls.Add(this.label14);
            this.GBAttack.Controls.Add(this.label15);
            this.GBAttack.Controls.Add(this.TextBoxAttackerStr);
            this.GBAttack.Controls.Add(this.TextBoxAttackerAPM);
            this.GBAttack.Location = new System.Drawing.Point(441, 14);
            this.GBAttack.Name = "GBAttack";
            this.GBAttack.Size = new System.Drawing.Size(373, 184);
            this.GBAttack.TabIndex = 57;
            this.GBAttack.TabStop = false;
            this.GBAttack.Text = "Attacker";
            // 
            // TextBoxAttackerCount
            // 
            this.TextBoxAttackerCount.Location = new System.Drawing.Point(298, 19);
            this.TextBoxAttackerCount.Name = "TextBoxAttackerCount";
            this.TextBoxAttackerCount.Size = new System.Drawing.Size(52, 20);
            this.TextBoxAttackerCount.TabIndex = 68;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(218, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 69;
            this.label26.Text = "Model Count";
            // 
            // TextBoxAttackerToughness
            // 
            this.TextBoxAttackerToughness.Location = new System.Drawing.Point(114, 122);
            this.TextBoxAttackerToughness.Name = "TextBoxAttackerToughness";
            this.TextBoxAttackerToughness.Size = new System.Drawing.Size(87, 20);
            this.TextBoxAttackerToughness.TabIndex = 66;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 67;
            this.label22.Text = "Toughness";
            // 
            // TextBoxAttackerAS
            // 
            this.TextBoxAttackerAS.Location = new System.Drawing.Point(114, 96);
            this.TextBoxAttackerAS.Name = "TextBoxAttackerAS";
            this.TextBoxAttackerAS.Size = new System.Drawing.Size(87, 20);
            this.TextBoxAttackerAS.TabIndex = 64;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "Armor Save";
            // 
            // GBDefend
            // 
            this.GBDefend.Controls.Add(this.TextBoxDefenderCount);
            this.GBDefend.Controls.Add(this.label27);
            this.GBDefend.Controls.Add(this.TextBoxDefenderToughness);
            this.GBDefend.Controls.Add(this.label21);
            this.GBDefend.Controls.Add(this.TextBoxDefenderAS);
            this.GBDefend.Controls.Add(this.label19);
            this.GBDefend.Controls.Add(this.TextBoxDefenderWSBS);
            this.GBDefend.Controls.Add(this.TextBoxDefenderAPM);
            this.GBDefend.Controls.Add(this.label16);
            this.GBDefend.Controls.Add(this.TextBoxDefenderStr);
            this.GBDefend.Controls.Add(this.label17);
            this.GBDefend.Controls.Add(this.label18);
            this.GBDefend.Location = new System.Drawing.Point(441, 204);
            this.GBDefend.Name = "GBDefend";
            this.GBDefend.Size = new System.Drawing.Size(373, 184);
            this.GBDefend.TabIndex = 58;
            this.GBDefend.TabStop = false;
            this.GBDefend.Text = "Defender";
            // 
            // TextBoxDefenderCount
            // 
            this.TextBoxDefenderCount.Location = new System.Drawing.Point(298, 22);
            this.TextBoxDefenderCount.Name = "TextBoxDefenderCount";
            this.TextBoxDefenderCount.Size = new System.Drawing.Size(52, 20);
            this.TextBoxDefenderCount.TabIndex = 70;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(218, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 71;
            this.label27.Text = "Model Count";
            // 
            // TextBoxDefenderToughness
            // 
            this.TextBoxDefenderToughness.Location = new System.Drawing.Point(114, 125);
            this.TextBoxDefenderToughness.Name = "TextBoxDefenderToughness";
            this.TextBoxDefenderToughness.Size = new System.Drawing.Size(87, 20);
            this.TextBoxDefenderToughness.TabIndex = 64;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Toughness";
            // 
            // TextBoxDefenderAS
            // 
            this.TextBoxDefenderAS.Location = new System.Drawing.Point(114, 99);
            this.TextBoxDefenderAS.Name = "TextBoxDefenderAS";
            this.TextBoxDefenderAS.Size = new System.Drawing.Size(87, 20);
            this.TextBoxDefenderAS.TabIndex = 62;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 63;
            this.label19.Text = "Armor Save";
            // 
            // TextBoxDefenderWSBS
            // 
            this.TextBoxDefenderWSBS.Location = new System.Drawing.Point(114, 22);
            this.TextBoxDefenderWSBS.Name = "TextBoxDefenderWSBS";
            this.TextBoxDefenderWSBS.Size = new System.Drawing.Size(87, 20);
            this.TextBoxDefenderWSBS.TabIndex = 56;
            // 
            // TextBoxDefenderAPM
            // 
            this.TextBoxDefenderAPM.Location = new System.Drawing.Point(114, 73);
            this.TextBoxDefenderAPM.Name = "TextBoxDefenderAPM";
            this.TextBoxDefenderAPM.Size = new System.Drawing.Size(87, 20);
            this.TextBoxDefenderAPM.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "WS/BS";
            // 
            // TextBoxDefenderStr
            // 
            this.TextBoxDefenderStr.Location = new System.Drawing.Point(114, 47);
            this.TextBoxDefenderStr.Name = "TextBoxDefenderStr";
            this.TextBoxDefenderStr.Size = new System.Drawing.Size(87, 20);
            this.TextBoxDefenderStr.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Strength";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Attacks per model";
            // 
            // GBResults
            // 
            this.GBResults.Controls.Add(this.label1);
            this.GBResults.Controls.Add(this.TextBoxDefLeft);
            this.GBResults.Controls.Add(this.label25);
            this.GBResults.Controls.Add(this.label24);
            this.GBResults.Controls.Add(this.label23);
            this.GBResults.Controls.Add(this.TextBoxCritWound);
            this.GBResults.Controls.Add(this.TextBoxWounds);
            this.GBResults.Controls.Add(this.TextBoxHits);
            this.GBResults.Location = new System.Drawing.Point(441, 394);
            this.GBResults.Name = "GBResults";
            this.GBResults.Size = new System.Drawing.Size(373, 138);
            this.GBResults.TabIndex = 59;
            this.GBResults.TabStop = false;
            this.GBResults.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Enemies Left";
            // 
            // TextBoxDefLeft
            // 
            this.TextBoxDefLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDefLeft.Location = new System.Drawing.Point(247, 41);
            this.TextBoxDefLeft.Multiline = true;
            this.TextBoxDefLeft.Name = "TextBoxDefLeft";
            this.TextBoxDefLeft.ReadOnly = true;
            this.TextBoxDefLeft.Size = new System.Drawing.Size(71, 27);
            this.TextBoxDefLeft.TabIndex = 69;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(167, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 68;
            this.label25.Text = "CritWound";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(90, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 67;
            this.label24.Text = "Wounds";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 66;
            this.label23.Text = "Hits";
            // 
            // TextBoxCritWound
            // 
            this.TextBoxCritWound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCritWound.Location = new System.Drawing.Point(170, 41);
            this.TextBoxCritWound.Multiline = true;
            this.TextBoxCritWound.Name = "TextBoxCritWound";
            this.TextBoxCritWound.ReadOnly = true;
            this.TextBoxCritWound.Size = new System.Drawing.Size(71, 27);
            this.TextBoxCritWound.TabIndex = 62;
            // 
            // TextBoxWounds
            // 
            this.TextBoxWounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWounds.Location = new System.Drawing.Point(93, 41);
            this.TextBoxWounds.Multiline = true;
            this.TextBoxWounds.Name = "TextBoxWounds";
            this.TextBoxWounds.ReadOnly = true;
            this.TextBoxWounds.Size = new System.Drawing.Size(71, 27);
            this.TextBoxWounds.TabIndex = 61;
            // 
            // TextBoxHits
            // 
            this.TextBoxHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHits.Location = new System.Drawing.Point(16, 41);
            this.TextBoxHits.Multiline = true;
            this.TextBoxHits.Name = "TextBoxHits";
            this.TextBoxHits.ReadOnly = true;
            this.TextBoxHits.Size = new System.Drawing.Size(71, 27);
            this.TextBoxHits.TabIndex = 60;
            // 
            // ButtonAttackSH
            // 
            this.ButtonAttackSH.Location = new System.Drawing.Point(820, 16);
            this.ButtonAttackSH.Name = "ButtonAttackSH";
            this.ButtonAttackSH.Size = new System.Drawing.Size(72, 37);
            this.ButtonAttackSH.TabIndex = 60;
            this.ButtonAttackSH.Text = "Attack Show/Hide";
            this.ButtonAttackSH.UseVisualStyleBackColor = true;
            this.ButtonAttackSH.Click += new System.EventHandler(this.ButtonAttackSH_Click);
            // 
            // ButtonDefendSH
            // 
            this.ButtonDefendSH.Location = new System.Drawing.Point(820, 209);
            this.ButtonDefendSH.Name = "ButtonDefendSH";
            this.ButtonDefendSH.Size = new System.Drawing.Size(72, 37);
            this.ButtonDefendSH.TabIndex = 61;
            this.ButtonDefendSH.Text = "Defender Show/Hide";
            this.ButtonDefendSH.UseVisualStyleBackColor = true;
            this.ButtonDefendSH.Click += new System.EventHandler(this.ButtonDefendSH_Click);
            // 
            // ButtonResultsSH
            // 
            this.ButtonResultsSH.Location = new System.Drawing.Point(820, 400);
            this.ButtonResultsSH.Name = "ButtonResultsSH";
            this.ButtonResultsSH.Size = new System.Drawing.Size(72, 37);
            this.ButtonResultsSH.TabIndex = 62;
            this.ButtonResultsSH.Text = "Results Show/Hide";
            this.ButtonResultsSH.UseVisualStyleBackColor = true;
            this.ButtonResultsSH.Click += new System.EventHandler(this.ButtonResultsSH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_d100);
            this.groupBox1.Controls.Add(this.d6);
            this.groupBox1.Controls.Add(this.d8);
            this.groupBox1.Controls.Add(this.d10);
            this.groupBox1.Controls.Add(this.d12);
            this.groupBox1.Controls.Add(this.d20);
            this.groupBox1.Controls.Add(this.d100);
            this.groupBox1.Controls.Add(this.txt_DiceCount);
            this.groupBox1.Controls.Add(this.textBox_d100Avg);
            this.groupBox1.Controls.Add(this.textBox_d6);
            this.groupBox1.Controls.Add(this.textBox_d20Avg);
            this.groupBox1.Controls.Add(this.textBox_d8);
            this.groupBox1.Controls.Add(this.textBox_d12Avg);
            this.groupBox1.Controls.Add(this.textBox_d10);
            this.groupBox1.Controls.Add(this.textBox_d10Avg);
            this.groupBox1.Controls.Add(this.textBox_d12);
            this.groupBox1.Controls.Add(this.textBox_d8Avg);
            this.groupBox1.Controls.Add(this.textBox_d20);
            this.groupBox1.Controls.Add(this.textBox_d6Avg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 549);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice Roll Simulator";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonResultsSH);
            this.Controls.Add(this.ButtonDefendSH);
            this.Controls.Add(this.ButtonAttackSH);
            this.Controls.Add(this.GBResults);
            this.Controls.Add(this.GBDefend);
            this.Controls.Add(this.GBAttack);
            this.Controls.Add(this.testCombat);
            this.Controls.Add(this.Exit);
            this.Name = "TestForm";
            this.Text = "Fighting Dice";
            this.GBAttack.ResumeLayout(false);
            this.GBAttack.PerformLayout();
            this.GBDefend.ResumeLayout(false);
            this.GBDefend.PerformLayout();
            this.GBResults.ResumeLayout(false);
            this.GBResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button d6;
        private System.Windows.Forms.Button d8;
        private System.Windows.Forms.Button d10;
        private System.Windows.Forms.Button d12;
        private System.Windows.Forms.Button d20;
        private System.Windows.Forms.Button d100;
        private System.Windows.Forms.TextBox txt_DiceCount;
        private System.Windows.Forms.TextBox textBox_d6;
        private System.Windows.Forms.TextBox textBox_d8;
        private System.Windows.Forms.TextBox textBox_d10;
        private System.Windows.Forms.TextBox TextBoxAttackerCount;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TextBoxAttackerToughness;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextBoxDefenderCount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TextBoxDefenderToughness;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox GBResults;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TextBoxCritWound;
        private System.Windows.Forms.TextBox TextBoxWounds;
        private System.Windows.Forms.TextBox TextBoxHits;
        private System.Windows.Forms.Button ButtonAttackSH;
        private System.Windows.Forms.Button ButtonDefendSH;
        private System.Windows.Forms.Button ButtonResultsSH;
        private System.Windows.Forms.TextBox textBox_d12;
        private System.Windows.Forms.TextBox textBox_d20;
        private System.Windows.Forms.TextBox textBox_d100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_d6Avg;
        private System.Windows.Forms.TextBox textBox_d8Avg;
        private System.Windows.Forms.TextBox textBox_d10Avg;
        private System.Windows.Forms.TextBox textBox_d12Avg;
        private System.Windows.Forms.TextBox textBox_d20Avg;
        private System.Windows.Forms.Button testCombat;
        private System.Windows.Forms.TextBox TextBoxAttackerWSBS;
        private System.Windows.Forms.TextBox TextBoxAttackerStr;
        private System.Windows.Forms.TextBox TextBoxAttackerAPM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox GBAttack;
        private System.Windows.Forms.TextBox TextBoxAttackerAS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox GBDefend;
        private System.Windows.Forms.TextBox TextBoxDefenderAS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TextBoxDefenderWSBS;
        private System.Windows.Forms.TextBox TextBoxDefenderAPM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TextBoxDefenderStr;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDefLeft;
        private System.Windows.Forms.TextBox textBox_d100Avg;

        
    }
}

