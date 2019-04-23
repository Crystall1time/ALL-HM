using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_11
{
    interface IRepository
    {
        void CreateMotorcycle(Motorcycle motorcycle);
        List<Motorcycle> GetMotorcycles();
        Motorcycle GetMotorcycleById(int id);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(Motorcycle motorcycle);
    }
}
