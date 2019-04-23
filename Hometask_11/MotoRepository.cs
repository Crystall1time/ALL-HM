using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_11
{
    class MotoRepository : IRepository
    {
        static List<Motorcycle> motorcycles = new List<Motorcycle>();

        public Motorcycle GetMotorcycleById(int Id)
        {
            Motorcycle resultID = motorcycles.ElementAt(0);
            foreach (var motorcucle in motorcycles)
            {
                if (Id == motorcucle.Id)
                {
                    resultID = motorcucle;
                }
            }
            return resultID;
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            motorcycles.Add(motorcycle);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            int index = 0;
            for (int i = 0; i < motorcycles.Capacity; i++)
            {
                Motorcycle moto = motorcycles.ElementAt(i);
                if (motorcycle == moto)
                {
                    index = i;
                    break;
                }
                motorcycles.ElementAt(index).Id = moto.Id;
                motorcycles.ElementAt(index).Name = moto.Name;
                motorcycles.ElementAt(index).Model = moto.Model;
                motorcycles.ElementAt(index).Year = moto.Year;
                motorcycles.ElementAt(index).Odometr = moto.Odometr;
            }
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            motorcycles.Remove(motorcycle);
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return motorcycles;
        }
    }
}
