using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;

namespace FilmStoreExam.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        void UpdateAll(Product[] products);
        void DeleteProduct(Product product);
        PagedList<Product> GetProducts(QueryOptions options);
    }
}
