namespace banvemaybay.DTO
{
    class SANBAYTRUNGGIANDTO
    {
        private string _MASANBAYTRUNGGIAN;
        private string _MACHUYENBAY;
        private string _MASANBAY;
        private string _THOIGIANDUNG;
        public string MASANBAYTRUNGGIAN
        {
            get { return _MASANBAYTRUNGGIAN; }
            set { _MASANBAYTRUNGGIAN = value; }
        }
        public string MACHUYENBAY
        {
            get { return _MACHUYENBAY; }
            set { _MACHUYENBAY = value; }
        }
        public string MASANBAY
        {
            get { return _MASANBAY; }
            set { _MASANBAY = value; }
        }
        public string THOIGIANDUNG
        {
            get { return _THOIGIANDUNG; }
            set { _THOIGIANDUNG = value; }
        }
        public SANBAYTRUNGGIANDTO()
        {
            _MACHUYENBAY = "";
            _MASANBAY = "";
            _MASANBAYTRUNGGIAN = "";
            _THOIGIANDUNG = "";
        }
        public SANBAYTRUNGGIANDTO(string MASANBAYTRUNGGIAN, string MASANBAY, string MACHUYENBAY, string THOIGIANDUNG)
        {
            _MASANBAYTRUNGGIAN = MASANBAYTRUNGGIAN;
            _MACHUYENBAY = MACHUYENBAY;
            _MASANBAY = MASANBAY;
            _THOIGIANDUNG = THOIGIANDUNG;
        }

    }
}
