using ProductService.Model;

namespace ProductService.Repository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(int categoryId);
        public Category GetCategoryById(int categoryId);
        public void Save();
    }
}
