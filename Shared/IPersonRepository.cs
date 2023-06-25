using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetUserByEmail(string email);
        void AddPerson(Person person);
        void UpdatePerson(Person updatedPerson);
    }
}
