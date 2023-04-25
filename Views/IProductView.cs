using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Views
{
    internal interface IProductView
    {

        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }



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


        void SetProductListBildingSource(BindingSource productlList);

        void Show();
    }
}
