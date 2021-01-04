using System.Collections.Generic;

namespace DIDemoSite.Services
{
    public interface IDataRepo
    {
        List<IDataStruct> GetData();
        void SetData(IDataStruct s);
    }
}