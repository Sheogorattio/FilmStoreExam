using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;

namespace FilmStoreExam.Interfaces
{
    public interface IActor
    {
        public IEnumerable<Actor> GetAllActors();
        public void AddActor(Actor actor);
        public void RemoveActor(Actor actor);
        public void UpdateActor(Actor actor);
        public Actor GetActor(int id);
        PagedList<Actor> GetActors(QueryOptions options);
    }
}
