namespace TA_1._1Q
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
            this.components = new System.ComponentModel.Container();
            this.buttonQuirk1 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxQuirk = new System.Windows.Forms.PictureBox();
            this.labelQuirkInfo = new System.Windows.Forms.Label();
            this.buttonQuirk2 = new System.Windows.Forms.Button();
            this.pictureBoxAlignment = new System.Windows.Forms.PictureBox();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.labelTimeDate = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuirk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlignment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuirk1
            // 
            this.buttonQuirk1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuirk1.Location = new System.Drawing.Point(21, 100);
            this.buttonQuirk1.Name = "buttonQuirk1";
            this.buttonQuirk1.Size = new System.Drawing.Size(87, 49);
            this.buttonQuirk1.TabIndex = 0;
            this.buttonQuirk1.Text = "Quirk 1";
            this.buttonQuirk1.UseVisualStyleBackColor = true;
            this.buttonQuirk1.Click += new System.EventHandler(this.buttonQuirk1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(352, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(305, 34);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Laithe\'s Quirky Program";
            // 
            // pictureBoxQuirk
            // 
            this.pictureBoxQuirk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQuirk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxQuirk.Location = new System.Drawing.Point(596, 451);
            this.pictureBoxQuirk.Name = "pictureBoxQuirk";
            this.pictureBoxQuirk.Size = new System.Drawing.Size(400, 267);
            this.pictureBoxQuirk.TabIndex = 2;
            this.pictureBoxQuirk.TabStop = false;
            // 
            // labelQuirkInfo
            // 
            this.labelQuirkInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelQuirkInfo.AutoSize = true;
            this.labelQuirkInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelQuirkInfo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuirkInfo.Location = new System.Drawing.Point(252, 451);
            this.labelQuirkInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelQuirkInfo.Name = "labelQuirkInfo";
            this.labelQuirkInfo.Size = new System.Drawing.Size(300, 75);
            this.labelQuirkInfo.TabIndex = 3;
            this.labelQuirkInfo.Text = "Quirk Text ......................................................................" +
    "....";
            // 
            // buttonQuirk2
            // 
            this.buttonQuirk2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuirk2.Location = new System.Drawing.Point(21, 201);
            this.buttonQuirk2.Name = "buttonQuirk2";
            this.buttonQuirk2.Size = new System.Drawing.Size(87, 49);
            this.buttonQuirk2.TabIndex = 4;
            this.buttonQuirk2.Text = "Quirk 2";
            this.buttonQuirk2.UseVisualStyleBackColor = true;
            this.buttonQuirk2.Click += new System.EventHandler(this.buttonQuirk2_Click);
            // 
            // pictureBoxAlignment
            // 
            this.pictureBoxAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAlignment.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAlignment.Name = "pictureBoxAlignment";
            this.pictureBoxAlignment.Size = new System.Drawing.Size(1008, 730);
            this.pictureBoxAlignment.TabIndex = 5;
            this.pictureBoxAlignment.TabStop = false;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimeDate
            // 
            this.labelTimeDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTimeDate.AutoSize = true;
            this.labelTimeDate.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeDate.Location = new System.Drawing.Point(352, 43);
            this.labelTimeDate.Name = "labelTimeDate";
            this.labelTimeDate.Size = new System.Drawing.Size(0, 34);
            this.labelTimeDate.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(21, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 49);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTimeDate);
            this.Controls.Add(this.buttonQuirk2);
            this.Controls.Add(this.labelQuirkInfo);
            this.Controls.Add(this.pictureBoxQuirk);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonQuirk1);
            this.Controls.Add(this.pictureBoxAlignment);
            this.Name = "Form1";
            this.Text = "Quirky Programming";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuirk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuirk1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxQuirk;
        private System.Windows.Forms.Label labelQuirkInfo;
        private System.Windows.Forms.Button buttonQuirk2;
        private System.Windows.Forms.PictureBox pictureBoxAlignment;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label labelTimeDate;
        private System.Windows.Forms.Button buttonExit;
    }
}

