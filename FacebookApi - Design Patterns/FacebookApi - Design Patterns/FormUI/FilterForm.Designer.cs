namespace FormsUI
{
    partial class FilterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortLabel = new System.Windows.Forms.Label();
            this.sortOptionComboBox = new System.Windows.Forms.ComboBox();
            this.likedListButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.matchPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.filteredListOfFreinds = new System.Windows.Forms.ListBox();
            this.filterSubmitButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.complicatedStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.relationshipStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.singleStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckBox = new System.Windows.Forms.CheckBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sortLabel);
            this.panel1.Controls.Add(this.sortOptionComboBox);
            this.panel1.Controls.Add(this.likedListButton);
            this.panel1.Controls.Add(this.likeButton);
            this.panel1.Controls.Add(this.matchPictureBox);
            this.panel1.Controls.Add(this.descriptionLabel2);
            this.panel1.Controls.Add(this.filteredListOfFreinds);
            this.panel1.Controls.Add(this.filterSubmitButton);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.complicatedStatusCheckBox);
            this.panel1.Controls.Add(this.relationshipStatusCheckBox);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Controls.Add(this.singleStatusCheckBox);
            this.panel1.Controls.Add(this.femaleCheckBox);
            this.panel1.Controls.Add(this.maleCheckBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 382);
            this.panel1.TabIndex = 0;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sortLabel.Location = new System.Drawing.Point(3, 171);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(167, 20);
            this.sortLabel.TabIndex = 52;
            this.sortLabel.Text = "Choose Sort Option";
            // 
            // sortOptionComboBox
            // 
            this.sortOptionComboBox.FormattingEnabled = true;
            this.sortOptionComboBox.Items.AddRange(new object[] {
            "Alphabetical",
            "Age",
            "Popularity"});
            this.sortOptionComboBox.Location = new System.Drawing.Point(176, 168);
            this.sortOptionComboBox.Name = "sortOptionComboBox";
            this.sortOptionComboBox.Size = new System.Drawing.Size(137, 28);
            this.sortOptionComboBox.TabIndex = 51;
            // 
            // likedListButton
            // 
            this.likedListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.likedListButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedListButton.Location = new System.Drawing.Point(69, 261);
            this.likedListButton.Name = "likedListButton";
            this.likedListButton.Size = new System.Drawing.Size(244, 45);
            this.likedListButton.TabIndex = 50;
            this.likedListButton.Text = "Show Me My Likes ➔";
            this.likedListButton.UseVisualStyleBackColor = false;
            this.likedListButton.Click += new System.EventHandler(this.likedListButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.likeButton.Location = new System.Drawing.Point(610, 300);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(126, 54);
            this.likeButton.TabIndex = 48;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // matchPictureBox
            // 
            this.matchPictureBox.Location = new System.Drawing.Point(610, 52);
            this.matchPictureBox.Name = "matchPictureBox";
            this.matchPictureBox.Size = new System.Drawing.Size(126, 114);
            this.matchPictureBox.TabIndex = 47;
            this.matchPictureBox.TabStop = false;
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel2.Location = new System.Drawing.Point(320, 24);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(104, 23);
            this.descriptionLabel2.TabIndex = 46;
            this.descriptionLabel2.Text = "Matches List";
            // 
            // filteredListOfFreinds
            // 
            this.filteredListOfFreinds.BackColor = System.Drawing.Color.SkyBlue;
            this.filteredListOfFreinds.FormattingEnabled = true;
            this.filteredListOfFreinds.ItemHeight = 20;
            this.filteredListOfFreinds.Location = new System.Drawing.Point(319, 50);
            this.filteredListOfFreinds.Name = "filteredListOfFreinds";
            this.filteredListOfFreinds.Size = new System.Drawing.Size(282, 304);
            this.filteredListOfFreinds.TabIndex = 45;
            this.filteredListOfFreinds.SelectedIndexChanged += new System.EventHandler(this.filteredListOfFreinds_SelectedIndexChanged);
            // 
            // filterSubmitButton
            // 
            this.filterSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.filterSubmitButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSubmitButton.Location = new System.Drawing.Point(69, 312);
            this.filterSubmitButton.Name = "filterSubmitButton";
            this.filterSubmitButton.Size = new System.Drawing.Size(244, 42);
            this.filterSubmitButton.TabIndex = 44;
            this.filterSubmitButton.Text = "FIND ME MY MATCHS ➔";
            this.filterSubmitButton.UseVisualStyleBackColor = false;
            this.filterSubmitButton.Click += new System.EventHandler(this.filterSubmitButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(14, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(156, 23);
            this.statusLabel.TabIndex = 43;
            this.statusLabel.Text = "Relationship status";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderLabel.Location = new System.Drawing.Point(189, 17);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 23);
            this.genderLabel.TabIndex = 42;
            this.genderLabel.Text = "Gender";
            // 
            // complicatedStatusCheckBox
            // 
            this.complicatedStatusCheckBox.AutoSize = true;
            this.complicatedStatusCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complicatedStatusCheckBox.Location = new System.Drawing.Point(18, 111);
            this.complicatedStatusCheckBox.Name = "complicatedStatusCheckBox";
            this.complicatedStatusCheckBox.Size = new System.Drawing.Size(152, 27);
            this.complicatedStatusCheckBox.TabIndex = 41;
            this.complicatedStatusCheckBox.Text = "Its Complicated";
            this.complicatedStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // relationshipStatusCheckBox
            // 
            this.relationshipStatusCheckBox.AutoSize = true;
            this.relationshipStatusCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipStatusCheckBox.Location = new System.Drawing.Point(18, 81);
            this.relationshipStatusCheckBox.Name = "relationshipStatusCheckBox";
            this.relationshipStatusCheckBox.Size = new System.Drawing.Size(147, 27);
            this.relationshipStatusCheckBox.TabIndex = 40;
            this.relationshipStatusCheckBox.Text = "In Relationship";
            this.relationshipStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(178, 17);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 20);
            this.ageLabel.TabIndex = 39;
            // 
            // singleStatusCheckBox
            // 
            this.singleStatusCheckBox.AutoSize = true;
            this.singleStatusCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleStatusCheckBox.Location = new System.Drawing.Point(18, 50);
            this.singleStatusCheckBox.Name = "singleStatusCheckBox";
            this.singleStatusCheckBox.Size = new System.Drawing.Size(81, 27);
            this.singleStatusCheckBox.TabIndex = 38;
            this.singleStatusCheckBox.Text = "Single";
            this.singleStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleCheckBox.Location = new System.Drawing.Point(193, 81);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(86, 27);
            this.femaleCheckBox.TabIndex = 37;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleCheckBox.Location = new System.Drawing.Point(193, 50);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(72, 27);
            this.maleCheckBox.TabIndex = 36;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(785, 408);
            this.Controls.Add(this.panel1);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filterSubmitButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.CheckBox complicatedStatusCheckBox;
        private System.Windows.Forms.CheckBox relationshipStatusCheckBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.CheckBox singleStatusCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckBox;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.ListBox filteredListOfFreinds;
        private System.Windows.Forms.PictureBox matchPictureBox;
        private System.Windows.Forms.Button likedListButton;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.ComboBox sortOptionComboBox;
        private System.Windows.Forms.Label sortLabel;
    }
}