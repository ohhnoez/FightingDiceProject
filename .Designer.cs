
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(276, 603);
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
            this.d6.Location = new System.Drawing.Point(12, 84);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(60, 60);
            this.d6.TabIndex = 1;
            this.d6.Text = "d6";
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // d8
            // 
            this.d8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.d8.Location = new System.Drawing.Point(78, 84);
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
            this.d10.Location = new System.Drawing.Point(144, 84);
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
            this.d12.Location = new System.Drawing.Point(210, 86);
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
            this.d20.Location = new System.Drawing.Point(276, 86);
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
            this.d100.Location = new System.Drawing.Point(341, 86);
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
            this.txt_DiceCount.Location = new System.Drawing.Point(120, 20);
            this.txt_DiceCount.Name = "txt_DiceCount";
            this.txt_DiceCount.Size = new System.Drawing.Size(57, 20);
            this.txt_DiceCount.TabIndex = 25;
            // 
            // textBox_d6
            // 
            this.textBox_d6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d6.Location = new System.Drawing.Point(12, 188);
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
            this.textBox_d8.Location = new System.Drawing.Point(78, 188);
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
            this.textBox_d10.Location = new System.Drawing.Point(144, 188);
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
            this.textBox_d12.Location = new System.Drawing.Point(210, 188);
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
            this.textBox_d20.Location = new System.Drawing.Point(276, 188);
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
            this.textBox_d100.Location = new System.Drawing.Point(341, 188);
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
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose Dice Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Click dice to roll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
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
            this.label6.Location = new System.Drawing.Point(81, 172);
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
            this.label7.Location = new System.Drawing.Point(141, 172);
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
            this.label8.Location = new System.Drawing.Point(207, 172);
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
            this.label9.Location = new System.Drawing.Point(273, 172);
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
            this.label10.Location = new System.Drawing.Point(338, 172);
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
            this.label11.Location = new System.Drawing.Point(12, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Statistics";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Roll average";
            // 
            // textBox_d6Avg
            // 
            this.textBox_d6Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d6Avg.Location = new System.Drawing.Point(11, 479);
            this.textBox_d6Avg.Multiline = true;
            this.textBox_d6Avg.Name = "textBox_d6Avg";
            this.textBox_d6Avg.ReadOnly = true;
            this.textBox_d6Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d6Avg.TabIndex = 43;
            // 
            // textBox_d8Avg
            // 
            this.textBox_d8Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d8Avg.Location = new System.Drawing.Point(78, 479);
            this.textBox_d8Avg.Multiline = true;
            this.textBox_d8Avg.Name = "textBox_d8Avg";
            this.textBox_d8Avg.ReadOnly = true;
            this.textBox_d8Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d8Avg.TabIndex = 44;
            // 
            // textBox_d10Avg
            // 
            this.textBox_d10Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d10Avg.Location = new System.Drawing.Point(144, 479);
            this.textBox_d10Avg.Multiline = true;
            this.textBox_d10Avg.Name = "textBox_d10Avg";
            this.textBox_d10Avg.ReadOnly = true;
            this.textBox_d10Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d10Avg.TabIndex = 45;
            // 
            // textBox_d12Avg
            // 
            this.textBox_d12Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d12Avg.Location = new System.Drawing.Point(210, 479);
            this.textBox_d12Avg.Multiline = true;
            this.textBox_d12Avg.Name = "textBox_d12Avg";
            this.textBox_d12Avg.ReadOnly = true;
            this.textBox_d12Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d12Avg.TabIndex = 46;
            // 
            // textBox_d20Avg
            // 
            this.textBox_d20Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d20Avg.Location = new System.Drawing.Point(276, 479);
            this.textBox_d20Avg.Multiline = true;
            this.textBox_d20Avg.Name = "textBox_d20Avg";
            this.textBox_d20Avg.ReadOnly = true;
            this.textBox_d20Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d20Avg.TabIndex = 47;
            // 
            // textBox_d100Avg
            // 
            this.textBox_d100Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_d100Avg.Location = new System.Drawing.Point(341, 479);
            this.textBox_d100Avg.Multiline = true;
            this.textBox_d100Avg.Name = "textBox_d100Avg";
            this.textBox_d100Avg.ReadOnly = true;
            this.textBox_d100Avg.Size = new System.Drawing.Size(60, 40);
            this.textBox_d100Avg.TabIndex = 48;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 650);
            this.Controls.Add(this.textBox_d100Avg);
            this.Controls.Add(this.textBox_d20Avg);
            this.Controls.Add(this.textBox_d12Avg);
            this.Controls.Add(this.textBox_d10Avg);
            this.Controls.Add(this.textBox_d8Avg);
            this.Controls.Add(this.textBox_d6Avg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_d100);
            this.Controls.Add(this.textBox_d20);
            this.Controls.Add(this.textBox_d12);
            this.Controls.Add(this.textBox_d10);
            this.Controls.Add(this.textBox_d8);
            this.Controls.Add(this.textBox_d6);
            this.Controls.Add(this.txt_DiceCount);
            this.Controls.Add(this.d100);
            this.Controls.Add(this.d20);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.Exit);
            this.Name = "TestForm";
            this.Text = "Fighting Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button d6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button d8;
        private System.Windows.Forms.Button d10;
        private System.Windows.Forms.Button d12;
        private System.Windows.Forms.Button d20;
        private System.Windows.Forms.Button d100;
        private System.Windows.Forms.TextBox txt_DiceCount;
        private System.Windows.Forms.TextBox textBox_d6;
        private System.Windows.Forms.TextBox textBox_d8;
        private System.Windows.Forms.TextBox textBox_d10;
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
        private System.Windows.Forms.TextBox textBox_d100Avg;
    }
}

