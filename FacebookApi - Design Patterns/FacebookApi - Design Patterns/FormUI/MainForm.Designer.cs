using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    partial class MainForm
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label religionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.textForPost = new System.Windows.Forms.TextBox();
            this.postSubmitButton = new System.Windows.Forms.Button();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.linkFavoritePicture = new System.Windows.Forms.LinkLabel();
            this.postStatus = new System.Windows.Forms.Label();
            this.linkEvents = new System.Windows.Forms.LinkLabel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.gamePhoto = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languagesListBox = new System.Windows.Forms.ListBox();
            this.likedPagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userListBox = new System.Windows.Forms.ListBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postListBox = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterFriendButton = new System.Windows.Forms.Button();
            this.fetchAllDataButton = new System.Windows.Forms.Button();
            this.mainDataPanel = new System.Windows.Forms.Panel();
            this.FeatureComboBox = new FormsUI.FacebookAppLogic.FeatureMenu();
            this.FeaturesMenu = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePhoto)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(170, 41);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 41;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(170, 68);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 43;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(170, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 47;
            nameLabel.Text = "Name:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(171, 125);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(70, 20);
            religionLabel.TabIndex = 49;
            religionLabel.Text = "Religion:";
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(682, 35);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(129, 134);
            this.pictureBoxFriends.TabIndex = 4;
            this.pictureBoxFriends.TabStop = false;
            // 
            // textForPost
            // 
            this.textForPost.Location = new System.Drawing.Point(575, 57);
            this.textForPost.Name = "textForPost";
            this.textForPost.Size = new System.Drawing.Size(311, 26);
            this.textForPost.TabIndex = 5;
            // 
            // postSubmitButton
            // 
            this.postSubmitButton.BackColor = System.Drawing.Color.DimGray;
            this.postSubmitButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postSubmitButton.Location = new System.Drawing.Point(892, 47);
            this.postSubmitButton.Name = "postSubmitButton";
            this.postSubmitButton.Size = new System.Drawing.Size(99, 36);
            this.postSubmitButton.TabIndex = 6;
            this.postSubmitButton.Text = "post";
            this.postSubmitButton.UseVisualStyleBackColor = false;
            this.postSubmitButton.Click += new System.EventHandler(this.postSubmitButton_OnClick);
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFriends.LinkColor = System.Drawing.Color.White;
            this.linkFriends.Location = new System.Drawing.Point(438, 9);
            this.linkFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(132, 23);
            this.linkFriends.TabIndex = 10;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends ➔";
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fetchFriends_LinkClicked);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPosts.LinkColor = System.Drawing.Color.White;
            this.linkPosts.Location = new System.Drawing.Point(5, 9);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(114, 23);
            this.linkPosts.TabIndex = 12;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts ➔";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fetchPosts_LinkClicked);
            // 
            // linkFavoritePicture
            // 
            this.linkFavoritePicture.AutoSize = true;
            this.linkFavoritePicture.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFavoritePicture.LinkColor = System.Drawing.Color.White;
            this.linkFavoritePicture.Location = new System.Drawing.Point(681, 514);
            this.linkFavoritePicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkFavoritePicture.Name = "linkFavoritePicture";
            this.linkFavoritePicture.Size = new System.Drawing.Size(199, 23);
            this.linkFavoritePicture.TabIndex = 16;
            this.linkFavoritePicture.TabStop = true;
            this.linkFavoritePicture.Text = "My Most Liked Picture ➔";
            this.linkFavoritePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fetchFavoritePicture_LinkClicked);
            // 
            // postStatus
            // 
            this.postStatus.AutoSize = true;
            this.postStatus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postStatus.Location = new System.Drawing.Point(565, 27);
            this.postStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postStatus.Name = "postStatus";
            this.postStatus.Size = new System.Drawing.Size(109, 23);
            this.postStatus.TabIndex = 17;
            this.postStatus.Text = "Post Status:";
            // 
            // linkEvents
            // 
            this.linkEvents.AutoSize = true;
            this.linkEvents.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEvents.LinkColor = System.Drawing.Color.White;
            this.linkEvents.Location = new System.Drawing.Point(445, 253);
            this.linkEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEvents.Name = "linkEvents";
            this.linkEvents.Size = new System.Drawing.Size(125, 23);
            this.linkEvents.TabIndex = 19;
            this.linkEvents.TabStop = true;
            this.linkEvents.Text = "Fetch Events ➔";
            this.linkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEvents_LinkClicked);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(682, 278);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(129, 111);
            this.pictureBoxEvent.TabIndex = 22;
            this.pictureBoxEvent.TabStop = false;
            // 
            // pictureBoxSymbol
            // 
            this.pictureBoxSymbol.BackColor = System.Drawing.Color.White;
            this.pictureBoxSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSymbol.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSymbol.Image")));
            this.pictureBoxSymbol.Location = new System.Drawing.Point(24, 27);
            this.pictureBoxSymbol.Name = "pictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(90, 86);
            this.pictureBoxSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSymbol.TabIndex = 23;
            this.pictureBoxSymbol.TabStop = false;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Gold;
            this.startGameButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(9, 514);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(651, 53);
            this.startGameButton.TabIndex = 36;
            this.startGameButton.Text = "Click here and start playing";
            this.startGameButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_OnClick);
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPages.LinkColor = System.Drawing.Color.White;
            this.linkPages.Location = new System.Drawing.Point(5, 253);
            this.linkPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(161, 23);
            this.linkPages.TabIndex = 39;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages ➔";
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_OnClick);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Location = new System.Drawing.Point(3, 159);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(145, 39);
            this.logOutButton.TabIndex = 40;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_OnClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(170, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(130, 23);
            this.descriptionLabel.TabIndex = 41;
            this.descriptionLabel.Text = "My Information";
            // 
            // gamePhoto
            // 
            this.gamePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePhoto.Image = ((System.Drawing.Image)(resources.GetObject("gamePhoto.Image")));
            this.gamePhoto.Location = new System.Drawing.Point(9, 514);
            this.gamePhoto.Name = "gamePhoto";
            this.gamePhoto.Size = new System.Drawing.Size(651, 271);
            this.gamePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePhoto.TabIndex = 44;
            this.gamePhoto.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(birthdayLabel);
            this.infoPanel.Controls.Add(this.birthdayLabel1);
            this.infoPanel.Controls.Add(emailLabel);
            this.infoPanel.Controls.Add(this.emailLabel1);
            this.infoPanel.Controls.Add(this.imageNormalPictureBox);
            this.infoPanel.Controls.Add(nameLabel);
            this.infoPanel.Controls.Add(this.nameLabel1);
            this.infoPanel.Controls.Add(religionLabel);
            this.infoPanel.Controls.Add(this.religionLabel1);
            this.infoPanel.Controls.Add(this.descriptionLabel);
            this.infoPanel.Controls.Add(this.logOutButton);
            this.infoPanel.Location = new System.Drawing.Point(120, 27);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(422, 207);
            this.infoPanel.TabIndex = 45;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(247, 41);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(202, 23);
            this.birthdayLabel1.TabIndex = 42;
            this.birthdayLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(247, 66);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(214, 28);
            this.emailLabel1.TabIndex = 44;
            this.emailLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(145, 150);
            this.imageNormalPictureBox.TabIndex = 46;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(247, 94);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(214, 23);
            this.nameLabel1.TabIndex = 48;
            this.nameLabel1.Text = "label1";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Location = new System.Drawing.Point(247, 125);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(225, 25);
            this.religionLabel1.TabIndex = 50;
            this.religionLabel1.Text = "label1";
            // 
            // eventListBox
            // 
            this.eventListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.eventListBox.DataSource = this.eventBindingSource;
            this.eventListBox.DisplayMember = "Name";
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 20;
            this.eventListBox.Location = new System.Drawing.Point(449, 278);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(226, 204);
            this.eventListBox.TabIndex = 44;
            this.eventListBox.ValueMember = "AttendingUsers";
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // languagesListBox
            // 
            this.languagesListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.languagesListBox.DataSource = this.likedPagesBindingSource;
            this.languagesListBox.DisplayMember = "Name";
            this.languagesListBox.FormattingEnabled = true;
            this.languagesListBox.ItemHeight = 20;
            this.languagesListBox.Location = new System.Drawing.Point(9, 279);
            this.languagesListBox.Name = "languagesListBox";
            this.languagesListBox.Size = new System.Drawing.Size(413, 204);
            this.languagesListBox.TabIndex = 44;
            this.languagesListBox.ValueMember = "AccessToken";
            // 
            // likedPagesBindingSource
            // 
            this.likedPagesBindingSource.DataMember = "LikedPages";
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(685, 549);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(198, 224);
            this.imageNormalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox1.TabIndex = 13;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.userListBox.DataSource = this.friendsBindingSource;
            this.userListBox.DisplayMember = "Name";
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(442, 35);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(234, 204);
            this.userListBox.TabIndex = 1;
            this.userListBox.ValueMember = "About";
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // postListBox
            // 
            this.postListBox.BackColor = System.Drawing.Color.SkyBlue;
            this.postListBox.DataSource = this.postBindingSource;
            this.postListBox.DisplayMember = "Description";
            this.postListBox.FormattingEnabled = true;
            this.postListBox.ItemHeight = 20;
            this.postListBox.Location = new System.Drawing.Point(9, 35);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(413, 204);
            this.postListBox.TabIndex = 1;
            this.postListBox.ValueMember = "Caption";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // filterFriendButton
            // 
            this.filterFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filterFriendButton.Location = new System.Drawing.Point(630, 93);
            this.filterFriendButton.Name = "filterFriendButton";
            this.filterFriendButton.Size = new System.Drawing.Size(146, 57);
            this.filterFriendButton.TabIndex = 48;
            this.filterFriendButton.Text = "Find A Match";
            this.filterFriendButton.UseVisualStyleBackColor = false;
            this.filterFriendButton.Click += new System.EventHandler(this.filterFriendButton_Click);
            // 
            // fetchAllDataButton
            // 
            this.fetchAllDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fetchAllDataButton.Location = new System.Drawing.Point(45, 265);
            this.fetchAllDataButton.Name = "fetchAllDataButton";
            this.fetchAllDataButton.Size = new System.Drawing.Size(73, 76);
            this.fetchAllDataButton.TabIndex = 49;
            this.fetchAllDataButton.Text = "Fetch All Data";
            this.fetchAllDataButton.UseVisualStyleBackColor = false;
            this.fetchAllDataButton.Click += new System.EventHandler(this.fetchAllDataButton_Click);
            // 
            // mainDataPanel
            // 
            this.mainDataPanel.Controls.Add(this.eventListBox);
            this.mainDataPanel.Controls.Add(this.languagesListBox);
            this.mainDataPanel.Controls.Add(this.imageNormalPictureBox1);
            this.mainDataPanel.Controls.Add(this.userListBox);
            this.mainDataPanel.Controls.Add(this.startGameButton);
            this.mainDataPanel.Controls.Add(this.gamePhoto);
            this.mainDataPanel.Controls.Add(this.postListBox);
            this.mainDataPanel.Controls.Add(this.linkPages);
            this.mainDataPanel.Controls.Add(this.linkPosts);
            this.mainDataPanel.Controls.Add(this.linkFriends);
            this.mainDataPanel.Controls.Add(this.linkFavoritePicture);
            this.mainDataPanel.Controls.Add(this.pictureBoxEvent);
            this.mainDataPanel.Controls.Add(this.pictureBoxFriends);
            this.mainDataPanel.Controls.Add(this.linkEvents);
            this.mainDataPanel.Location = new System.Drawing.Point(120, 252);
            this.mainDataPanel.Name = "mainDataPanel";
            this.mainDataPanel.Size = new System.Drawing.Size(934, 786);
            this.mainDataPanel.TabIndex = 46;
            // 
            // FeatureComboBox
            // 
            this.FeatureComboBox.FormattingEnabled = true;
            this.FeatureComboBox.Location = new System.Drawing.Point(575, 186);
            this.FeatureComboBox.Name = "FeatureComboBox";
            this.FeatureComboBox.Size = new System.Drawing.Size(416, 28);
            this.FeatureComboBox.TabIndex = 50;
            this.FeatureComboBox.SelectedIndexChanged += new System.EventHandler(this.FeatureComboBox_SelectedIndexChanged);
            // 
            // FeaturesMenu
            // 
            this.FeaturesMenu.AutoSize = true;
            this.FeaturesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FeaturesMenu.Location = new System.Drawing.Point(575, 165);
            this.FeaturesMenu.Name = "FeaturesMenu";
            this.FeaturesMenu.Size = new System.Drawing.Size(284, 20);
            this.FeaturesMenu.TabIndex = 51;
            this.FeaturesMenu.Text = "Choose a feature you want to use:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1066, 1050);
            this.Controls.Add(this.FeaturesMenu);
            this.Controls.Add(this.FeatureComboBox);
            this.Controls.Add(this.fetchAllDataButton);
            this.Controls.Add(this.filterFriendButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainDataPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Controls.Add(this.postStatus);
            this.Controls.Add(this.postSubmitButton);
            this.Controls.Add(this.textForPost);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePhoto)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainDataPanel.ResumeLayout(false);
            this.mainDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.TextBox textForPost;
        private System.Windows.Forms.Button postSubmitButton;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.LinkLabel linkFavoritePicture;
        private System.Windows.Forms.Label postStatus;
        private System.Windows.Forms.LinkLabel linkEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.PictureBox pictureBoxSymbol;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox gamePhoto;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label religionLabel1;
        private System.Windows.Forms.ListBox postListBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.ListBox languagesListBox;
        private System.Windows.Forms.BindingSource likedPagesBindingSource;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button filterFriendButton;
        private System.Windows.Forms.Button fetchAllDataButton;
        private System.Windows.Forms.Panel mainDataPanel;
        private FeatureMenu FeatureComboBox;
        private System.Windows.Forms.Label FeaturesMenu;
    }
}

