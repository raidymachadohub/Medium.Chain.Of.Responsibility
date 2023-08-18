using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler;

namespace Medium.Chain.Of.Responsibility.SalesStep;

public class CustomerStep : StoreHandler
{
    public override object Handle(StoreSequencial request)
    {
        if (request == StoreSequencial.Customer)
        {
            ValidateAddress();
        }

        return base.Handle(request);
    }

    private static void ValidateAddress()
    {
        Console.WriteLine("\nMethod Validate Address");
    }
}