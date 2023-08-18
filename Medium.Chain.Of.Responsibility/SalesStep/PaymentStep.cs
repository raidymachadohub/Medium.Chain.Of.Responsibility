using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler;

namespace Medium.Chain.Of.Responsibility.SalesStep;

public class PaymentStep : StoreHandler
{
    public override object Handle(StoreSequencial request)
    {
        if (request == StoreSequencial.Payment)
        {
            Payment();
        }
        return base.Handle(request);
    }

    private static void Payment()
    {
        Console.WriteLine("\nMethod Payment");
    } 
}