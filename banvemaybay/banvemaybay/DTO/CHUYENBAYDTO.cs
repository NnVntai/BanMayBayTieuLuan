namespace banvemaybay.DTO
{
    class CHUYENBAYDTO
    {
        private string _MACHUYENBAY;

        private string _NGAYGIO;

        private string _THOIGIANBAY;
        private string _GIA;
        private string _MASANBAYDI;
        private string _MASANBAYDEN;
        public string MachyenBay
        {
            get { return _MACHUYENBAY; }
            set { _MACHUYENBAY = value; }
        }
        public string MASANBAYDI
        {
            get { return _MASANBAYDI; }
            set { _MASANBAYDI = value; }
        }
        public string MASANBAYDEN
        {
            get { return _MASANBAYDEN; }
            set { _MASANBAYDEN = value; }
        }

        public string NgayGio
        {
            get { return _NGAYGIO; }
            set { _NGAYGIO = value; }
        }
        public string ThoiGian
        {
            get { return _THOIGIANBAY; }
            set { _THOIGIANBAY = value; }
        }
        public string Gia
        {
            get { return _GIA; }
            set { _GIA = value; }
        }

        public CHUYENBAYDTO()
        {
            _MACHUYENBAY = "";
            _THOIGIANBAY = "";
            _NGAYGIO = "";
            _GIA = "";
            _MASANBAYDEN = "";
            _MASANBAYDI = "";
        }
        public CHUYENBAYDTO(string MaChuyenBay, string ThoiGian, string MaSanBayDen, string MaSanBayDi, string NgayGio, string Gia)
        {
            _MACHUYENBAY = MaChuyenBay;
            _GIA = Gia;
            _THOIGIANBAY = ThoiGian;
            _NGAYGIO = NgayGio;
            _MASANBAYDEN = MaSanBayDen;
            _MASANBAYDI = MaSanBayDi;
        }
    }
}
