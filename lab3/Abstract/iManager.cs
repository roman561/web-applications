namespace Lab3.Abstract
{
    public interface iManager
    {
        bool Authorize(string username, string password);
        string PostMessage(string message);
    }
}