namespace FormsUI
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.descriptionLabal1 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PictureBoxSymbol
            // 
            this.pictureBoxSymbol.BackColor = System.Drawing.Color.White;
            this.pictureBoxSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSymbol.Image = ((System.Drawing.Image)(resources.GetObject("m_PictureBoxSymbol.Image")));
            this.pictureBoxSymbol.Location = new System.Drawing.Point(22, 21);
            this.pictureBoxSymbol.Name = "m_PictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(180, 172);
            this.pictureBoxSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSymbol.TabIndex = 24;
            this.pictureBoxSymbol.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.White;
            this.logInButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(396, 103);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(237, 51);
            this.logInButton.TabIndex = 25;
            this.logInButton.Text = "Login to facebook 2.0";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_OnClick);
            // 
            // label1
            // 
            this.descriptionLabal1.AutoSize = true;
            this.descriptionLabal1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabal1.ForeColor = System.Drawing.Color.White;
            this.descriptionLabal1.Location = new System.Drawing.Point(208, 21);
            this.descriptionLabal1.Name = "label1";
            this.descriptionLabal1.Size = new System.Drawing.Size(619, 25);
            this.descriptionLabal1.TabIndex = 26;
            this.descriptionLabal1.Text = "Welcome to facebook version 2.0 - please click the button bellow in ";
            // 
            // label2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel2.Location = new System.Drawing.Point(208, 46);
            this.descriptionLabel2.Name = "label2";
            this.descriptionLabel2.Size = new System.Drawing.Size(648, 25);
            this.descriptionLabel2.TabIndex = 27;
            this.descriptionLabel2.Text = "order to login to you facenook account and start having fun with our app";
            // 
            // m_RememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(396, 160);
            this.rememberMeCheckBox.Name = "m_RememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(139, 27);
            this.rememberMeCheckBox.TabIndex = 28;
            this.rememberMeCheckBox.Text = "Remember Me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(882, 229);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.descriptionLabal1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Name = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSymbol;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label descriptionLabal1;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
    }
}