namespace Lab2
{
    public class Main
    {
        void Run()
        {
            var amazonS3 = FileManager.Get(StorageType.AmazonS3);
            var local = FileManager.Get(StorageType.Local);

            var file = amazonS3.Read("test.csv");
            local.Write("test.csv", file);
        }
    }
}