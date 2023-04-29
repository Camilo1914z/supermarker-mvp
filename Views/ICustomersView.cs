using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Views
{
    internal interface ICustomersView
    {
        string CustomersId { get; set; }
        string CustomersName { get; set; }
        string CustomersObservation { get; set; }



        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesssful { get; set; }
        string Message { get; set; }


        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;


        void SetCustomersListBildingSource(BindingSource customersList);

        void Show();
    }
}
