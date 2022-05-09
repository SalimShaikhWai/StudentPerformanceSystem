using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.CollectionOfInterfaces
{
    public interface Icrud
    {
        public void AddOrEdit(string operation = "insert");
        public void GetAllData();
        public void GetSingleData();
        public void Delete();
        public void Header();
        public void ShowDataOneByOne();
        public void Edit();
    }
}
