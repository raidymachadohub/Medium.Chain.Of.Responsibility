using Medium.Chain.Of.Responsibility;
using Medium.Chain.Of.Responsibility.SalesStep;

var product = new ProductStep();

product.SetNext(new NotificationStep())
       .SetNext(new CustomerStep())
       .SetNext(new PaymentStep());

StoreClient.Start(product);