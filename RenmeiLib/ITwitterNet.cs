﻿namespace RenmeiLib
{
    public interface IServiceApi
    {
        Tweet AddTweet(string text);
        Tweet AddTweet(string text, double replyid);
        Comment AddComment(string text, Tweet tweet);

        void AddFavTweet(double tid);

        string ClientName { get; set; }
        string CreateFriendshipUrl { get; set; }
        string SendMessageUrl { get; set; }
        string UpdateUrl { get; set; }
        string FavTweetUrl { get; set; }
        string UserName { get; }
        string UserShowUrl { get; set; }
        string UserTimelineUrl { get; set; }
        string DestroyDirectMessageUrl { get; set; }
        string DestroyUrl { get; set; }
        string DirectMessagesUrl { get; set; }
        string FollowersUrl { get; set; }
        string FriendsTimelineUrl { get; set; }
        string FriendsUrl { get; set; }
        string PublicTimelineUrl { get; set; }
        string RepliesTimelineUrl { get; set; }
        string Format { get; set; }

        void DestroyDirectMessage(double id);
        void DestroyTweet(double id);
        void FollowUser(string userName);
        void ChangeFollowStatus(int userId,string action);
        void SendMessage(string user, string text);


        //UserCollection GetFriends(int userId);
        //UserCollection GetFriends();
        FriendGroupCollection getFriendGroups();
        User CurrentlyLoggedInUser { get; set; }
        User GetUser(int userId);
        User Login();
        Tweet RetrieveTweet(double id);
        TweetCollection GetConversation(double id);
        TweetCollection GetFriendsTimeline();
        TweetCollection GetFriendsTimeline(string since, string userId);
        TweetCollection GetFriendsTimeline(string since);
        TweetCollection GetPublicTimeline(string since);
        TweetCollection GetPublicTimeline();
        TweetCollection GetReplies();
        TweetCollection GetReplies(string since);
        TweetCollection GetFavoriteTweets();
        TweetCollection GetUserTimeline(string userId);
        DirectMessageCollection RetrieveMessages();
        DirectMessageCollection RetrieveMessages(string since);
        CommentCollection RetriveComments(Tweet tweet);
        TweetCollection RetriveCommentedTweets();
        TweetCollection RetriveMySelfTweets();

        System.Security.SecureString Password { get; set; }
        System.Net.IWebProxy WebProxy { get; set; }

        string TwitterServerUrl { get; set; }

        void PostPhoto(System.IO.FileInfo fileInfo, string text);

        UserCollection getMyFollowFriendsList();
        UserCollection getFollowMeFriendsList();
    }
}
