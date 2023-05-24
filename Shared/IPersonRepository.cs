using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        void AddPerson(Person person);
    }
}
