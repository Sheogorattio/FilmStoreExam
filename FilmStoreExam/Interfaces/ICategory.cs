using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;

namespace FilmStoreExam.Interfaces
{
    public interface ICategory
    {
        PagedList<Category> GetCategories(QueryOptions options);
        IEnumerable<Category> GetAllCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
