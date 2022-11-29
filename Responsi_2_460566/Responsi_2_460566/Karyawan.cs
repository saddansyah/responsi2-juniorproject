using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2_460566
{
    internal class Karyawan
    {
        // field
        private string id_karyawan;
        private string nama;
        private int id_dep;
        private string nama_dep;    

        // properties
        public string ID_Karyawan
        {
            get { return id_karyawan; }
            set { id_karyawan = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int ID_Dep
        {
            get { return id_dep; }
            set { id_dep = value; }
        }

        public string Nama_Dep
        {
            get { return nama_dep; }
            set { nama_dep = value; }
        }

    }
}
