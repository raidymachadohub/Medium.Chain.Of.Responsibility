using Medium.Chain.Of.Responsibility.Enum;

namespace Medium.Chain.Of.Responsibility.Handler.Interfaces;

public interface IStoreHandler
{
    IStoreHandler SetNext(IStoreHandler storeHandler);
    object Handle(StoreSequencial request);
}