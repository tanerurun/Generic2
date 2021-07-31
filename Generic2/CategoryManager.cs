using System;
using System.Collections.Generic;
using System.Text;

namespace Generic2
{
    public class CategoryManager : ICategoryManager
    {
        public interface ICategoryManager : IRepository<Category> { }
        private static List<Category> _category = new List<Category>() {
    new Category { Id = 1, Title="Yazılım"},
    new Category { Id = 2, Title="Network"},
    };
        public Category Find(int id)
        {
            return _category.Find(x => x.Id == id);
        }

        public List<Category> List()
        {
            return _category;
        }

        public bool Remove(Category category)
        {
            return _category.Remove(category);
        }
    }
}
