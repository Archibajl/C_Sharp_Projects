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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtn_Lt4 = new System.Windows.Forms.RadioButton();
            this.radbtn_Lt2 = new System.Windows.Forms.RadioButton();
            this.radbtn_Lt3 = new System.Windows.Forms.RadioButton();
            this.radbtn_Lt1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radbtn_Mid4 = new System.Windows.Forms.RadioButton();
            this.radbtn_Mid1 = new System.Windows.Forms.RadioButton();
            this.radbtn_Mid3 = new System.Windows.Forms.RadioButton();
            this.radbtn_Mid2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radbtn_Rt4 = new System.Windows.Forms.RadioButton();
            this.radbtn_Rt1 = new System.Windows.Forms.RadioButton();
            this.radbtn_Rt3 = new System.Windows.Forms.RadioButton();
            this.radbtn_Rt2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
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
            this.txt_StartPos1.MaxLength = 1;
            this.txt_StartPos1.Name = "txt_StartPos1";
            this.txt_StartPos1.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos1.TabIndex = 9;
            this.txt_StartPos1.Text = "0";
            this.txt_StartPos1.TextChanged += new System.EventHandler(this.txt_StartPos1_TextChanged);
            // 
            // txt_StartPos2
            // 
            this.txt_StartPos2.Location = new System.Drawing.Point(183, 128);
            this.txt_StartPos2.MaxLength = 1;
            this.txt_StartPos2.Name = "txt_StartPos2";
            this.txt_StartPos2.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos2.TabIndex = 10;
            this.txt_StartPos2.Text = "0";
            this.txt_StartPos2.TextChanged += new System.EventHandler(this.txt_StartPos2_TextChanged);
            // 
            // txt_StartPos3
            // 
            this.txt_StartPos3.Location = new System.Drawing.Point(183, 156);
            this.txt_StartPos3.MaxLength = 1;
            this.txt_StartPos3.Name = "txt_StartPos3";
            this.txt_StartPos3.Size = new System.Drawing.Size(104, 20);
            this.txt_StartPos3.TabIndex = 11;
            this.txt_StartPos3.Text = "0";
            this.txt_StartPos3.TextChanged += new System.EventHandler(this.txt_StartPos3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtn_Lt4);
            this.groupBox1.Controls.Add(this.radbtn_Lt2);
            this.groupBox1.Controls.Add(this.radbtn_Lt3);
            this.groupBox1.Controls.Add(this.radbtn_Lt1);
            this.groupBox1.Location = new System.Drawing.Point(72, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 25);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // radbtn_Lt4
            // 
            this.radbtn_Lt4.AutoSize = true;
            this.radbtn_Lt4.Location = new System.Drawing.Point(70, 7);
            this.radbtn_Lt4.Name = "radbtn_Lt4";
            this.radbtn_Lt4.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Lt4.TabIndex = 29;
            this.radbtn_Lt4.TabStop = true;
            this.radbtn_Lt4.UseVisualStyleBackColor = true;
            this.radbtn_Lt4.CheckedChanged += new System.EventHandler(this.radbtn_Lt4_CheckedChanged);
            // 
            // radbtn_Lt2
            // 
            this.radbtn_Lt2.AutoSize = true;
            this.radbtn_Lt2.Location = new System.Drawing.Point(30, 7);
            this.radbtn_Lt2.Name = "radbtn_Lt2";
            this.radbtn_Lt2.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Lt2.TabIndex = 27;
            this.radbtn_Lt2.TabStop = true;
            this.radbtn_Lt2.UseVisualStyleBackColor = true;
            this.radbtn_Lt2.CheckedChanged += new System.EventHandler(this.radbtn_Lt2_CheckedChanged);
            // 
            // radbtn_Lt3
            // 
            this.radbtn_Lt3.AutoSize = true;
            this.radbtn_Lt3.Location = new System.Drawing.Point(50, 7);
            this.radbtn_Lt3.Name = "radbtn_Lt3";
            this.radbtn_Lt3.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Lt3.TabIndex = 28;
            this.radbtn_Lt3.TabStop = true;
            this.radbtn_Lt3.UseVisualStyleBackColor = true;
            this.radbtn_Lt3.CheckedChanged += new System.EventHandler(this.radbtn_Lt3_CheckedChanged);
            // 
            // radbtn_Lt1
            // 
            this.radbtn_Lt1.AutoSize = true;
            this.radbtn_Lt1.Location = new System.Drawing.Point(10, 7);
            this.radbtn_Lt1.Name = "radbtn_Lt1";
            this.radbtn_Lt1.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Lt1.TabIndex = 26;
            this.radbtn_Lt1.UseVisualStyleBackColor = true;
            this.radbtn_Lt1.CheckedChanged += new System.EventHandler(this.radbtn_Lt1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radbtn_Mid4);
            this.groupBox2.Controls.Add(this.radbtn_Mid1);
            this.groupBox2.Controls.Add(this.radbtn_Mid3);
            this.groupBox2.Controls.Add(this.radbtn_Mid2);
            this.groupBox2.Location = new System.Drawing.Point(73, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 25);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // radbtn_Mid4
            // 
            this.radbtn_Mid4.AutoSize = true;
            this.radbtn_Mid4.Location = new System.Drawing.Point(69, 8);
            this.radbtn_Mid4.Name = "radbtn_Mid4";
            this.radbtn_Mid4.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Mid4.TabIndex = 30;
            this.radbtn_Mid4.TabStop = true;
            this.radbtn_Mid4.UseVisualStyleBackColor = true;
            this.radbtn_Mid4.CheckedChanged += new System.EventHandler(this.radbtn_Mid4_CheckedChanged);
            // 
            // radbtn_Mid1
            // 
            this.radbtn_Mid1.AutoSize = true;
            this.radbtn_Mid1.Location = new System.Drawing.Point(9, 8);
            this.radbtn_Mid1.Name = "radbtn_Mid1";
            this.radbtn_Mid1.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Mid1.TabIndex = 27;
            this.radbtn_Mid1.TabStop = true;
            this.radbtn_Mid1.UseVisualStyleBackColor = true;
            this.radbtn_Mid1.CheckedChanged += new System.EventHandler(this.radbtn_Mid1_CheckedChanged);
            // 
            // radbtn_Mid3
            // 
            this.radbtn_Mid3.AutoSize = true;
            this.radbtn_Mid3.Location = new System.Drawing.Point(49, 8);
            this.radbtn_Mid3.Name = "radbtn_Mid3";
            this.radbtn_Mid3.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Mid3.TabIndex = 29;
            this.radbtn_Mid3.TabStop = true;
            this.radbtn_Mid3.UseVisualStyleBackColor = true;
            this.radbtn_Mid3.CheckedChanged += new System.EventHandler(this.radbtn_Mid3_CheckedChanged);
            // 
            // radbtn_Mid2
            // 
            this.radbtn_Mid2.AutoSize = true;
            this.radbtn_Mid2.Location = new System.Drawing.Point(29, 8);
            this.radbtn_Mid2.Name = "radbtn_Mid2";
            this.radbtn_Mid2.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Mid2.TabIndex = 28;
            this.radbtn_Mid2.UseVisualStyleBackColor = true;
            this.radbtn_Mid2.CheckedChanged += new System.EventHandler(this.radbtn_Mid2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radbtn_Rt4);
            this.groupBox3.Controls.Add(this.radbtn_Rt1);
            this.groupBox3.Controls.Add(this.radbtn_Rt3);
            this.groupBox3.Controls.Add(this.radbtn_Rt2);
            this.groupBox3.Location = new System.Drawing.Point(73, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 25);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // radbtn_Rt4
            // 
            this.radbtn_Rt4.AutoSize = true;
            this.radbtn_Rt4.Location = new System.Drawing.Point(69, 6);
            this.radbtn_Rt4.Name = "radbtn_Rt4";
            this.radbtn_Rt4.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Rt4.TabIndex = 33;
            this.radbtn_Rt4.TabStop = true;
            this.radbtn_Rt4.UseVisualStyleBackColor = true;
            this.radbtn_Rt4.CheckedChanged += new System.EventHandler(this.radbtn_Rt4_CheckedChanged);
            // 
            // radbtn_Rt1
            // 
            this.radbtn_Rt1.AutoSize = true;
            this.radbtn_Rt1.Location = new System.Drawing.Point(9, 6);
            this.radbtn_Rt1.Name = "radbtn_Rt1";
            this.radbtn_Rt1.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Rt1.TabIndex = 30;
            this.radbtn_Rt1.TabStop = true;
            this.radbtn_Rt1.UseVisualStyleBackColor = true;
            this.radbtn_Rt1.CheckedChanged += new System.EventHandler(this.radbtn_Rt1_CheckedChanged);
            // 
            // radbtn_Rt3
            // 
            this.radbtn_Rt3.AutoSize = true;
            this.radbtn_Rt3.Location = new System.Drawing.Point(49, 6);
            this.radbtn_Rt3.Name = "radbtn_Rt3";
            this.radbtn_Rt3.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Rt3.TabIndex = 32;
            this.radbtn_Rt3.UseVisualStyleBackColor = true;
            this.radbtn_Rt3.CheckedChanged += new System.EventHandler(this.radbtn_Rt3_CheckedChanged);
            // 
            // radbtn_Rt2
            // 
            this.radbtn_Rt2.AutoSize = true;
            this.radbtn_Rt2.Location = new System.Drawing.Point(29, 6);
            this.radbtn_Rt2.Name = "radbtn_Rt2";
            this.radbtn_Rt2.Size = new System.Drawing.Size(14, 13);
            this.radbtn_Rt2.TabIndex = 31;
            this.radbtn_Rt2.TabStop = true;
            this.radbtn_Rt2.UseVisualStyleBackColor = true;
            this.radbtn_Rt2.CheckedChanged += new System.EventHandler(this.radbtn_Rt2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtn_Lt4;
        private System.Windows.Forms.RadioButton radbtn_Lt2;
        private System.Windows.Forms.RadioButton radbtn_Lt3;
        private System.Windows.Forms.RadioButton radbtn_Lt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbtn_Mid4;
        private System.Windows.Forms.RadioButton radbtn_Mid1;
        private System.Windows.Forms.RadioButton radbtn_Mid3;
        private System.Windows.Forms.RadioButton radbtn_Mid2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbtn_Rt4;
        private System.Windows.Forms.RadioButton radbtn_Rt1;
        private System.Windows.Forms.RadioButton radbtn_Rt3;
        private System.Windows.Forms.RadioButton radbtn_Rt2;
    }
}

