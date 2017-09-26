using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifeF2Team9
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDesc { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public DateTime expDate { get; set; }
        public bool isHazardous { get; set; }
        public int numStock { get; set; }
        public int maxStock { get; set; }
        public int reorderPoint { get; set; }
        public int numSold { get; set; }
        public int numInCart { get; set; }
        public int detailID { get; set; }
        public int reorderAmount { get; set; }
        public int amountOrdered { get; set; }
        public DateTime lastSold { get; set; }
        public int receiptID { get; set; }

        public override string ToString()
        {
            return String.Format("Product: ProdcutID = {0}, Name = {1}, Description = {2}, Category = {3}, Price = ${4}, Expiration Date = {5}, Hazardous = {6}, Number In Stock = {7}, Maximum Stock = {8}, Reorder Point = {9}, NumberSold = {10}, Order Amount = {11}",productID, productName, productDesc, category,price,expDate,isHazardous,numStock,maxStock,reorderPoint,numSold,reorderAmount);
        }



    }
}
