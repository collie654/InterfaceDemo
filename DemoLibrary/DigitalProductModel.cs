using System;

namespace DemoLibrary
{
    /// <summary>
    /// Say we want to access TotalDownloadsLeft in other places of code. We can create an interface for it only containing that variable. 
    ///     Heres the problem. If you access something as that interface, you will only have access to TotalDownloadsLeft, nothing from IProductModel. Move to IDigitalProductModel
    ///     
    /// This is indirectly implementing IProductModel through IDigitalProductModel
    /// </summary>
   public class DigitalProductModel : IDigitalProductModel
    {
        public string  Title { get; set; }

        // we've added a private set. An interface forces you to implement what's in the contract, but doesn't stop you from adding more.
        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
