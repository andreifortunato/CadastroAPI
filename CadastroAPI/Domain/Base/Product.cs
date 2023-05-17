using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public abstract class Product
    {
        public Product(TypeProduct type)
        {
            Type = type;
        }

        public string Name { get; set; }
        public TypeProduct Type  { get; set; }

        public abstract List<Product> SearchProduct();
    }
}
