using Generics.Demo.Program.Entities;
using System.Linq;

namespace Generics.Demo.Program.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine($"Data saved in list.");
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }

}
