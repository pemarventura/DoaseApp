using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> _persons = new List<Person>
        { 
            new Person { Email = "1", Senha = "1"}
        };


        public IEnumerable<Person> GetAll()
        {
            return _persons.Select(person => person);
        }

        public Person GetUserByEmail(string email)
        {
            var user = _persons.Where(person => person.Email == email).FirstOrDefault();

            return user;
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        public void UpdatePerson(Person updatedPerson)
        {
            var existingPerson = _persons.FirstOrDefault(person => person.Email == updatedPerson.Email);

            if (existingPerson != null)
            {
                existingPerson.TemCampanha = true;
            }
            else
            {
                throw new ArgumentException("Person not found.");
            }
        }
    }
}
