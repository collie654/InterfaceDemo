
namespace DemoLibrary
{

    public interface IProductModel
    {
        // Can't have public Access Modifier because everything in interfaces are public. Because this is a contract. These are the things this class will have.
        // These are called signature lines. 

        // property signature (it's name, what it takes in, what it returns).
        string Title { get; set; }

        // property signature
        bool HasOrderBeenCompleted { get; }

        /// <summary>
        /// ships items to customers.
        /// method signature 
        /// </summary>
        /// <param name="customer">customer to be shipped to.</param>
        void ShipItem(CustomerModel customer);
    }
}
