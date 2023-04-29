using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarker_MVP.Models;
using System.Data;



namespace Supermarker_MVP._Repositories
{
    internal class CustomersRepository: BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }





        public void Add(CustomersModel CustomersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = CustomersModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = CustomersModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE Customers_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }


        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE  Customers
                                        SET Customers_Name =@name,
                                        Customers_Observation=@observation
                                        WHERE Customers_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customersModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = customersModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersModel.Id;
                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Name = reader["Customers_Name"].ToString();
                        customersModel.Observation = reader["Customers_Observation"].ToString();
                        customersList.Add(customersModel);

                    }

                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                        WHERE Customers_Id=@id  or Customers_Name                           LIKE @name+ '&'
                                        ORDER By  Customers_Id DESC";

                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Name = reader["Customers_Name"].ToString();
                        customersModel.Observation = reader["Customers_Observation"].ToString();
                        customersList.Add(customersModel);

                    }
                }
            }
            return customersList;
        }
    }
}
