using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_09_task1
{
    interface IMotorcycleRepos
    {
        void GetMotorcycle();
        void AddMotorcycle(Motorcycle motorcycle);
        Motorcycle UpdateMotorcycle(Motorcycle motorcycle);
        void GetMotorcycleByID(int id);
        void DeleteMotorcycle(int id);
    }
}
