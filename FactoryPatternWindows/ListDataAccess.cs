using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternWindows
{
    class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading this data from List Data");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Data database.");
        }
    }
}
