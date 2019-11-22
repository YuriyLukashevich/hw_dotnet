using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hm_09_task1
{
    class MotorcycleRepos : IMotorcycleRepos
    {        
        public static List<Motorcycle> motorcycles = new List<Motorcycle>();
        private static int _id = 1;

        public void GetMotorcycle()
        {
            foreach (var motoModel in motorcycles)
            {
                Console.WriteLine($"{motoModel.Id}) Название мотоцикла: {motoModel.Name};\n" +
                    $"Год производства: {motoModel.Year};\n" +
                    $"Максмальная скорость: {motoModel.MaxSpeed};\n" +
                    $"Вин номер: {motoModel.VinNumber}.");
            }
            Console.WriteLine();
            Logger.Log.Info("Вывод всех мотоциклов");
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            motorcycle.Id = _id;
            _id++;
            motorcycles.Add(motorcycle);
            Logger.Log.Info($"Добавление нового мотоцикла: {motorcycle.Name}");
        }

        public Motorcycle UpdateMotorcycle(Motorcycle motorcycle)
        {
            var moto = motorcycles.SingleOrDefault(id => id.Id == motorcycle.Id);
            Logger.Log.Info($"Обновление мотоцикла №{motorcycle.Id}");
            moto.Name = motorcycle.Name;
            moto.Year = motorcycle.Year;
            moto.MaxSpeed = motorcycle.MaxSpeed;
            moto.VinNumber = motorcycle.VinNumber;
            return moto;
        }

        public void GetMotorcycleByID(int id)
        {
            var moto = motorcycles.SingleOrDefault(item => item.Id == id);
            Console.WriteLine($"{moto.Id}) Название мотоцикла: {moto.Name};\n" +
                    $"Год производства: {moto.Year};\n" +
                    $"Максмальная скорость: {moto.MaxSpeed};\n" +
                    $"Вин номер: {moto.VinNumber}.\n");
            Logger.Log.Info($"GetMotorcycleByID №{moto.Id}");
        }

        public void DeleteMotorcycle(int id)
        {
            var moto = motorcycles.SingleOrDefault(item => item.Id == id);
            motorcycles.Remove(moto);
            Logger.Log.Info($"Удаление мотоцикла №{moto.Id}: {moto.Name}");
        }
    }
}
