namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.With_LiskovSubstitutionPrinciple
{
    public class WhatsApp : ISocialMedia, IVideoCallManager
    {
        public void ChatWithFriend()
        {
            //Write your logic
        }

        public void GroupVideoCall(string users)
        {
            //Write your logic
        }

        public void SendPhotosAndVideos()
        {
            //Write your logic
        }

    }
}