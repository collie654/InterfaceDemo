
namespace DemoLibrary
{
    /// <summary>
    /// Shortcut for creating an interface from a class:
    /// 
    /// have cursor clicked on the class name
    /// CTRL + .
    /// extract interface
    /// </summary>
    public class CustomerModel : ICustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
