namespace banvemaybay.DTO
{
    class VECHUYENBAYDTO
    {
        private string _mavechuyenbay;
        private string _machuyenbay;
        private string _MAHK;
        private string _MahangVe;

        public string mavechuyenbay
        {
            get { return _mavechuyenbay; }
            set { _mavechuyenbay = value; }
        }
        public string machuyenbay
        {
            get { return _machuyenbay; }
            set { _machuyenbay = value; }
        }
        public string MahangVe
        {
            get { return _MahangVe; }
            set { _MahangVe = value; }
        }
        public string MAHK
        {
            get { return _MAHK; }
            set { _MAHK = value; }
        }
        public VECHUYENBAYDTO()
        {
            _machuyenbay = "";
            _mavechuyenbay = "";
            _MAHK = "";
            _MahangVe = "";

        }
        public VECHUYENBAYDTO(string MAVECHUYENBAY, string MAHK, string MACHUYENBAY, string MahangVe)
        {
            _machuyenbay = MACHUYENBAY;
            _mavechuyenbay = MAVECHUYENBAY;
            _MAHK = MAHK;
            _MahangVe = MahangVe;
        }
    }
}
