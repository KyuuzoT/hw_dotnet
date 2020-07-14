using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_3
{
    interface IRepository <T> where T:class
    {
        IEnumerable<T> GetMotorcycles();
        T GetMotorcycleById(Guid ID);
        void CreateMotorcycle(T item);
        void UpdateMotorcycle(T item);
        void DeleteMotorcycle(Guid ID);
        void DeleteMotorcycle(T item);
    }
}
