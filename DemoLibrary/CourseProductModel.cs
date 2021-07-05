using System;

/// <summary>
/// creating a new ProductModel is as simple as creating it, 
/// implementing the interface (CTRL + .),
/// and adding the functionality to those variables/methods
/// 
/// </summary>
namespace DemoLibrary
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Added the { Title } course to { customer.FirstName}'s account.");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
