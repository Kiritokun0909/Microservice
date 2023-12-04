using ProductService.Model;

namespace ProductService.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int productId);
        public Product GetProductById(int productId);
        public void Save();
    }
}
