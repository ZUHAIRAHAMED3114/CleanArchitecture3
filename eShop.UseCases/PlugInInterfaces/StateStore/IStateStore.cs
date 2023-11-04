using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.PlugInInterfaces.StateStore
{
    public interface IStateStore
    {
        void AddStateChangeListener(Action linear);
        void RemoveStateChangeListener(Action linear);
        void BroadCastStateChange();
    }
}
