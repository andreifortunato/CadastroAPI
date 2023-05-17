using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class ProductInside : Product
    {

        public ProductInside(): base(TypeProduct.Inside) { }
        public override List<Product> SearchProduct()
        {
            return new List<Product>()
            { 
                new ProductInside() {Name = "Product Inside 01"},
                new ProductInside() {Name = "Product Inside 02"},
                new ProductInside() {Name = "Product Inside 03"},
                new ProductInside() {Name = "Product Inside 04"},
                new ProductInside() {Name = "Product Inside 05"},
                new ProductInside() {Name = "Product Inside 06"}

            };
        }
    }
}
