using System;

namespace DemoLibrary
{
    // implement interface with a colon and interface name
    // How does this fit into the Inheritence Model?
    // What you inherit from must come first. You can have as many interfaces as you want after.
    public class PhysicalProductModel : PhysicalProductBase, IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        /// <summary>
        /// ships items to customers.
        /// </summary>
        /// <param name="customer">customer to be shipped to.</param>
        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
