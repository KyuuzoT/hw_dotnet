using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_3
{
    interface IRepository <T> where T:class
    {
        IEnumerable<T> GetMotorcycles();
        T GetMotorcycleByIndex(int id);
        T GetMotorcycleById(Guid ID);
        void CreateMotorcycle(T item);
        void UpdateMotorcycle(T item);
        void DeleteMotorcycle(int id);
        void DeleteMotorcycle(T item);
    }
}
