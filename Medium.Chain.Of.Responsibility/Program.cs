using Medium.Chain.Of.Responsibility;
using Medium.Chain.Of.Responsibility.SalesStep;

var product = new ProductStep();
var customer = new CustomerStep();
var notification = new NotificationStep();
var payment = new PaymentStep();

product.SetNext(notification)
       .SetNext(payment)
       .SetNext(customer);

StoreClient.Start(product);