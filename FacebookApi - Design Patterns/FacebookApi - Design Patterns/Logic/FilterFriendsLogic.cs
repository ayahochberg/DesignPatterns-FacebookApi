using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FormsUI.FacebookAppLogic
{
    public static class FilterFriendsLogic
    {
        private static FriendsSorter m_FriendsSorter = new FriendsSorter();

        public static List<User> FilterFriendLists(List<User> i_FriendList, CheckBox i_MaleCheckBox, CheckBox i_FemaleCheckBox, CheckBox i_SingleStatusCheckBox, CheckBox i_RelationshipStatusCheckBox, CheckBox i_ComplicatedStatusCheckBox, ComboBox i_SortOption)
        {
            List<User> filteredFriendList = new List<User>();
            if (i_FriendList.Count > 0)
            {
                foreach (User friend in i_FriendList)
                {
                    if (isFriendMatchRequirements(friend, i_MaleCheckBox, i_FemaleCheckBox, i_SingleStatusCheckBox, i_RelationshipStatusCheckBox, i_ComplicatedStatusCheckBox))
                    {
                        filteredFriendList.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }

            List<User> sortedFilteredFriendList = filteredFriendList;
            Utils.eSortOption sortOption = (Utils.eSortOption)i_SortOption.SelectedIndex;

            switch (sortOption)
            {
                case Utils.eSortOption.Alphabetical:
                    break;
                case Utils.eSortOption.Age:
                    m_FriendsSorter.SwapStrategy = (User user1, User user2) => user1.compareBirthDay(user2);
                    m_FriendsSorter.Sort(sortedFilteredFriendList);
                    break;
                case Utils.eSortOption.Popularity:
                    m_FriendsSorter.SwapStrategy = (User user1, User user2) => user1.compareNumberOfFriends(user2);
                    m_FriendsSorter.Sort(sortedFilteredFriendList);
                    break;
            }
            return sortedFilteredFriendList;
        }

        private static bool compareBirthDay(this User i_User1, User i_User2)
        {
            string userBirthday1 = i_User1.Birthday;
            string userBirthday2 = i_User2.Birthday;
            int user1Year = 0;
            int user2Year = 0;
            int numOfOccurence = userBirthday1.Count(x => x == '/');
            if(numOfOccurence == 2)
            {
                user1Year = int.Parse(userBirthday1.Substring(userBirthday1.LastIndexOf('/') + 1));
            }
            numOfOccurence = userBirthday2.Count(x => x == '/');
            if (numOfOccurence == 2)
            {
                user1Year = int.Parse(userBirthday2.Substring(userBirthday1.LastIndexOf('/') + 1));
            }
            return user1Year > user2Year;
        }

        private static bool compareNumberOfFriends(this User i_User1, User i_User2)
        {
            return i_User1.Friends.Count < i_User2.Friends.Count;
        }

        private static Boolean isFriendMatchRequirements(User i_Friend, CheckBox i_MaleCheckBox, CheckBox i_FemaleCheckBox, CheckBox i_SingleStatusCheckBox, CheckBox i_RelationshipStatusCheckBox, CheckBox i_ComplicatedStatusCheckBox)
        {
            bool relationshipStatusBoolean = false;
            bool genderBoolean = false;

            List<eGender> genders = new List<eGender>();
            if (i_MaleCheckBox.Checked)
            {
                genders.Add(eGender.male);
            }
            if (i_FemaleCheckBox.Checked)
            {
                genders.Add(eGender.female);
            }
            if (genders.Count == 0)
            {
                genderBoolean = true;
            }
            else
            {
                foreach (eGender gender in genders)
                {
                    if (gender == i_Friend.Gender)
                    {
                        genderBoolean = true;
                    }
                }
            }

            List<eRelationshipStatus> relationshipStatuses = new List<eRelationshipStatus>();
            if (i_SingleStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.Single);
            }
            if (i_RelationshipStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.InARelationship);
            }
            if (i_ComplicatedStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.ItsComplicated);
            }
            if (relationshipStatuses.Count == 0)
            {
                relationshipStatusBoolean = true;
            }
            else
            {
                foreach (eRelationshipStatus relationshipStatus in relationshipStatuses)
                {
                    if (relationshipStatus == i_Friend.RelationshipStatus)
                    {
                        relationshipStatusBoolean = true;
                    }
                }
            }

            return (genderBoolean && relationshipStatusBoolean);
        }


    }
}
