using Lab2.Processor

namespace Lab2
{
    public class AmazonS3 : iFile
    {
        private static AmazonS3 _instance

        public static iFile GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AmazonS3();
            }
            return _instance;
        }

        public object Read(string path)
        {
        }

        public void Write(string path, object value)
        {
        }

        private AmazonS3()
        {
        }
    }
}
