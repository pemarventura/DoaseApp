using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared
{
    public interface IPersonRepository
    {
        IEnumerable<string> GetNames();
        void AddPerson(Person person);
    }
}
