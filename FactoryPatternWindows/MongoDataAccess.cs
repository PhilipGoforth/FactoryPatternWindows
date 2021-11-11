using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternWindows
{
    class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from Mongo");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}
