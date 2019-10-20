using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_09_task1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Logger.InitLogger();
            MotorcycleRepos motorcycleRepos = new MotorcycleRepos();
            Motorcycle moto = new Motorcycle("Java", 1985, 120, "TLJ 638");
            Motorcycle moto1 = new Motorcycle("Suzuki", 1999, 250, "JS1VP53A3");
            motorcycleRepos.AddMotorcycle(moto);
            motorcycleRepos.AddMotorcycle(moto1);
            motorcycleRepos.GetMotorcycle();
            //get by id
            motorcycleRepos.GetMotorcycleByID(1);
            //update
            moto1.Name = "BMW";
            moto1.VinNumber = "WBABT31060L";
            motorcycleRepos.UpdateMotorcycle(moto1);
            motorcycleRepos.GetMotorcycle();
            //delete by id
            motorcycleRepos.DeleteMotorcycle(2);
            motorcycleRepos.GetMotorcycle();
            Console.ReadKey();
        }
    }
}
