using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aislaba1
{
    public class StudentsRow
    {
        public string id { get; set; }
        public string fio { get; set; }
        public string speciality { get; set; }
        public string group { get; set; }

        public StudentsRow(string id, string fio, string speciality, string group)
        {
            this.id = id;
            this.fio = fio;
            this.speciality = speciality;
            this.group = group;
        }
    }
}
