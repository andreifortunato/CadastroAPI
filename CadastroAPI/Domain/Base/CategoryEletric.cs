using System;
using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class CategoryEletric : Category
    {

        public CategoryEletric() : base(TypeCategory.Eletric) { }
        public override List<Category> SearchCategory()
        {
            return new List<Category>()
            {
                new CategoryEletric() {Name = "Category Eletric 01"},
                new CategoryEletric() {Name = "Category Eletric 02"},
                new CategoryEletric() {Name = "Category Eletric 03"},
                new CategoryEletric() {Name = "Category Eletric 04"},
                new CategoryEletric() {Name = "Category Eletric 05"},
                new CategoryEletric() {Name = "Category Eletric 06"}
            };
        }
    }
}
