using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Motorcycle
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
