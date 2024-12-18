using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.Without_LiskovSubstitutionPrinciple
{
    public class Facebook : SocialMedia
    {
        public override void ChatWithFriend()
        {
            //Write logic 
        }

        public override void PublishPost(object post)
        {
            //Write logic  
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
