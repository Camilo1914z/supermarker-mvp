using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_MVP.Views;
using Supermarker_MVP.Models;

namespace Supermarker_MVP.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DelectSelectProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);
            LoadAllproductList();
            this.view.Show();
        }


        private void LoadAllproductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Description = view.ProductDescription;

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successsfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successsfuly";
                }
                view.IsSuccesssful = true;
                LoadAllproductList();
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
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductDescription = "";
        }

        private void DelectSelectProduct(object? sender, EventArgs e)
        {
            try
            {//se recupera el objeto de la fila seleccionada
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccesssful = true;
                view.Message = "Product deleted successsfully";
                LoadAllproductList();
            }
            catch (Exception ex)
            {
                view.IsSuccesssful = false;
                view.Message = "An error ocurred, could not delete product";

            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //obtiene el objeto del datagridview 
            var product = (ProductModel)productBindingSource.Current;

            //se cambia el contenido de la caja de texto por el objeto recuperado
            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductDescription = product.Description;

            //modo edicion
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

    }
}
