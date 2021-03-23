using System;
using System.Collections.Generic;
using System.Text;

namespace Airport_Baggage
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            throw new NotImplementedException();
        }
    }
}
