using DIDemoSite.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DIDemoSite.Services
{
    public class DataRepo : IDataRepo
    {
        List<IDataStruct> data=new List<IDataStruct>();

        public DataRepo()
        {
            foreach (string name in new List<string>() { "DataOb1", "DataOb2", "DataOb3", "DataOb4" })
            {
                data.Add(new DataStruct() { Name = name });
            }

        }
        public List<IDataStruct> GetData()
        {
            return data;
        }
        public void SetData(IDataStruct s)
        {
            data.Append(s);
        }

    }

    public class StrictDataRepo : IDataRepo
    {

        List<IDataStruct> data = new List<IDataStruct>();
        ModelBuilder _modelBuilder;
        public StrictDataRepo(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            foreach (string name in new List<string>() { "DataOb1", "DataOb2", "DataOb3", "DataOb4" })
            {
                data.Add(modelBuilder.GetData(name));
            }

        }

        public List<IDataStruct> GetData()
        {
            return data ;
        }

        public void SetData(IDataStruct s)
        {
            data.Append(s);
        }
    }


    public class DataStruct : IDataStruct
    {
        public string Name { get; set; }
    }

    public class DataStructNew : IDataStruct
    {
        string _name;
        public string Name { get => _name; set => _name=value.ToUpper(); }
    }
}
