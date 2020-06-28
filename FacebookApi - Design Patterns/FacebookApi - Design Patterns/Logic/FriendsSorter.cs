using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FormsUI.FacebookAppLogic
{
    internal delegate bool StrategyDelegate(User i_User1, User i_User2);

    internal class FriendsSorter
    {
        public StrategyDelegate SwapStrategy { get; set; }

        public void Sort(List<User> i_FriendList)
        {
            for (int g = i_FriendList.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_FriendList.Count; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (SwapStrategy.Invoke(i_FriendList[j], i_FriendList[j + g]))
                        {
                            User temp = i_FriendList[j];
                            i_FriendList[j] = i_FriendList[j + g];
                            i_FriendList[j + g] = temp;
                        }
                    }
                }
            }
        }
    }

}
