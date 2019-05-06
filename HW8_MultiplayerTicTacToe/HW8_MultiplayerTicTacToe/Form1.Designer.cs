namespace HW8_MultiplayerTicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_IpConnection = new System.Windows.Forms.TextBox();
            this.btn_ResetGame = new System.Windows.Forms.Button();
            this.btn_TestConnection = new System.Windows.Forms.Button();
            this.lbl_Connection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(68, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(120, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 62);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(194, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 62);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(46, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 62);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(120, 175);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 62);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(194, 175);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 62);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(46, 243);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 62);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(120, 243);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(68, 62);
            this.textBox8.TabIndex = 8;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(194, 243);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(68, 62);
            this.textBox9.TabIndex = 9;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txt_IpConnection
            // 
            this.txt_IpConnection.Location = new System.Drawing.Point(33, 349);
            this.txt_IpConnection.Name = "txt_IpConnection";
            this.txt_IpConnection.Size = new System.Drawing.Size(100, 20);
            this.txt_IpConnection.TabIndex = 10;
            // 
            // btn_ResetGame
            // 
            this.btn_ResetGame.Location = new System.Drawing.Point(206, 390);
            this.btn_ResetGame.Name = "btn_ResetGame";
            this.btn_ResetGame.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetGame.TabIndex = 11;
            this.btn_ResetGame.Text = "Reset Game";
            this.btn_ResetGame.UseVisualStyleBackColor = true;
            this.btn_ResetGame.Click += new System.EventHandler(this.btn_ResetGame_Click);
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Location = new System.Drawing.Point(33, 431);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(100, 23);
            this.btn_TestConnection.TabIndex = 12;
            this.btn_TestConnection.Text = "Test Connection";
            this.btn_TestConnection.UseVisualStyleBackColor = true;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // lbl_Connection
            // 
            this.lbl_Connection.AutoSize = true;
            this.lbl_Connection.Location = new System.Drawing.Point(30, 387);
            this.lbl_Connection.Name = "lbl_Connection";
            this.lbl_Connection.Size = new System.Drawing.Size(121, 26);
            this.lbl_Connection.TabIndex = 13;
            this.lbl_Connection.Text = "Ip Adress to Connect to.\r\nDefaults to current IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 482);
            this.Controls.Add(this.lbl_Connection);
            this.Controls.Add(this.btn_TestConnection);
            this.Controls.Add(this.btn_ResetGame);
            this.Controls.Add(this.txt_IpConnection);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Multiplayer Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txt_IpConnection;
        private System.Windows.Forms.Button btn_ResetGame;
        private System.Windows.Forms.Button btn_TestConnection;
        private System.Windows.Forms.Label lbl_Connection;
    }
}

