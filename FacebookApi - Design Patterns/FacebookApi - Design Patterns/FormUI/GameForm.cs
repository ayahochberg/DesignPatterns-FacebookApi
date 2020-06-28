using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public partial class GameForm : Form
    {
        private GameFormLogic m_GameFormLogic = new GameFormLogic();
        private List<string> m_OptionListOfFriendsNames = new List<string>();
        private User m_CurrentUserToGuess;

        public GameForm()
        {
            InitializeComponent();
        }

        private void pickRandomFriendButton_OnClick(object sender, EventArgs e)
        {
            pickRandomFriendFromFriendList();
        }

        private void submitChosenNameButton_OnClick(object sender, EventArgs e)
        {
            selectFriendNameFromList();
        }

        private void pickRandomFriendFromFriendList()
        {
            resetForm();
            m_CurrentUserToGuess = m_GameFormLogic.GetCurrentUserToGuess();
            friendPhoto.LoadAsync(m_CurrentUserToGuess.PictureLargeURL);
            m_OptionListOfFriendsNames = m_GameFormLogic.CreateListOfOptionFromFriendsList();
            foreach (string name in m_OptionListOfFriendsNames)
            {
                nameOptionsList.Items.Add(name);
            }
        }

        private void selectFriendNameFromList()
        {
            bool isCorrect = m_GameFormLogic.CheckAnswerOfTheUser((string)nameOptionsList.SelectedItem);

            if (isCorrect)
            {
                MessageBox.Show(Utils.k_CorrectGuessMessage);
            }
            else
            {
                MessageBox.Show(String.Format(Utils.k_WorngGuessMessage, m_CurrentUserToGuess.Name));
            }

            resetForm();
        }

        private void resetForm()
        {
            foreach (String name in m_OptionListOfFriendsNames)
            {
                nameOptionsList.Items.Remove(name);
            }
            nameOptionsList.SelectedItems.Clear();
            m_OptionListOfFriendsNames = new List<string>();
        }
    }
}
