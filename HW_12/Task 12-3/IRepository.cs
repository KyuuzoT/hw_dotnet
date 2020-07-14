using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_3
{
    interface IRepository <T> where T:class
    {
        IEnumerable<T> GetMotorcycles();
        T GetMotorcycleById(int id);
        void CreateMotorcycle(T item);
        void UpdateMotorcycle(T item);
        void DeleteMotorcycle(int id);
        void DeleteMotorcycle(T item);
    }
}
