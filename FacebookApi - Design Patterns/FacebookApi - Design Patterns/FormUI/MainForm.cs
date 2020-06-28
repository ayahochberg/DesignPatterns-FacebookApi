using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public sealed partial class MainForm : Form
    {
        public static AppSettings s_AppSettings;
        private static readonly object sr_InstanceLockContext = new object();
        private static MainForm s_MainFormInstance = null;
        private MainFormFacade m_MainFormFacade = MainFormFacade.GetInstance();

        private MainForm()
        {
            InitializeComponent();
            userBindingSource.DataSource = m_MainFormFacade.m_LoginUser;
            initializeForm();
            initFeatureComboBox();
        }

        private void initFeatureComboBox()
        {
            FeatureMenuItem filerFormMenuItem = new FeatureMenuItem(FormFactory.CreateForm, Utils.k_findMeAMatchHeadLine, Utils.eFormName.Filter);
            FeatureMenuItem gameFormMenuItem = new FeatureMenuItem(FormFactory.CreateForm, Utils.k_GueesingGameHeadLine, Utils.eFormName.Game);
            FeatureComboBox.AddRange(gameFormMenuItem, filerFormMenuItem);
        }

        public static MainForm GetInstance()
        {
            if (s_MainFormInstance == null)
            {
                lock (sr_InstanceLockContext)
                {
                    if (s_MainFormInstance == null)
                    {
                        s_MainFormInstance = new MainForm();
                    }
                }
            }
            return s_MainFormInstance;
        }

        private void initializeForm()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Size = s_AppSettings.LastWindowSize;
            this.Location = s_AppSettings.LastWindowLocation;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            saveAppSettingsBeforeFormClosing();
        }

        private void fetchAllDataButton_Click(object sender, EventArgs e)
        {
            new Thread(fetchFriendsInNewThread).Start();
            new Thread(fetchPostsInNewThread).Start();
            new Thread(fetchFavoritePictureInNewThread).Start();
            new Thread(fetchPagesInNewThread).Start();
            new Thread(fetchEventsInNewThread).Start();
        }

        private void fetchFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFriendsInNewThread).Start();
        }

        private void fetchFriendsInNewThread()
        {
            m_MainFormFacade.FetchFriendsList();
            Invoke(new Action(() => friendsBindingSource.DataSource = m_MainFormFacade.m_FriendList));
        }

        private void fetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPostsInNewThread).Start();
        }

        private void fetchPostsInNewThread()
        {
            m_MainFormFacade.FetchPosts();
            Invoke(new Action(() => postBindingSource.DataSource = m_MainFormFacade.m_PostsList));
        }

        private void fetchFavoritePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFavoritePictureInNewThread).Start();
        }

        private void fetchFavoritePictureInNewThread()
        {
            m_MainFormFacade.FetchFavoritePicture();
            Invoke(new Action(() => photoBindingSource.DataSource = m_MainFormFacade.m_FavoritePicture));
        }

        private void linkPages_OnClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPagesInNewThread).Start();
        }

        private void fetchPagesInNewThread()
        {
            m_MainFormFacade.FetchPages();
            Invoke(new Action(() => likedPagesBindingSource.DataSource = m_MainFormFacade.m_PagesList));
        }

        private void linkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchEventsInNewThread).Start();
        }

        private void fetchEventsInNewThread()
        {
            m_MainFormFacade.FetchEvents();
            Invoke(new Action(() => eventBindingSource.DataSource = m_MainFormFacade.m_EventList));
        }

        private void startGameButton_OnClick(object sender, EventArgs e)
        {
            startGame();
        }

        private void logOutButton_OnClick(object sender, EventArgs e)
        {
            logOut();
        }

        private void displaySelectedFriend()
        {
            if (userListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = userListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
                }
            }
            userListBox.SelectedItems.Clear();
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventListBox.SelectedItems.Count == 1)
            {
                Event selectedEvent = eventListBox.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void postSubmitButton_OnClick(object sender, EventArgs e)
        {
            postSubmit();
        }

        private void postSubmit()
        {
            try
            {
                Status postedStatus = m_MainFormFacade.m_LoginUser.PostStatus(textForPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Somthing went wrong... error message: {0}", e.Message));
            }
        }

        private void startGame()
        {
            if (MainFormFacade.s_FriendList.Count > 0)
            {
                Form gameForm = FormFactory.CreateForm(Utils.eFormName.Game);
                if (gameForm != null)
                {
                    gameForm.Show();
                }
            }
            else
            {
                MessageBox.Show(Utils.k_EmptyFriendListMessage);
            }
        }

        private void filterFriendButton_Click(object sender, EventArgs e)
        {
            if (MainFormFacade.s_FriendList.Count > 0)
            {
                Form filterForm = FormFactory.CreateForm(Utils.eFormName.Filter);
                if (filterForm != null)
                {
                    filterForm.Show();
                }
            }
            else
            {
                MessageBox.Show(Utils.k_EmptyFriendListMessage);
            }
        }

        private void FeatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainFormFacade.s_FriendList.Count > 0)
            {
                FeatureComboBox.OnClickOption();
            }
            else
            {
                MessageBox.Show(Utils.k_EmptyFriendListMessage);
            }
        }

        private void logOut()
        {
            s_AppSettings.LastAccessToken = string.Empty;
            s_AppSettings.RememberUser = false;
            s_AppSettings.SaveToFile();
            Application.Exit();
        }

        private void saveAppSettingsBeforeFormClosing()
        {
            s_AppSettings.LastWindowLocation = this.Location;
            s_AppSettings.LastWindowSize = this.Size;
            s_AppSettings.SaveToFile();
            Application.Exit();
        }

    }
}