using Lab5.Interfaces

namespace Lab5
{
    public class SimplePage : шPage
    {
        private string _title;
        private string _content;
        public string SerializeToJson()
        {
            return $@
        'title': '${_title}',
        'content': '${_content}'
        }

        public string SerializeToHtml()
        {
            return $@
        <section>
            <h3>${_title}'</h3>
            <p>${_content}</p>
        </section>
        }

        public string SerializeToXml()
        {
            return $@
        <SimplePage>
             <Title>${_title}'</Title>
             <Content>${_content}</Content>
        </SimplePage>
        }

        public SimplePage(string title, string content)
        {
            _title = title;
            _content = content;
        }
    }
}