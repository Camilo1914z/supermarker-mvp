using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Models
{
    internal interface IProvidersRepository
    {
        void Add(ProvidersModel providers);
        void Edit(ProvidersModel providers);
        void Delete(int id);


        IEnumerable<ProvidersModel> GetAll();
        IEnumerable<ProvidersModel> GetByValue(string value);
    }
}
