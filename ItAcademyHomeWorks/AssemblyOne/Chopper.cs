using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Chopper : Motorcycle
    {
        public void DisplayChopper()
        {
            Chopper harley = new Chopper();
            //разделил пустыми строками, чтобы было более понятно, к чему относятся комментарии
            harley.maxSpeedPublic = 250;

            //harley.maxSpeedPrivate = 250;  
            //нет доступа, т.к. private доступен только в том же классе

            harley.maxSpeedProtected = 250;

            //есть доступ, т.к. в той же сборке
            harley.StartEngineInternal();

            //ProtectedInternal доступен, поскольку совмещенный из двух
            //Protected доступен в производных
            harley.StartEngineProtectedInternal();

            //есть доступ, поскольку есть доступ в текущем классе или производном, который в той же сборке
            harley.StartEnginePrivateProtected();
        }
    }
}
