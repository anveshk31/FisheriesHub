using FisheriesHub.DataAccess;
using FisheriesHub.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FisheriesHub.BusinessLayer
{
    public class Products
    {
        public static List<Product> GetProductsData()
        {
           // Product product = new Product();
            var productList = new List<Product>();
            DataSet productReport = new DataSet();

            //Get the demographics from database but get the connection string details from web.Config file
            //2rd Assignment
            productReport = MainConfig.GetProducts();
            //3rd Assignment
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithConfig();

            //Get the demographics from database but define the connection string in this method
            //dsGetDemographicsReport = DADemographicsInformation.GetDemographicsUsingDBWithOutConfig();
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithOutConfig();

            if (productReport.Tables.Count > 0)
            {
                productList = productReport.Tables[0].AsEnumerable().Select(m => new Product
                {
                    ProductName = Convert.ToString(m["ProductName"]),
                    Unit = Convert.ToString(m["Unit"]),
                    Price = Convert.ToDecimal(m["Price"])

                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return productList;

        }
    }
}