namespace banvemaybay.DTO
{
    class DATCHODDTO
    {
        private string _MACHUYENBAY;

        private string _MAPHIEUDATCHO;

        private string _MAHK;
        private string _NGAYDAT;
        private string _MaHangVe;
        public string MachyenBay
        {
            get { return _MACHUYENBAY; }
            set { _MACHUYENBAY = value; }
        }

        public string MaPhieuDatCho
        {
            get { return _MAPHIEUDATCHO; }
            set { _MAPHIEUDATCHO = value; }
        }
        public string MAHK
        {
            get { return _MAHK; }
            set { _MAHK = value; }
        }
        public string NgayDat
        {
            get { return _NGAYDAT; }
            set { _NGAYDAT = value; }
        }
        public string MahangVE
        {
            get { return _MaHangVe; }
            set { _MaHangVe = value; }
        }

        public DATCHODDTO()
        {
            _MACHUYENBAY = "";
            _NGAYDAT = "";
            _MAHK = "";
            _MAPHIEUDATCHO = "";
            _MaHangVe = "";
        }
        public DATCHODDTO(string MaChuyenBay, string NgayDat, string MAHK, string MaPhieuDatCho, string MaHangVe)
        {
            _MACHUYENBAY = MaChuyenBay;
            _NGAYDAT = NgayDat;
            _MAHK = MAHK;
            _MaHangVe = MaHangVe;
            _MAPHIEUDATCHO = MaPhieuDatCho;

        }
    }
}
