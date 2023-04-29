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
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.showProvidersView += ShowProvidersView;


        }
        private void ShowPayModeView(object? sender, EventArgs e) {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository= new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        private void ShowProvidersView(object? sender, EventArgs e)
        {
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new ProvidersRepository(sqlConnectionString);
            new ProvidersPresenter(view, repository);
        }

    }
}
