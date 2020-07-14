using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_12_3
{
    class MotorcycleRepository : IRepository<Motorcycle>
    {
        public MotorcycleRepository()
        {
            GlobalVars.dbList = new List<Motorcycle>();
        }

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return GlobalVars.dbList;
        }

        public Motorcycle GetMotorcycleById(int index)
        {
            return GlobalVars.dbList[index];
        }

        public void CreateMotorcycle(Motorcycle item)
        {
            GlobalVars.dbList.Add(item);
        }

        public void UpdateMotorcycle(Motorcycle item)
        {
            int index = GlobalVars.dbList.FindIndex(mc => mc.ID == item.ID);
            if(GlobalVars.dbList[index] != null)
            {
                GlobalVars.dbList[index] = item;
            }
        }

        public void DeleteMotorcycle(int index)
        {
            Motorcycle moto = GlobalVars.dbList[index];
            if(moto != null)
            {
                GlobalVars.dbList.RemoveAt(index);
            }
        }

        public void DeleteMotorcycle(Motorcycle item)
        {
            Motorcycle moto = GlobalVars.dbList.Find(mc => mc.ID == item.ID);
            if(moto != null)
            {
                GlobalVars.dbList.Remove(item);
            }
        }
    }
}
