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

        public IEnumerable<Person> GetAll()
        {
            return _persons.Select(person => person);
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }
    }
}
