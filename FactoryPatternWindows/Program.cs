using System;

namespace FactoryPatternWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User what database do you want to use: List, SQL, or Mongo");
            string databaseType = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(databaseType);
            data.LoadData();
            data.SaveData();
            Console.ReadLine();
        }
    }
}
