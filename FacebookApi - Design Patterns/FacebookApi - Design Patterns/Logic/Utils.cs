namespace FormsUI.FacebookAppLogic
{ 
    internal static class Utils
    {
        public const string k_WelcomeMessage = "Hey {0} ! Welcome to our facebook v2.0 app. Enjoy your time here with us!";
        public const string k_LoginProblemMessage = "Sorry, somthing went worng, please ty again to login to your facebook account";
        public const string k_NoDataToFetchMessage = "No data to retrieve :(";
        public const string k_FetchPerrmissionDenyMessage = "You dont have permmissions for fetching this Item - we are sorry :( , message error: {0}";
        public const string k_EmptyFriendListMessage = "Your friend list is empty, please return to the main page and fetch friend list :)";
        public const string k_WorngGuessMessage = "Worng guess, the name of the friend in the photo is: {0} ,try again or raffle to change photo..";
        public const string k_CorrectGuessMessage = "Great, You are a fantastic friend!!! :) , click raffle to keep gueesing";
        public const string k_EmptyFilteredFriendListMessage = "Your filtered friend list is empty, please change you filterparameters:)";
        public const string k_FetchBeforeFilterMessage = "You dont have friends in you friend list , please try to fecth firends to your friend list first and than try to filter again...";
        public const string k_FetchBeforeClickLikeMessage = "You didnt choose a friends from your match list , please choose a friend first...";
        public const string k_EmptyMatchListMessage = "You dont have any friends in your match list...";
        public const string k_findMeAMatchHeadLine = "Find Me A Match";
        public const string k_GueesingGameHeadLine = "How Well Do You Know Your Friends Game";

        public enum eFormName
        {
            Game,
            Filter
        }

        public enum eSortOption
        {
            Alphabetical = 0,
            Age = 1,
            Popularity = 2
        }
    }
}
