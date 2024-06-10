using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Customer:Musers
    {
        private string FeedBack;
        private string usernameForFeedback;

        public string FeedBack1 { get => FeedBack; set => FeedBack = value; }
        public string UsernameForFeedback { get => usernameForFeedback; set => usernameForFeedback = value; }

        public Customer(string username, string password, string role) : base(username, password, role)
        {

        }
        public Customer(string FeedBack, string usernameForFeedback) : base(FeedBack, usernameForFeedback)
        {
            this.FeedBack = FeedBack;
            this.usernameForFeedback = usernameForFeedback;
        }
        public void SetFeedback(string feedback)
        {
            this.FeedBack = feedback;
        }
        public string GetFeedBack()
        {
            return FeedBack;
        }
        public void setusernamefeedback(string username)
        {
            username = usernameForFeedback;
        }
        public string getusernamefeedback()
        {
            return usernameForFeedback;
        }

    }
}
