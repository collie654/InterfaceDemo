
namespace DemoLibrary
{
    /// <summary>
    /// To be able to see IDigitalProductModel with IProductModel you can actually implement IProductModel onto this interface
    /// You are adding everything from IProductModel  into IDigitalProductModel 
    /// 
    /// Anything implementing this is also implementing IProductModel
    /// </summary>
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
