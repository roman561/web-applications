using Lab2.Interfaces;
using Lab2.Processor;

namespace Lab2
{
    public class FileManager
    {
        public static iFile Get(StorageType storageType)
        {
            switch(storageType)
            {
                case StorageType.AmazonS3:
                    return AmazonS3.GetInstance();
                case StorageType.Local:
                    return Local.GetInstance();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}