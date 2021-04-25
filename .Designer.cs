
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
            this.GBAttack.SuspendLayout();
            this.GBDefend.SuspendLayout();
            this.GBResults.SuspendLayout();
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
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 663);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDefLeft;
    }
}

