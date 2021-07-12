using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity4BL;

namespace Activity4
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "";
            string address = "", emailId = "", password = "", customerType = "";
            DateTime dateOfBirth = new DateTime();
            Gender g = new Gender();
            Category category = new Category();
            string productName = "", description = "";
            double price = 0.0D;
            string sellerName = "";
            int quantityOrdered = 0;
            DateTime dateOfPurchase = new DateTime();
            string paymentType;
            try
            {
                Console.WriteLine("Enter Customer Name:");
                customerName = Console.ReadLine();
                if (customerName == null)
                    throw new ArgumentException();
                if (customerName != null)
                    foreach (char ch in customerName)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch == ' '))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                Console.WriteLine("Enter Customer Address:");
                address = Console.ReadLine();
                if (address == null)
                    throw new ArgumentException();

                Console.WriteLine("Enter Customer Type:");
                customerType = Console.ReadLine();
                if (customerType == null)
                    throw new ArgumentException();
                if (customerType != null)
                    foreach (char ch in customerType)
                    {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();
                if (password == null && password.GetType() != typeof(string))
                    throw new ArgumentException();

                Console.WriteLine("Enter PaymentType:");
                paymentType = Console.ReadLine();
                if (paymentType == null && paymentType.GetType() != typeof(string))
                    throw new ArgumentException();

                Console.WriteLine("Enter Date Of Birth:");
                dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);
                if (dateOfBirth.GetType() != typeof(DateTime))
                    throw new ArgumentException();
                Console.WriteLine("Enter the gender:");
                g.gender = Console.ReadLine();

                Console.WriteLine("Enter Email ID:");
                emailId = Console.ReadLine();
                if (emailId == null || !emailId.Contains('@') || !emailId.Contains('.'))
                    throw new ArgumentException();
                    Console.WriteLine("Product Name: ");
                    productName = Console.ReadLine();
                    Console.WriteLine("Product Price: ");
                    price = Convert.ToDouble(Console.ReadLine());
                    if (price.GetType() != typeof(double))
                        throw new ArgumentException();
                    Console.WriteLine("Product Description: ");
                    description = Console.ReadLine();
                    Console.WriteLine("Category: ");
                    category.categoryName = Console.ReadLine();

                Console.WriteLine("Enter Quantity Entered:");
                quantityOrdered = Convert.ToInt32(Console.ReadLine());
                if (quantityOrdered.GetType() != typeof(int))
                    throw new ArgumentException();


                Product product1= new Product(description, price, productName, category);
                Purchase p = new Purchase(dateOfPurchase, paymentType, quantityOrdered, address);
                double bill = p.CalculateBillAmount(product1,quantityOrdered);
                Customer customer = new Customer(customerName, address, dateOfBirth, emailId, password, customerType);
                Console.WriteLine($"\n\nCustomer details:\n \nCustomer Name: {customer.CustomerName} \nCustomer Id: {customer.CustomerId} \nCustomer Address: {customer.Address} \nDate of Birth: {customer.DateOfBirth} \nEmail Id: {customer.EmailId} \nGender: {g.gender} \nPassword: {customer.Password} \nCustomer Type: {customer.CustomerType}");
                Console.WriteLine("\n\nProduct Details: ");
                    Console.WriteLine($"\nProduct: \nProduct Id: {product1.ProductId} \nProduct Name: {product1.ProductName} \nProduct Description: {product1.Description} \nProduct Price: {product1.Price}");

                Console.WriteLine($"\n\nPurchase Details: \nPurchase ID: {p.PurchaseId} \nPurchase Date: {p.DateOfPurchase} \nQuantity Ordered: {p.QuantityOrdered} \nShipping Address: {p.ShippingAddress} \nPayment Type: {p.PaymentType} \nBill Amount: {bill}");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Entry:");
            }

            finally
            {
                Console.ReadLine();
                System.Environment.Exit(1000);
            }

        }
    }
}
    
