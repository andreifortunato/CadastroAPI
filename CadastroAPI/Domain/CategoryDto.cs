using CadastroAPI.Domain.Base;
using System;
using System.Collections.Generic;


namespace CadastroAPI.Domain
{
    public class CategoryDto : Category
    {
        public CategoryDto(TypeCategory type) : base(type)
        {
        }

        public override List<Category> SearchCategory()
        {
            throw new NotImplementedException();
        }
    }
}
