namespace DemoLibrary
{
    /// <summary>
    /// Just created to demonstrate the shortcut for creating an interface from an existing class.
    /// 
    /// have cursor clicked on the class name
    /// CTRL + .
    /// extract interface
    /// </summary>
    public interface ICustomerModel
    {
        string City { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string StreetAddress { get; set; }
    }
}