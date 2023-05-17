using CadastroAPI.Domain.Base;
using System;


namespace CadastroAPI.AbstractFactories
{
    public class ProductOutsideFactory : ProductFactory
    {
        public override Category CreateCategory()
        {
            throw new NotImplementedException();
        }

        public override Product CreateProduct()
        {
            return new ProductOutside();
        }
    }
}
