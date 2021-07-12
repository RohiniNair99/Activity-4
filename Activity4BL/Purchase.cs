using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4BL
{

      public class Purchase
        {

        private Customer customer;
        private DateTime dateOfPurchase;
        private string paymentType;
        public static int purchaseCounter;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;
        static Purchase()
        {
            purchaseCounter = 1001;
        }
        public Purchase() 
        {
            PurchaseId = "B" + purchaseCounter.ToString();
            purchaseCounter++;
         }
           

            public Purchase(DateTime dateOfPurchase, string paymentType, int quantityOrdered, string shippingAddress):this()
            {
                DateOfPurchase = dateOfPurchase;
                PaymentType = paymentType;
                QuantityOrdered = quantityOrdered;
                ShippingAddress = shippingAddress;
            }

            public DateTime DateOfPurchase { get; set; }
            public string PaymentType { get; set; }
            public string PurchaseId { get; set; }
            public int QuantityOrdered { get; set; }
            public string ShippingAddress { get; set; }

        public double CalculateDiscount()
        {
            return 0.05;
        }

        public double CalculateBillAmount( Product[] products)
            {
            double totalPrice = 0.0;
            foreach (Product product in products)
            {
                totalPrice += product.Price ;
            }

            double serviceTax = 0.07 * totalPrice;
            double discountPercentage = CalculateDiscount();
            double totalBillAmount = ((totalPrice + serviceTax) * (1 - discountPercentage));
            return totalBillAmount;
        }
    
            public double CalculateBillAmount(Product product, int quantityRequired)
            {
                double totalPrice = product.Price * quantityRequired;
                double serviceTax = 0.07 * totalPrice;
                return (totalPrice + serviceTax) * (1 - CalculateDiscount());
            }
            

        }
    }
