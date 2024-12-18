using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.With_LiskovSubstitutionPrinciple
{
    //Instagram doesn’t support video call feature, so instagram implementation can be design like below
    //Instagram is the substitute of Interfaces SocialMedia and SocialPostAndMediaManager, so this is following Liskov Substitution Principle
    public class Instagram : SocialMedia, SocialPostAndMediaManager
    {
        public void ChatWithFriend()
        {
            //Write logic
        }

        public void PublishPost(object post)
        {
           //Write logic
        }

        public void SendPhotosAndVideos()
        {
            //Write logic
        }
    }
}
