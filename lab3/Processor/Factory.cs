using Lab3.Processor

namespace Lab3
{
    public class Factory
    {
        public static iManager Get(SocialType type)
        {
            switch(type)
            {
                case SocialType.Facebook:
                    return new Facebook();
                case SocialType.LinkedIn:
                    return new LinkedIn();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}