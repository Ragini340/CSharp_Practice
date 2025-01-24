namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.With_LiskovSubstitutionPrinciple
{
    public class Facebook : ISocialMedia, ISocialPostAndMediaManager, IVideoCallManager
    {
        public void ChatWithFriend()
        {
            //Write your logic
        }

        public void GroupVideoCall(string users)
        {
            //Write logic
        }

        public void PublishPost(object post)
        {
            //Write your logic
        }

        public void SendPhotosAndVideos()
        {
            //Write your logic
        }

    }
}