using Supermarker_MVP.Models;
using Supermarker_MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_MVP.Views;
using Supermarker_MVP.Models;

namespace Supermarker_MVP.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.DeleteEvent += DelectSelectCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customersBindingSource);
            LoadAllCustomersList();
            this.view.Show();
        }


        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            var customers = new CustomersModel();
            customers.Id = Convert.ToInt32(view.CustomersId);
            customers.Name = view.CustomersName;
            customers.Observation = view.CustomersObservation;

            try
            {
                new Common.ModelDataValidation().Validate(customers);
                if (view.IsEdit)
                {
                    repository.Edit(customers);
                    view.Message = "Customers edited successsfuly";
                }
                else
                {
                    repository.Add(customers);
                    view.Message = "Customers added successsfuly";
                }
                view.IsSuccesssful = true;
                LoadAllCustomersList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                //si ocurre una excepcion se configura Issuccesful en falso 
                //la propiedad message de la vista se asigna el mensaje de exception
                view.IsSuccesssful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersName = "";
            view.CustomersObservation = "";
        }

        private void DelectSelectCustomers(object? sender, EventArgs e)
        {
            try
            {//se recupera el objeto de la fila seleccionada
                var Customers = (CustomersModel)customersBindingSource.Current;

                repository.Delete(Customers.Id);
                view.IsSuccesssful = true;
                view.Message = "Customers deleted successsfully";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccesssful = false;
                view.Message = "An error ocurred, could not delete Customers";

            }
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            //obtiene el objeto del datagridview 
            var Customers = (CustomersModel)customersBindingSource.Current;

            //se cambia el contenido de la caja de texto por el objeto recuperado
            view.CustomersId = Customers.Id.ToString();
            view.CustomersName = Customers.Name;
            view.CustomersObservation = Customers.Observation;

            //modo edicion
            view.IsEdit = true;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }
    }
}
