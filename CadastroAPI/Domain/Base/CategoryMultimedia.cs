using System.Collections.Generic;


namespace CadastroAPI.Domain.Base
{
    public class CategoryMultimedia : Category
    {

        public CategoryMultimedia() : base(TypeCategory.Multimedia) { }
        public override List<Category> SearchCategory()
        {
            return new List<Category>()
            {
                new CategoryMultimedia() {Name = "Category Multimedia 01"},
                new CategoryMultimedia() {Name = "Category Multimedia 02"},
                new CategoryMultimedia() {Name = "Category Multimedia 03"},
                new CategoryMultimedia() {Name = "Category Multimedia 04"},
                new CategoryMultimedia() {Name = "Category Multimedia 05"},
                new CategoryMultimedia() {Name = "Category Multimedia 06"}
            };
        }
    }
}
