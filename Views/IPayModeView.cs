﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Views
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }



        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesssful { get; set; }
        string Message { get; set; }


        event EventHandler  SearchEvent ;
        event EventHandler AddNewEvent  ;
        event EventHandler EditEvent  ;
        event EventHandler DeleteEvent   ;
        event EventHandler SaveEvent  ;
        event EventHandler  CancelEvent ;


        void SetPayModeListBildingSource(BindingSource payModelList);

        void Show();


        }
}
