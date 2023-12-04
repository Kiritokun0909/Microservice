using Microsoft.EntityFrameworkCore;
using ProductService.Context;
using ProductService.Model;

namespace ProductService.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _dbContext;

        public CategoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCategory(Category product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _dbContext.Categories.Find(categoryId);
            _dbContext.Categories.Remove(category);
            Save();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _dbContext.Categories.Find(categoryId);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;
            Save();
        }
    }
}
