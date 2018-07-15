using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FisheriesHub.DataAccess
{
    public class MainConfig
    {
        public static DataSet GetProducts()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet fishersHub = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["FishersHub"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from Product";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            fishersHub.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return fishersHub;
        }

        public static DataSet InsertCustomers(string CustomerId,string CustomerName, string Email, string Contact)
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet fishersHub = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["FishersHub"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "INSERT INTO dbo.Customer (CustomerId,CustomerName,Email,Contact) VALUES (@CustomerId,@CustomerName, @Email, @Contact)";
            command = new SqlCommand(sql, cnn);
                //a shorter syntax to adding parameters
                command.Parameters.Add("@CustomerId", SqlDbType.VarChar).Value = CustomerId;

                command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = CustomerName;

                //a longer syntax for adding parameters
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;

                command.Parameters.Add("@Contact", SqlDbType.VarChar).Value = Contact;

                //make sure you open and close(after executing) the connection
                cnn.Open();
                command.ExecuteNonQuery();
            command.Dispose();

            fishersHub.Tables.Add(dt);
            cnn.Close();

            return fishersHub;
        }
    }
    }