using CadastroAPI.AbstractFactories;
using CadastroAPI.Domain;
using CadastroAPI.Domain.Base;
using System;
using System.Collections.Generic;


namespace CadastroAPI.Clients
{

    public class ProductClient
    {
        private readonly Product _product;
        private readonly Category _category;

        public ProductClient(ProductFactory productFactory)
        {
            _product = productFactory.CreateProduct();
            _category = productFactory.CreateCategory();
        }

        public List<Product> SearchProduct()
        {
            return _product.SearchProduct();
        }

        public List<Category> SearchCategory()
        {
            return _category.SearchCategory();
        }

        public static ProductClient CreateProductClient(TypeProduct type)
        {
            switch (type)
            {
                case TypeProduct.Inside:
                    return new ProductClient(new ProductInsideFactory());
                case TypeProduct.Outside:
                    return new ProductClient(new ProductOutsideFactory());
                default:
                    throw new Exception("Not found");
            }
        }
    }
}
