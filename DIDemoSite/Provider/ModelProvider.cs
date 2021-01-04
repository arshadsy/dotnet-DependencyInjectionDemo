using DIDemoSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoSite.Provider
{
    public class ModelBuilder
    {
        public int obVersion;
        public ModelBuilder(int ver)
        {
            obVersion = ver;
        }

        public IDataStruct GetData(params object[] parameters)
        {
            switch (obVersion)
            {
                case 1: return new DataStruct() { Name = parameters[0].ToString() };
                case 2: return new DataStructNew() { Name = parameters[0].ToString() };
                default: return new DataStruct();
            }
        }
    }
}
