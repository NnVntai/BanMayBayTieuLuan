using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banvemaybay.DTO
{
    class QUYDINHDTO
    {
        private string _SOLUONGSANBAY;

        private string _THOIGIANBAYTOITHIEU;

        private string _SOSANBAYTOIDA;
        private string _THOIGIANDUNGTOITHIEU;
        private string _THOIGIANDUNGTOIDA;
        private string _THOIGIANCHAMNHATDATVE;
        private string _THOIGIANCHAMNHATHUYVE;
        public string SOLUONGSANBAY
        {
            get { return _SOLUONGSANBAY; }
            set { _SOLUONGSANBAY = value; }
        }
        public string THOIGIANBAYTOITHIEU
        {
            get { return _THOIGIANBAYTOITHIEU; }
            set { _THOIGIANBAYTOITHIEU = value; }
        }
        public string SOSANBAYTOIDA
        {
            get { return _SOSANBAYTOIDA; }
            set { _SOSANBAYTOIDA = value; }
        }

        public string THOIGIANDUNGTOITHIEU
        {
            get { return _THOIGIANDUNGTOITHIEU; }
            set { _THOIGIANDUNGTOITHIEU = value; }
        }
        public string THOIGIANDUNGTOIDA
        {
            get { return _THOIGIANDUNGTOIDA; }
            set { _THOIGIANDUNGTOIDA = value; }
        }
        public string THOIGIANCHAMNHATDATVE
        {
            get { return _THOIGIANCHAMNHATDATVE; }
            set { _THOIGIANCHAMNHATDATVE = value; }
        }
        public string THOIGIANCHAMNHATHUYVE
        {
            get { return _THOIGIANCHAMNHATHUYVE; }
            set { _THOIGIANCHAMNHATHUYVE = value; }
        }

        public QUYDINHDTO()
        {
                _SOLUONGSANBAY="";


         _THOIGIANBAYTOITHIEU="";

        _SOSANBAYTOIDA="";
       _THOIGIANDUNGTOITHIEU = "";
        _THOIGIANDUNGTOIDA = "";
      _THOIGIANCHAMNHATDATVE = "";
   _THOIGIANCHAMNHATHUYVE="";
    }
        public QUYDINHDTO(string SOLUONGSANBAY, string THOIGIANBAYTOITHIEU, string SOSANBAYTOIDA, string THOIGIANDUNGTOITHIEU, string THOIGIANDUNGTOIDA, string THOIGIANCHAMNHATDATVE,string THOIGIANCHAMNHATHUYVE)
        {
            _SOLUONGSANBAY = SOLUONGSANBAY;


            _THOIGIANBAYTOITHIEU = THOIGIANBAYTOITHIEU;

            _SOSANBAYTOIDA = SOSANBAYTOIDA;
            _THOIGIANDUNGTOITHIEU = THOIGIANDUNGTOITHIEU;
            _THOIGIANDUNGTOIDA = THOIGIANDUNGTOIDA;
            _THOIGIANCHAMNHATDATVE = THOIGIANCHAMNHATDATVE;
            _THOIGIANCHAMNHATHUYVE = THOIGIANCHAMNHATHUYVE;
        }
    }
}
