namespace ChatTCP_IP
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.Startbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.ServerPorttextBox = new System.Windows.Forms.TextBox();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.White;
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Startbutton.Location = new System.Drawing.Point(14, 354);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Connectbutton
            // 
            this.Connectbutton.BackColor = System.Drawing.Color.White;
            this.Connectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connectbutton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Connectbutton.Location = new System.Drawing.Point(95, 354);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(75, 23);
            this.Connectbutton.TabIndex = 1;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = false;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.Color.MidnightBlue;
            this.Sendbutton.BackgroundImage = global::ChatTCP_IP.Properties.Resources.zfOVUL_send_email_button_cut_out;
            this.Sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbutton.ForeColor = System.Drawing.Color.White;
            this.Sendbutton.Image = global::ChatTCP_IP.Properties.Resources.zfOVUL_send_email_button_cut_out;
            this.Sendbutton.Location = new System.Drawing.Point(690, 333);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 23);
            this.Sendbutton.TabIndex = 2;
            this.Sendbutton.Text = "ENVIAR";
            this.Sendbutton.UseVisualStyleBackColor = false;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "PORT";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(55, 74);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerIPtextBox.TabIndex = 9;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(55, 236);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientIPtextBox.TabIndex = 10;
            // 
            // ServerPorttextBox
            // 
            this.ServerPorttextBox.Location = new System.Drawing.Point(55, 128);
            this.ServerPorttextBox.Name = "ServerPorttextBox";
            this.ServerPorttextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerPorttextBox.TabIndex = 11;
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Location = new System.Drawing.Point(55, 287);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientPorttextBox.TabIndex = 12;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(228, 336);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(457, 20);
            this.MessagetextBox.TabIndex = 13;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.ForeColor = System.Drawing.Color.Black;
            this.ChatScreentextBox.Location = new System.Drawing.Point(228, 29);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.Size = new System.Drawing.Size(538, 290);
            this.ChatScreentextBox.TabIndex = 14;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ChatTCP_IP.Properties.Resources.Design_sem_nome__3_;
            this.pictureBox2.Location = new System.Drawing.Point(183, -14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(626, 460);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ClientPorttextBox);
            this.Controls.Add(this.ServerPorttextBox);
            this.Controls.Add(this.ClientIPtextBox);
            this.Controls.Add(this.ServerIPtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox ServerPorttextBox;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

