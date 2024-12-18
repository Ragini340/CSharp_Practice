using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.Without_LiskovSubstitutionPrinciple
{
    public class WhatsApp : SocialMedia
    {
        public override void ChatWithFriend()
        {
            //Write logic
        }

        public override void PublishPost(object post)
        {
            //Not applicable as publish post functionality is not available in 
            //due to publishPost() method whatsapp child is not substitute of parents SocialMedia
        }

        public override void SendPhotosAndVideos()
        {
            //Write logic
        }

        public override void GroupVideoCall(string users)
        {
            //Write logic
        }

    }
}
