using Lab5.Interfaces

namespace Lab5
{
    public class JsonRenderer: iRenderer
    {
        private iPage _page;
        public string Serialize()
        {
            return _page.SerializeToJson();
        }

        public JsonRenderer(iPage page)
        {
            _page = page;
        }
    }
}