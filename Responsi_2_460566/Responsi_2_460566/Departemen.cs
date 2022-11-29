using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Responsi_2_460566
{
    internal class Departemen
    {
        // field
        private int id_dep;
        private string nama_dep;
           
        // properties
        public int ID_Dep
        {
            get { return id_dep; }
        }

        public string Nama_Dep
        {
            get { return nama_dep; }
            set { nama_dep = value; }
        }
    }
}
