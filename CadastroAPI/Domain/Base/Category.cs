using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public abstract class Category
    {
        public Category(TypeCategory type)
        {
            Type = type;
        }

        public string Name { get; set; }
        public TypeCategory Type { get; set; }

        public abstract List<Category> SearchCategory();
    }
}
