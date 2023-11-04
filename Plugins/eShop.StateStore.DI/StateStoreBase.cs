using eShop.UseCases.PlugInInterfaces.StateStore;
using System;

namespace eShop.StateStore.DI
{
    public class StateStoreBase : IStateStore
    {
        protected Action listeners;
        public void AddStateChangeListener(Action linear){
            this.listeners += linear;
        }
        public void RemoveStateChangeListener(Action linear){
            this.listeners -= linear;
        }
        public void BroadCastStateChange()
        {
            if (this.listeners != null) this.listeners.Invoke();
        }

        
    }
}
