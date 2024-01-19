namespace banvemaybay.DTO
{
    class USERDTO
    {
        private string _MAHK;
        private string _SDT;

        private string _CMND;

        private string _TEN;

        private string _MaVaiTro;
        private string _password;
        public string Ten
        {
            get { return _TEN; }
            set { _TEN = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string MaVaiTro
        {
            get { return _MaVaiTro; }
            set { _MaVaiTro = value; }
        }
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        public string MAHK
        {
            get { return _MAHK; }
            set { _MAHK = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }


        public USERDTO()
        {
            _SDT = "";
            _TEN = "";
            _CMND = "";
            _MaVaiTro = "";
            _password = "";
            _MAHK = "";
        }
        public USERDTO(string SDT, string CMND, string Ten, string MaVaiTro, string password, string MAHK)
        {
            _SDT = SDT;
            _CMND = CMND;
            _TEN = Ten;
            _MaVaiTro = MaVaiTro;
            _password = password;
            _MAHK = MAHK;

        }
    }
}
