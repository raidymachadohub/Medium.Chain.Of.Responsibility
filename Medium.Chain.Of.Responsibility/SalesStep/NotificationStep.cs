using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler;

namespace Medium.Chain.Of.Responsibility.SalesStep;

public class NotificationStep : StoreHandler
{
    public override object Handle(StoreSequencial request)
    {
        if (request == StoreSequencial.Notification)
        {
            SendNotification();
        }
        return base.Handle(request);
    }

    private static void SendNotification()
    {
        Console.WriteLine("\nMethod Send Notification");
    } 
}