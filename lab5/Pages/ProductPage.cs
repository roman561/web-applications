using Lab5.Interfaces

namespace Lab5
{
    public class ProductPage: iPage
    {
        private Product _product;
        public string SerializeToJson()
        {
            return $@
        'product':
        'id': '${_product.Id}',
        'name': '${_product.Name}',
        'description': '${_product.Description}',
        'image': '${_product.Image}',
        }

        public string SerializeToHtml()
        {
            return $@
        <section data-id'{_product.Id}'>
        <h3>${_product.Name}'</h3>
        <p>${_product.Description}</p>
        <img stc='${_product.Image}'/>
        </section>
        }

        public string SerializeToXml()
        {
            return $@
        <ProductPage>
            <Product>
                <Id>${_product.Id}'</Id>
                <Name>${_product.Name}</Name>
                <Description>${_product.Description}</Description>
                <ImageUrl>${_product.Image}</Image>
            </Product>
        </ProductPage>
        }

        public ProductPage(Product product)
        {
            _product = product;
        }
    }
}