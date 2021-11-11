using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternWindows
{
    public interface IDataAccess
    {
        public void LoadData();
        public void SaveData();

    }
}
