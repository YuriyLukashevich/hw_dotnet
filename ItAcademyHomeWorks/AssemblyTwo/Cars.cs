using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    public class Cars
        //если указать классу Cars параметр internal, то он не будет доступен для класса Audi в другой сборке.
        //Доступ к этому классу будет только в этой сборке
    {
        public int maxSpeedPublic;
        private int maxSpeedPrivate; //нигде не будет доступно, кроме этого класса
        protected int maxSpeedProtected;
        internal void StartEngineInternal()
        {
        }
        protected internal void StartEngineProtectedInternal()
        {        
        }
        private protected void StartEnginePrivateProtected()
        {
        }
    }
}
