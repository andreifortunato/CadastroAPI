using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class CategoryEngine : Category
    {

        public CategoryEngine() : base(TypeCategory.Engine) { }
        public override List<Category> SearchCategory()
        {
            return new List<Category>()
            {
                new CategoryEngine() {Name = "Category Engine 01"},
                new CategoryEngine() {Name = "Category Engine 02"},
                new CategoryEngine() {Name = "Category Engine 03"},
                new CategoryEngine() {Name = "Category Engine 04"},
                new CategoryEngine() {Name = "Category Engine 05"},
                new CategoryEngine() {Name = "Category Engine 06"}
            };
        }
    }
}
