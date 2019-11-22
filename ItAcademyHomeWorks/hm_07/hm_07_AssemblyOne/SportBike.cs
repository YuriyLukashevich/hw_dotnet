using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike
    {
        public void DisplaySportBike()
        {
            Motorcycle Sport = new Motorcycle();
            //разделил пустыми строками, чтобы было более понятно, к чему относятся комментарии
            Sport.maxSpeedPublic = 300;

            //Sport.maxSpeedPrivate = 300;  
            //нет доступа, т.к. private доступен только в том же классе

            //не доступа к protected, т.к. нет наследования
            //Sport.maxSpeedProtected = 300;

            //есть доступ, т.к. в той же сборке
            Sport.StartEngineInternal();

            //ProtectedInternal доступен, поскольку совмещенный из двух
            //Protected доступен в производных, а internal из текущей сборки
            Sport.StartEngineProtectedInternal();

            //нет доступа, поскольку не определен в том же классе и данный класс не является производным, который в той же сборке
            //Sport.StartEnginePrivateProtected();
        }
    }
}
