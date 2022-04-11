using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DTO
{
    class HocphanDTO
    {
        public string Mahocphan { get; set; }
        public string Tenhocphan { get; set; }
        public int Sotinchi { get; set; }
        public HocphanDTO() { }
        public HocphanDTO(string _mahocphan, string _tenhocphan, int _sotinchi)
        {
            this.Mahocphan = _mahocphan;
            this.Tenhocphan = _tenhocphan;
            this.Sotinchi = _sotinchi;
        }
    }
}
