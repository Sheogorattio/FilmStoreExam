using FilmStoreExam.Data;
using FilmStoreExam.Interfaces;
using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace FilmStoreExam.Repository
{
    public class ActorRepository : IActor
    {
        private ApplicationContext _context;

        public ActorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public Actor GetActor(int id)
        {
            return _context.Actors.FirstOrDefault(e => e.Id == id);
        }

        public PagedList<Actor> GetActors(QueryOptions options)
        {
            var newList = new PagedList<Actor>(_context.Actors, options);
            return newList;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            return _context.Actors;
        }

        public void RemoveActor(Actor actor)
        {
           _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public void UpdateActor(Actor actor)
        {
            Actor actor2 = _context.Actors.Find(actor.Id);
            if(actor2 != null){
                actor2.Name = actor.Name;
                _context.SaveChanges();
            }
            else
            {
                AddActor(actor);
            }
        }
    }
}
