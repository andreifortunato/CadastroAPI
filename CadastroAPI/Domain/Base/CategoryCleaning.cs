using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class CategoryCleaning : Category
    {
        public CategoryCleaning() : base(TypeCategory.Cleaning) { }
        public override List<Category> SearchCategory()
        {
            return new List<Category>()
            {
                new CategoryCleaning() {Name = "Category Cleaning  01"},
                new CategoryCleaning() {Name = "Category Cleaning  02"},
                new CategoryCleaning() {Name = "Category Cleaning  03"},
                new CategoryCleaning() {Name = "Category Cleaning  04"},
                new CategoryCleaning() {Name = "Category Cleaning  05"},
                new CategoryCleaning() {Name = "Category Cleaning  06"}
            };
        }
    }
}
