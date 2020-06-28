using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FormsUI.FacebookAppLogic
{
    internal sealed class GameFormLogic
    {
        private const int k_NumberOfNameToRandom = 5;
        private static Random s_RandomUserGuess = new Random();
        private List<string> m_RandomNamesToChoose = new List<string>();
        private string m_PrevUserNameToGuess;
        private string m_CurrentNameToGuess;
        private int m_NumberOfFriends = MainFormFacade.s_FriendList.Count;

        public List<string> CreateListOfOptionFromFriendsList()
        {
            resetGame();
            int randomNumber = s_RandomUserGuess.Next(m_NumberOfFriends);
            int numberOfNameToRandom = k_NumberOfNameToRandom <= m_NumberOfFriends ? k_NumberOfNameToRandom : m_NumberOfFriends;
            m_RandomNamesToChoose.Add(m_CurrentNameToGuess);
            while (m_RandomNamesToChoose.Count < numberOfNameToRandom)
            {
                randomNumber = s_RandomUserGuess.Next(m_NumberOfFriends);
                string randomName = MainFormFacade.s_FriendList[randomNumber].Name;
                if (!m_RandomNamesToChoose.Contains(randomName))
                {
                    m_RandomNamesToChoose.Add(randomName);
                }
            }
            return m_RandomNamesToChoose;

        }

        public User GetCurrentUserToGuess()
        {
            User currentUserToGuess = null;
            string currentUserNameToGuess = m_PrevUserNameToGuess;
            int randomNumber = s_RandomUserGuess.Next(m_NumberOfFriends);

            while (currentUserNameToGuess == m_PrevUserNameToGuess)
            {
                currentUserToGuess = MainFormFacade.s_FriendList[randomNumber];
                currentUserNameToGuess = currentUserToGuess.Name;
                randomNumber = s_RandomUserGuess.Next(m_NumberOfFriends);
            }

            m_PrevUserNameToGuess = currentUserNameToGuess;
            m_CurrentNameToGuess = currentUserNameToGuess;
            return currentUserToGuess;
        }

        public bool CheckAnswerOfTheUser(string i_SelectedName)
        {
            bool isAnswerCorrect;
            if (i_SelectedName == m_CurrentNameToGuess)
            {
                isAnswerCorrect = true;
            }
            else
            {
                isAnswerCorrect = false;
            }
            return isAnswerCorrect;
        }

        private void resetGame()
        {
            m_RandomNamesToChoose = new List<string>();
        }

    }
}
