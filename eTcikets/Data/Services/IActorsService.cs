using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        
        Task<IEnumerable<Actor>> GetAll(); //return type (IEnumerable) followed by method name  'GetAll'
        Actor GetById (int id); //get an actor
        void Add(Actor actor); //add the actor to a db
        Actor Update(int id, Actor newActor); //update the db
        void Delete(int id); //delete from db
    } 
}
