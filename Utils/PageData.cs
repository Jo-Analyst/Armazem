using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    internal class PageData
    {
        static public double quantityRowsSelected { get; set; }

        static public double quantity;

        static public int SetPageQuantityProducts()
        {
            quantity = Product.CountQuantityProducts();
            return CalculateNumberOfPage();
        }


        static public int SetPageQuantityRowsReport(string name, string dateEntry)
        {
            quantity = Report.CountQuantityRows(name, dateEntry);            
            return CalculateNumberOfPage();
        }

        static public int SetPageQuantityStorages(int productId)
        {
            quantity = Storage.CountQuantityStorages(productId);
            return CalculateNumberOfPage();
        }

        static public int SetPageQuantityDepartures(int storageId)
        {
            quantity = Departure.CountQuantityDepartures(storageId);
            return CalculateNumberOfPage();
        }

        static public int SetPageQuantityProductsByName(string name)
        {
            quantity = Product.CountQuantityProductsByName(name);
            return CalculateNumberOfPage();
        }

        static private int CalculateNumberOfPage()
        {
            double result = quantity / quantityRowsSelected;
            return (int)Math.Ceiling(result);
        }
    }
}
