using DemoLibrary;
using System;
using System.Collections.Generic;

//Simple program that acts as a POS system to demonstrate interfaces. 

/*
 * 
 * So you have a physical product that ships. What if you also had a digital product? A digital product doesn't need to be shipped, it would be emailed.
 * How do you put it into a List of PhysicalProductModel? You can't.
 *
 *You could create an abstract base class that physical and digital inherit from, but what if you then also have a ServiceProductModel? Those two are so different, an abstract base class would 
 * not be viable.
 * 
 *You can create an interface. An interface is a contract that simply says whatever class implements this contract, it will have these things.
 *          interfaces also use pascal case and start with the letter I, ex. IProductModel.
 *          An interface can be used as the variable type, and that variable will be able to access anything the interface specifies.
 *
 *
 *With all the changes I've made, adding interfaces, my code doesn't need to change if I add another product model. adding a ServiceProductModel, HybridProductModel, or CourseProductModel
 * is no problem.
 * 
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of physical products someone has put in their cart. (data already added)
            //List<PhysicalProductModel> cart = AddSampleData();

            // we've now switched to implementing a List of the interface IProductModel instead of the class PhysicalProductModel
            List<IProductModel> cart = AddSampleData();

            // a customer
            CustomerModel customer = GetCustomer();

            // loops through each product and ships them, passing in customer.
            foreach (IProductModel prod in cart)
            {
                // if you notice, typing in prod. shows 3 things; HasOrderedBeenCompleted, ShipItem, Title.
                // it doesn't show TotalDownloadsLeft because it's not in the contract. It's not known and/or common between all classes.
                prod.ShipItem(customer);

                // if prod is an IDigitalProductModel it creates local digital variable and puts prod into it.
                if (prod is IDigitalProductModel digital)
                {
                    // you now have access to TotalDownloadsLeft by asking if product is also an IDigitalProductModel,
                    // which is an interface that implements IProductModel but also has access to TotalDownloadsLeft.
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// creates a new customer model, populates customer.
        /// </summary>
        /// <returns></returns>
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Noah",
                LastName = "Taylor",
                City = "Carlisle",
                EmailAddress = "noah@programdemo.com",
                PhoneNumber = "543-2100"
            };
        }

        /// <summary>
        /// Adds sample data to cart
        /// </summary>
        /// <returns></returns>
        /*
        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });

            return output;
        }
        */

        // AddSampleData now implements the interface IProductModel instead of the class PhysicalProduct Model.
        // This means that any class implementing the interface IProductModel can be added to the list.
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Course Start to Finish" });

            return output;
        }
    }
}
