namespace banvemaybay.DTO
{
    class VAITRODTO
    {
        private string _MAVAITRO;

        private string _TENVAITRO;




        public string MaVaiTro
        {
            get { return _MAVAITRO; }
            set { _MAVAITRO = value; }
        }

        public string TenVaiTro
        {
            get { return _TENVAITRO; }
            set { _TENVAITRO = value; }
        }



        public VAITRODTO()
        {
            _MAVAITRO = "";
            _TENVAITRO = "";



        }
        public VAITRODTO(string MaVaiTro, string TenVaiTro)
        {
            _MAVAITRO = MaVaiTro;
            _TENVAITRO = TenVaiTro;

        }
    }
}
