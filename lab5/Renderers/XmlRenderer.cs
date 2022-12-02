using Lab5.Interfaces

namespace Lab5
{
    public class XmlRenderer: iRenderer
    {
        private iPage _page;
        public string Serialize()
        {
            return _page.SerializeToXml();
        }

        public XmlRenderer(iPage page)
        {
            _page = page;
        }
    }
}