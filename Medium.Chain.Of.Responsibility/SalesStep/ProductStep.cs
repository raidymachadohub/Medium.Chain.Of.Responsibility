using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler;

namespace Medium.Chain.Of.Responsibility.SalesStep;

public class ProductStep : StoreHandler
{
    public override object Handle(StoreSequencial request)
    {
        if (request == StoreSequencial.Product)
        {
            StockProduct();
        }

        return base.Handle(request);
    }

    private static void StockProduct()
    {
        Console.WriteLine("\nMethod Stock Product");
    }
}