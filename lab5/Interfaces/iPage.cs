namespace Lab5.Interfaces
{
    public interface iPage
    {
        string SerializeToHtml();
        string SerializeToJson();
        string SerializeToXml();
    }
}