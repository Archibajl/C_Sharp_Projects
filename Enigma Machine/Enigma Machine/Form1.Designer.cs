namespace Enigma_Machine
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_StartPos1 = new System.Windows.Forms.TextBox();
            this.txt_StartPos2 = new System.Windows.Forms.TextBox();
            this.txt_StartPos3 = new System.Windows.Forms.TextBox();
            this.chk_LtRotor1 = new System.Windows.Forms.CheckBox();
            this.chk_LtRotor2 = new System.Windows.Forms.CheckBox();
            this.chk_LtRotor3 = new System.Windows.Forms.CheckBox();
            this.chk_LtRotor4 = new System.Windows.Forms.CheckBox();
            this.chk_MidRotor1 = new System.Windows.Forms.CheckBox();
            this.chk_MidRotor2 = new System.Windows.Forms.CheckBox();
            this.chk_MidRotor3 = new System.Windows.Forms.CheckBox();
            this.chk_MidRotor4 = new System.Windows.Forms.CheckBox();
            this.chk_RtRotor1 = new System.Windows.Forms.CheckBox();
            this.chk_RtRotor2 = new System.Windows.Forms.CheckBox();
            this.chk_RtRotor3 = new System.Windows.Forms.CheckBox();
            this.chk_RtRotor4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(73, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(13, 18);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(31, 13);
            this.Input.TabIndex = 2;
            this.Input.Text = "Input";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(12, 45);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rotor #     1    2    3    4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Right -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Starting Position (0,9)";
            // 
            // txt_StartPos1
            // 
            this.txt_StartPos1.Location = new System.Drawing.Point(183, 97);
            this.txt_StartPos1.Name = "txt_StartPos1";
            this.txt_StartPos1.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos1.TabIndex = 9;
            this.txt_StartPos1.Text = "0";
            // 
            // txt_StartPos2
            // 
            this.txt_StartPos2.Location = new System.Drawing.Point(183, 128);
            this.txt_StartPos2.Name = "txt_StartPos2";
            this.txt_StartPos2.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos2.TabIndex = 10;
            this.txt_StartPos2.Text = "0";
            // 
            // txt_StartPos3
            // 
            this.txt_StartPos3.Location = new System.Drawing.Point(183, 156);
            this.txt_StartPos3.Name = "txt_StartPos3";
            this.txt_StartPos3.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos3.TabIndex = 11;
            this.txt_StartPos3.Text = "0";
            // 
            // chk_LtRotor1
            // 
            this.chk_LtRotor1.AutoSize = true;
            this.chk_LtRotor1.Location = new System.Drawing.Point(81, 104);
            this.chk_LtRotor1.Name = "chk_LtRotor1";
            this.chk_LtRotor1.Size = new System.Drawing.Size(15, 14);
            this.chk_LtRotor1.TabIndex = 12;
            this.chk_LtRotor1.UseVisualStyleBackColor = true;
            this.chk_LtRotor1.CheckedChanged += new System.EventHandler(this.chk_LtRotor1_CheckedChanged);
            // 
            // chk_LtRotor2
            // 
            this.chk_LtRotor2.AutoSize = true;
            this.chk_LtRotor2.Location = new System.Drawing.Point(102, 104);
            this.chk_LtRotor2.Name = "chk_LtRotor2";
            this.chk_LtRotor2.Size = new System.Drawing.Size(15, 14);
            this.chk_LtRotor2.TabIndex = 13;
            this.chk_LtRotor2.UseVisualStyleBackColor = true;
            this.chk_LtRotor2.CheckedChanged += new System.EventHandler(this.chk_LtRotor2_CheckedChanged);
            // 
            // chk_LtRotor3
            // 
            this.chk_LtRotor3.AutoSize = true;
            this.chk_LtRotor3.Location = new System.Drawing.Point(123, 104);
            this.chk_LtRotor3.Name = "chk_LtRotor3";
            this.chk_LtRotor3.Size = new System.Drawing.Size(15, 14);
            this.chk_LtRotor3.TabIndex = 14;
            this.chk_LtRotor3.UseVisualStyleBackColor = true;
            this.chk_LtRotor3.CheckedChanged += new System.EventHandler(this.chk_LtRotor3_CheckedChanged);
            // 
            // chk_LtRotor4
            // 
            this.chk_LtRotor4.AutoSize = true;
            this.chk_LtRotor4.Location = new System.Drawing.Point(144, 104);
            this.chk_LtRotor4.Name = "chk_LtRotor4";
            this.chk_LtRotor4.Size = new System.Drawing.Size(15, 14);
            this.chk_LtRotor4.TabIndex = 15;
            this.chk_LtRotor4.UseVisualStyleBackColor = true;
            this.chk_LtRotor4.CheckedChanged += new System.EventHandler(this.chk_LtRotor4_CheckedChanged);
            // 
            // chk_MidRotor1
            // 
            this.chk_MidRotor1.AutoSize = true;
            this.chk_MidRotor1.Location = new System.Drawing.Point(81, 130);
            this.chk_MidRotor1.Name = "chk_MidRotor1";
            this.chk_MidRotor1.Size = new System.Drawing.Size(15, 14);
            this.chk_MidRotor1.TabIndex = 16;
            this.chk_MidRotor1.UseVisualStyleBackColor = true;
            this.chk_MidRotor1.CheckedChanged += new System.EventHandler(this.chk_MidRotor1_CheckedChanged);
            // 
            // chk_MidRotor2
            // 
            this.chk_MidRotor2.AutoSize = true;
            this.chk_MidRotor2.Location = new System.Drawing.Point(102, 131);
            this.chk_MidRotor2.Name = "chk_MidRotor2";
            this.chk_MidRotor2.Size = new System.Drawing.Size(15, 14);
            this.chk_MidRotor2.TabIndex = 17;
            this.chk_MidRotor2.UseVisualStyleBackColor = true;
            this.chk_MidRotor2.CheckedChanged += new System.EventHandler(this.chk_MidRotor2_CheckedChanged);
            // 
            // chk_MidRotor3
            // 
            this.chk_MidRotor3.AutoSize = true;
            this.chk_MidRotor3.Location = new System.Drawing.Point(123, 131);
            this.chk_MidRotor3.Name = "chk_MidRotor3";
            this.chk_MidRotor3.Size = new System.Drawing.Size(15, 14);
            this.chk_MidRotor3.TabIndex = 18;
            this.chk_MidRotor3.UseVisualStyleBackColor = true;
            this.chk_MidRotor3.CheckedChanged += new System.EventHandler(this.chk_MidRotor3_CheckedChanged);
            // 
            // chk_MidRotor4
            // 
            this.chk_MidRotor4.AutoSize = true;
            this.chk_MidRotor4.Location = new System.Drawing.Point(144, 131);
            this.chk_MidRotor4.Name = "chk_MidRotor4";
            this.chk_MidRotor4.Size = new System.Drawing.Size(15, 14);
            this.chk_MidRotor4.TabIndex = 19;
            this.chk_MidRotor4.UseVisualStyleBackColor = true;
            this.chk_MidRotor4.CheckedChanged += new System.EventHandler(this.chk_MidRotor4_CheckedChanged);
            // 
            // chk_RtRotor1
            // 
            this.chk_RtRotor1.AutoSize = true;
            this.chk_RtRotor1.Location = new System.Drawing.Point(81, 160);
            this.chk_RtRotor1.Name = "chk_RtRotor1";
            this.chk_RtRotor1.Size = new System.Drawing.Size(15, 14);
            this.chk_RtRotor1.TabIndex = 20;
            this.chk_RtRotor1.UseVisualStyleBackColor = true;
            this.chk_RtRotor1.CheckedChanged += new System.EventHandler(this.chk_RtRotor1_CheckedChanged);
            // 
            // chk_RtRotor2
            // 
            this.chk_RtRotor2.AutoSize = true;
            this.chk_RtRotor2.Location = new System.Drawing.Point(102, 160);
            this.chk_RtRotor2.Name = "chk_RtRotor2";
            this.chk_RtRotor2.Size = new System.Drawing.Size(15, 14);
            this.chk_RtRotor2.TabIndex = 21;
            this.chk_RtRotor2.UseVisualStyleBackColor = true;
            this.chk_RtRotor2.CheckedChanged += new System.EventHandler(this.chk_RtRotor2_CheckedChanged);
            // 
            // chk_RtRotor3
            // 
            this.chk_RtRotor3.AutoSize = true;
            this.chk_RtRotor3.Location = new System.Drawing.Point(123, 160);
            this.chk_RtRotor3.Name = "chk_RtRotor3";
            this.chk_RtRotor3.Size = new System.Drawing.Size(15, 14);
            this.chk_RtRotor3.TabIndex = 22;
            this.chk_RtRotor3.UseVisualStyleBackColor = true;
            this.chk_RtRotor3.CheckedChanged += new System.EventHandler(this.chk_RtRotor3_CheckedChanged);
            // 
            // chk_RtRotor4
            // 
            this.chk_RtRotor4.AutoSize = true;
            this.chk_RtRotor4.Location = new System.Drawing.Point(144, 160);
            this.chk_RtRotor4.Name = "chk_RtRotor4";
            this.chk_RtRotor4.Size = new System.Drawing.Size(15, 14);
            this.chk_RtRotor4.TabIndex = 23;
            this.chk_RtRotor4.UseVisualStyleBackColor = true;
            this.chk_RtRotor4.CheckedChanged += new System.EventHandler(this.chk_RtRotor4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 374);
            this.Controls.Add(this.chk_RtRotor4);
            this.Controls.Add(this.chk_RtRotor3);
            this.Controls.Add(this.chk_RtRotor2);
            this.Controls.Add(this.chk_RtRotor1);
            this.Controls.Add(this.chk_MidRotor4);
            this.Controls.Add(this.chk_MidRotor3);
            this.Controls.Add(this.chk_MidRotor2);
            this.Controls.Add(this.chk_MidRotor1);
            this.Controls.Add(this.chk_LtRotor4);
            this.Controls.Add(this.chk_LtRotor3);
            this.Controls.Add(this.chk_LtRotor2);
            this.Controls.Add(this.chk_LtRotor1);
            this.Controls.Add(this.txt_StartPos3);
            this.Controls.Add(this.txt_StartPos2);
            this.Controls.Add(this.txt_StartPos1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_StartPos1;
        private System.Windows.Forms.TextBox txt_StartPos2;
        private System.Windows.Forms.TextBox txt_StartPos3;
        private System.Windows.Forms.CheckBox chk_LtRotor1;
        private System.Windows.Forms.CheckBox chk_LtRotor2;
        private System.Windows.Forms.CheckBox chk_LtRotor3;
        private System.Windows.Forms.CheckBox chk_LtRotor4;
        private System.Windows.Forms.CheckBox chk_MidRotor1;
        private System.Windows.Forms.CheckBox chk_MidRotor2;
        private System.Windows.Forms.CheckBox chk_MidRotor3;
        private System.Windows.Forms.CheckBox chk_MidRotor4;
        private System.Windows.Forms.CheckBox chk_RtRotor1;
        private System.Windows.Forms.CheckBox chk_RtRotor2;
        private System.Windows.Forms.CheckBox chk_RtRotor3;
        private System.Windows.Forms.CheckBox chk_RtRotor4;
    }
}

