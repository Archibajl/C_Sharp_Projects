namespace Enigma_Machine
{
    partial class Enigma_frm
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
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Reel4 = new System.Windows.Forms.TextBox();
            this.txt_Reel1 = new System.Windows.Forms.TextBox();
            this.txt_Reel3 = new System.Windows.Forms.TextBox();
            this.txt_Reel2 = new System.Windows.Forms.TextBox();
            this.btn_setReels = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(97, 25);
            this.txt_Input.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(359, 142);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.TextChanged += new System.EventHandler(this.txt_Input_TextChanged);
            // 
            // txt_output
            // 
            this.txt_output.Enabled = false;
            this.txt_output.Location = new System.Drawing.Point(97, 339);
            this.txt_output.Margin = new System.Windows.Forms.Padding(4);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(359, 211);
            this.txt_output.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(16, 25);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(35, 16);
            this.Input.TabIndex = 2;
            this.Input.Text = "Input";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(26, 342);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(45, 16);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rotor #          1              2              3              4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Starting Position (0,9)";
            // 
            // txt_Reel4
            // 
            this.txt_Reel4.Location = new System.Drawing.Point(252, 250);
            this.txt_Reel4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Reel4.MaxLength = 1;
            this.txt_Reel4.Name = "txt_Reel4";
            this.txt_Reel4.Size = new System.Drawing.Size(39, 22);
            this.txt_Reel4.TabIndex = 9;
            this.txt_Reel4.Text = "0";
            this.txt_Reel4.TextChanged += new System.EventHandler(this.txt_Reel4_TextChanged);
            // 
            // txt_Reel1
            // 
            this.txt_Reel1.Location = new System.Drawing.Point(104, 250);
            this.txt_Reel1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Reel1.MaxLength = 1;
            this.txt_Reel1.Name = "txt_Reel1";
            this.txt_Reel1.Size = new System.Drawing.Size(39, 22);
            this.txt_Reel1.TabIndex = 12;
            this.txt_Reel1.Text = "0";
            this.txt_Reel1.TextChanged += new System.EventHandler(this.txt_Reel1_TextChanged);
            // 
            // txt_Reel3
            // 
            this.txt_Reel3.Location = new System.Drawing.Point(198, 250);
            this.txt_Reel3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Reel3.MaxLength = 1;
            this.txt_Reel3.Name = "txt_Reel3";
            this.txt_Reel3.Size = new System.Drawing.Size(39, 22);
            this.txt_Reel3.TabIndex = 15;
            this.txt_Reel3.Text = "0";
            this.txt_Reel3.TextChanged += new System.EventHandler(this.txt_Reel3_TextChanged);
            // 
            // txt_Reel2
            // 
            this.txt_Reel2.Location = new System.Drawing.Point(151, 250);
            this.txt_Reel2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Reel2.MaxLength = 1;
            this.txt_Reel2.Name = "txt_Reel2";
            this.txt_Reel2.Size = new System.Drawing.Size(39, 22);
            this.txt_Reel2.TabIndex = 18;
            this.txt_Reel2.Text = "0";
            this.txt_Reel2.TextChanged += new System.EventHandler(this.txt_Reel2_TextChanged);
            // 
            // btn_setReels
            // 
            this.btn_setReels.AutoSize = true;
            this.btn_setReels.Location = new System.Drawing.Point(321, 250);
            this.btn_setReels.Name = "btn_setReels";
            this.btn_setReels.Size = new System.Drawing.Size(92, 28);
            this.btn_setReels.TabIndex = 19;
            this.btn_setReels.Text = "SetReels";
            this.btn_setReels.UseVisualStyleBackColor = true;
            this.btn_setReels.Click += new System.EventHandler(this.btn_setReels_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enigma_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(504, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_setReels);
            this.Controls.Add(this.txt_Reel2);
            this.Controls.Add(this.txt_Reel3);
            this.Controls.Add(this.txt_Reel1);
            this.Controls.Add(this.txt_Reel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_Input);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Enigma_frm";
            this.Text = "Enigma Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Reel4;
        private System.Windows.Forms.TextBox txt_Reel1;
        private System.Windows.Forms.TextBox txt_Reel3;
        private System.Windows.Forms.TextBox txt_Reel2;
        private System.Windows.Forms.Button btn_setReels;
        private System.Windows.Forms.Button button1;
    }
}

