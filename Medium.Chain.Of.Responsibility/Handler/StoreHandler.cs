using Medium.Chain.Of.Responsibility.Enum;
using Medium.Chain.Of.Responsibility.Handler.Interfaces;

namespace Medium.Chain.Of.Responsibility.Handler;

public abstract class StoreHandler : IStoreHandler
{
    private IStoreHandler _storeHandler;

    public IStoreHandler SetNext(IStoreHandler storeHandler)
    {
        _storeHandler = storeHandler;

        return storeHandler;
    }

    public virtual object Handle(StoreSequencial request)
    {
        if (_storeHandler is not null)
        {
            return _storeHandler.Handle(request);
        }

        return _storeHandler;
    }
}