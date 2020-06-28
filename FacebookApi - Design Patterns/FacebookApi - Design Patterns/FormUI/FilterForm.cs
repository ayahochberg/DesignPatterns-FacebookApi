using FacebookWrapper.ObjectModel;
using FormsUI.FacebookAppLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FilterForm : Form
    {
        private LikedFriendsAggregator m_LikedFriendAggregator = new LikedFriendsAggregator();
        private int m_NumOfLikedFriends = 0;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void filterSubmitButton_Click(object sender, EventArgs e)
        {
            filterFriendList();
        }

        private void filteredListOfFreinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayMatchPicture();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            if (filteredListOfFreinds.SelectedItems.Count == 1)
            {
                User selectedFriend = filteredListOfFreinds.SelectedItem as User;
                m_LikedFriendAggregator.AddFriend(selectedFriend);
                m_NumOfLikedFriends++;
            }
            else
            {
                MessageBox.Show(Utils.k_FetchBeforeClickLikeMessage);
            }
            filteredListOfFreinds.SelectedItems.Clear();
        }

        private void likedListButton_Click(object sender, EventArgs e)
        {
            this.filteredListOfFreinds.Items.Clear();
            this.filteredListOfFreinds.DisplayMember = "Name";
            if (m_NumOfLikedFriends > 0)
            {
                foreach (User friend in m_LikedFriendAggregator)
                {
                    this.filteredListOfFreinds.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                MessageBox.Show(Utils.k_EmptyMatchListMessage);
            }
        }

        private void filterFriendList()
        {
            List<User> filteredListOfFreinds = new List<User>();
            filteredListOfFreinds = FilterFriendsLogic.FilterFriendLists(MainFormFacade.s_FriendList, maleCheckBox, femaleCheckBox, singleStatusCheckBox,
                relationshipStatusCheckBox, complicatedStatusCheckBox, sortOptionComboBox);
            this.filteredListOfFreinds.Items.Clear();
            this.filteredListOfFreinds.DisplayMember = "Name";

            if (filteredListOfFreinds.Count == 0)
            {
                MessageBox.Show(Utils.k_EmptyFilteredFriendListMessage);
            }
            if (MainFormFacade.s_FriendList.Count > 0)
            {
                foreach (User friend in filteredListOfFreinds)
                {
                    this.filteredListOfFreinds.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            else
            {
                MessageBox.Show(Utils.k_FetchBeforeFilterMessage);
            }
        }

        private void displayMatchPicture()
        {
            if (filteredListOfFreinds.SelectedItems.Count == 1)
            {
                User selectedFriend = filteredListOfFreinds.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    matchPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    matchPictureBox.Image = matchPictureBox.ErrorImage;
                }
            }
        }

    }
}
