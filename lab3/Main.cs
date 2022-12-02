using Lab3

namespace Lab3
{
    public class Main
    {
        private const string LOGIN = "login";
        private const string EMAIL = "name@email.com";
        private const string PASSWORD = "pass";

        public void Run()
        {
            var facebook = Factory.Get(SocialType.Facebook);
            facebook.Authorize(LOGIN, PASSWORD);
            facebook.PostMessage("Post on Facebook");

            var linkedIn = Factory.Get(SocialType.LinkedIn);
            linkedIn.Authorize(EMAIL, PASSWORD);
            linkedIn.PostMessage("Post on LinkedIn");
        }
    }
}