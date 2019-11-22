using System;
using System.Collections.Generic;
using System.Text;
using AssemblyTwo;

namespace AssemblyOne
{
    class Audi : Cars
    {
        public void DisplayAudi()
        {
            Audi audi = new Audi();
            //разделил пустыми строками, чтобы было более понятно, к чему относятся комментарии
            audi.maxSpeedPublic = 180;

            //maxSpeedPrivate = 180;  
            //нет доступа, т.к. private

            audi.maxSpeedProtected = 180;

            //internal не доступен, т.к. находится в другой сборке
            //StartEngineInternal();

            //ProtectedInternal доступен, поскольку совмещенный из двух
            //Protected доступен в производных
            audi.StartEngineProtectedInternal();

            //не доступен, поскольку есть доступ в текущем классе или производном, который в той же сборке
            //StartEnginePrivateProtected
        }
    }
}
