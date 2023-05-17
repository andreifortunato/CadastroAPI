using CadastroAPI.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAPI.Domain
{
    public class ProductDto : Product
    {
        public ProductDto(TypeProduct type) : base(type)
        {
        }

        public override List<Product> SearchProduct()
        {
            return new List<Product>();
        }
    }
}
