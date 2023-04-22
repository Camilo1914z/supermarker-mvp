using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_MVP.Models;
using Supermarker_MVP.Views;
using Supermarker_MVP._Repositories;

namespace Supermarker_MVP.Presenters
{
    internal class MainPresenter
    {

        public readonly IMainView mainView;
        public readonly string sqlConnectionString;


        public MainPresenter(IMainView mainView, string sqlConnectionString) {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;


        }
        private void ShowPayModeView(object? sender, EventArgs e) {
            IPayModeView view = new PayModeView();
            IPayModeRepository repository= new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

    }
}
