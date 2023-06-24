using DoaseApp.Shared.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _persons = new List<Person>();
        private readonly DoaseContext _context;

        public PersonRepository(DoaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            //return _persons.Select(person => person);
            return _context.Person.ToList();
        }

        public Person GetUserByEmail(string email)
        {
            //var user = _persons.Where(person => person.Email == email).FirstOrDefault();
            var user = _context.Person.FirstOrDefault(p => p.Email == email);

            return user;
        }

        public void AddPerson(Person person)
        {
            //_persons.Add(person);
            _context.Person.Add(person);
            _context.SaveChanges();
        }
    }
}
