using Lab5.Interfaces

namespace Lab5
{
    public class HtmlRenderer: iRenderer
    {
        private iPage _page;
        public string Serialize()
        {
            return _page.SerializeToHtml();
        }

        public HtmlRenderer(iPage page)
        {
            _page = page;
        }
    }
}