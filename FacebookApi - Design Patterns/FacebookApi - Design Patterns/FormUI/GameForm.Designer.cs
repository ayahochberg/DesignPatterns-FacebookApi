namespace FormsUI
{
    partial class GameForm
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
            this.pickRandomFriendButton = new System.Windows.Forms.Button();
            this.friendPhoto = new System.Windows.Forms.PictureBox();
            this.nameOptionsList = new System.Windows.Forms.ListBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.submitChosenNameButton = new System.Windows.Forms.Button();
            this.description1Label = new System.Windows.Forms.Label();
            this.description2Label = new System.Windows.Forms.Label();
            this.description3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_raffleButton
            // 
            this.pickRandomFriendButton.BackColor = System.Drawing.Color.Turquoise;
            this.pickRandomFriendButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickRandomFriendButton.Location = new System.Drawing.Point(21, 30);
            this.pickRandomFriendButton.Name = "m_raffleButton";
            this.pickRandomFriendButton.Size = new System.Drawing.Size(233, 40);
            this.pickRandomFriendButton.TabIndex = 1;
            this.pickRandomFriendButton.Text = "pick random friend!";
            this.pickRandomFriendButton.UseVisualStyleBackColor = false;
            this.pickRandomFriendButton.Click += new System.EventHandler(this.pickRandomFriendButton_OnClick);
            // 
            // m_FriendPhoto
            // 
            this.friendPhoto.Location = new System.Drawing.Point(330, 64);
            this.friendPhoto.Name = "m_FriendPhoto";
            this.friendPhoto.Size = new System.Drawing.Size(225, 204);
            this.friendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendPhoto.TabIndex = 2;
            this.friendPhoto.TabStop = false;
            // 
            // m_NameOptionsList
            // 
            this.nameOptionsList.FormattingEnabled = true;
            this.nameOptionsList.ItemHeight = 20;
            this.nameOptionsList.Location = new System.Drawing.Point(330, 314);
            this.nameOptionsList.Name = "m_NameOptionsList";
            this.nameOptionsList.Size = new System.Drawing.Size(225, 124);
            this.nameOptionsList.TabIndex = 3;
            // 
            // m_ChooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(15, 288);
            this.chooseLabel.Name = "m_ChooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(457, 23);
            this.chooseLabel.TabIndex = 4;
            this.chooseLabel.Text = "Choose match name to the photo above amd click submit:";
            // 
            // m_SubmitChosenNameButton
            // 
            this.submitChosenNameButton.BackColor = System.Drawing.Color.SeaGreen;
            this.submitChosenNameButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitChosenNameButton.Location = new System.Drawing.Point(585, 398);
            this.submitChosenNameButton.Name = "m_SubmitChosenNameButton";
            this.submitChosenNameButton.Size = new System.Drawing.Size(96, 40);
            this.submitChosenNameButton.TabIndex = 5;
            this.submitChosenNameButton.Text = "submit";
            this.submitChosenNameButton.UseVisualStyleBackColor = false;
            this.submitChosenNameButton.Click += new System.EventHandler(this.submitChosenNameButton_OnClick);
            // 
            // m_Description1Label
            // 
            this.description1Label.AutoSize = true;
            this.description1Label.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description1Label.ForeColor = System.Drawing.Color.White;
            this.description1Label.Location = new System.Drawing.Point(17, 111);
            this.description1Label.Name = "m_Description1Label";
            this.description1Label.Size = new System.Drawing.Size(267, 23);
            this.description1Label.TabIndex = 6;
            this.description1Label.Text = "Lets check how well you know your ";
            // 
            // m_Description2Label
            // 
            this.description2Label.AutoSize = true;
            this.description2Label.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description2Label.ForeColor = System.Drawing.Color.White;
            this.description2Label.Location = new System.Drawing.Point(15, 132);
            this.description2Label.Name = "m_Description2Label";
            this.description2Label.Size = new System.Drawing.Size(294, 23);
            this.description2Label.TabIndex = 7;
            this.description2Label.Text = "firends here on facebook - if you dont,";
            // 
            // m_Description3Label
            // 
            this.description3Label.AutoSize = true;
            this.description3Label.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description3Label.ForeColor = System.Drawing.Color.White;
            this.description3Label.Location = new System.Drawing.Point(16, 152);
            this.description3Label.Name = "m_Description3Label";
            this.description3Label.Size = new System.Drawing.Size(269, 23);
            this.description3Label.TabIndex = 8;
            this.description3Label.Text = "maybe its time to let go from some..";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description3Label);
            this.Controls.Add(this.description2Label);
            this.Controls.Add(this.description1Label);
            this.Controls.Add(this.submitChosenNameButton);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.nameOptionsList);
            this.Controls.Add(this.friendPhoto);
            this.Controls.Add(this.pickRandomFriendButton);
            this.Name = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.friendPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pickRandomFriendButton;
        private System.Windows.Forms.PictureBox friendPhoto;
        private System.Windows.Forms.ListBox nameOptionsList;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button submitChosenNameButton;
        private System.Windows.Forms.Label description1Label;
        private System.Windows.Forms.Label description2Label;
        private System.Windows.Forms.Label description3Label;
    }
}