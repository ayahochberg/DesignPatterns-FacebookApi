using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace FormsUI.FacebookAppLogic
{
    internal class LikedFriendsAggregator : IEnumerable<User>
    {
        private HashSet<User> m_LikedFriends = new HashSet<User>();

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User post in m_LikedFriends)
            {
                yield return post;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddFriend(User i_Friend)
        {
            m_LikedFriends.Add(i_Friend);
        }
    }
}
