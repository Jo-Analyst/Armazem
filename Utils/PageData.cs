using DataBase;
using System;

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


        static public int SetPageQuantityRowsReportCompleted(string name, string dateEntry)
        {
            quantity = ReportCompleted.CountQuantityRows(name, dateEntry);
            return CalculateNumberOfPage();
        }
        
        static public int SetPageQuantityRowsDetailedReport(string name, string dateEntry)
        {
            quantity = DetailedReport.GetReport(name, dateEntry).Rows.Count;
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
