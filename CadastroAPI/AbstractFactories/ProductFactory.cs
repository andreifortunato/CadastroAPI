using CadastroAPI.Domain.Base;


namespace CadastroAPI.AbstractFactories
{
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct();
        public abstract Category CreateCategory();
    }
}
