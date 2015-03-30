using System.ServiceModel;
using RedPillServiceLibrary.RedPillServiceRef;

namespace RedPillServiceLibrary
{
    [ServiceContract]
    public interface IMyRedPillService : IRedPill
    {
    }
}