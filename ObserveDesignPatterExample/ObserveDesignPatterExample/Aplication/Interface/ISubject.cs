using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesignPatterExample.Aplication.Interface
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void Notify();
    }
}
