namespace banvemaybay.DTO
{
    class CHITIETSLDTO
    {
        private string _MASOLUONGGHE;
        private string _MACHUYENBAY;
        private string _MAHANGVE;
        private string _SOLUONG;
        public string MASOLUONGGHE
        {
            get { return _MASOLUONGGHE; }
            set { _MASOLUONGGHE = value; }
        }
        public string MACHUYENBAY
        {
            get { return _MACHUYENBAY; }
            set { _MACHUYENBAY = value; }
        }
        public string MAHANGVE
        {
            get { return _MAHANGVE; }
            set { _MAHANGVE = value; }
        }
        public string SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
        public CHITIETSLDTO()
        {
            _MACHUYENBAY = "";
            _MASOLUONGGHE = "";
            _MAHANGVE = "";
            _SOLUONG = "";
        }
        public CHITIETSLDTO(string MASOLUONGGHE, string MAHANGVE, string MACHUYENBAY, string SOLUONG)
        {
            _MACHUYENBAY = MASOLUONGGHE;
            _MASOLUONGGHE = MAHANGVE;
            _MAHANGVE = MACHUYENBAY;
            _SOLUONG = SOLUONG;
        }
    }
}
