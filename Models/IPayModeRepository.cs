using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Models
{
    internal interface IPayModeRepository
    {
        void add(PayModeModel payModeModel);
        void edit(PayModeModel payModeModel);
        void delete(int id);


        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
