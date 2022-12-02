using Lab2.Processor

namespace Lab2
{
    public class Local : iFile
    {
        private static iFile _instance

        public static iFile GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Local();
            }
            return _instance;
        }

        public object Read(string path)
        {
        }

        public void Write(string path, object value)
        {
        }

        private Local()
        {
        }
    }
}