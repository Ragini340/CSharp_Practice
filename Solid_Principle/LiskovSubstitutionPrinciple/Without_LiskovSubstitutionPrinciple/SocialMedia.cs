using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.LiskovSubstitutionPrinciple.Without_LiskovSubstitutionPrinciple
{
    public abstract class SocialMedia
    {
        public abstract void ChatWithFriend();

        public abstract void PublishPost(object post);

        public abstract void SendPhotosAndVideos();

        public abstract void GroupVideoCall(string users);
    }
}
