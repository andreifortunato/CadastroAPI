using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class ProductOutside : Product
    {

        public ProductOutside() : base(TypeProduct.Outside) { }
        public override List<Product> SearchProduct()
        {
            return new List<Product>()
            {
                new ProductOutside() {Name = "Product Outside 01"},
                new ProductOutside() {Name = "Product Outside 02"},
                new ProductOutside() {Name = "Product Outside 03"},
                new ProductOutside() {Name = "Product Outside 04"},
                new ProductOutside() {Name = "Product Outside 05"},
                new ProductOutside() {Name = "Product Outside 06"}
            };
        }
    }
}
