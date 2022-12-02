using Lab5.Concrete;
using Lab5.Renderers;

namespace Lab5
{
    public class Main
    {
        public void Run()
        {
            var client = new Client();
            var productPage = new ProductPage("Title", "Content");
            var product = new Product()
            {
                Id = 00056,
                Name = "Product",
                Description = "Content",
                Image = "https://product.com/image.jpeg"
            };
            var productPage = new ProductPage(product);

            var htmlRenderer = new HtmlRenderer(productPage);
            client.Render(htmlRenderer1);

            var jsonRenderer = new JsonRenderer(productPage);
            client.Render(jsonRenderer);

            var xmlRenderer = new XmlRenderer(productPage);
            client.Render(xmlRenderer);
        }
    }
}