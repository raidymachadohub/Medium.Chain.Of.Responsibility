using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler;

namespace Medium.Chain.Of.Responsibility;

public static class StoreClient
{
    public static void Start(StoreHandler handler)
    {
        foreach (var store in System.Enum.GetValues(typeof(StoreSequencial)))
        {
            handler.Handle((StoreSequencial)store);
        }   
    }
}