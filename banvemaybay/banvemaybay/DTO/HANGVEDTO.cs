namespace banvemaybay.DTO
{
    class HANGVEDTO
    {
        private string _mahangve;
        private string _tenhangve;


        public string mahangve
        {
            get { return _mahangve; }
            set { _mahangve = value; }
        }
        public string tenhangve
        {
            get { return _tenhangve; }
            set { _tenhangve = value; }
        }

        public HANGVEDTO()
        {
            _mahangve = "";
            _tenhangve = "";

        }
        public HANGVEDTO(string MAHANGVE, string TENHANGVE)
        {
            _mahangve = MAHANGVE;
            _tenhangve = TENHANGVE;

        }
    }
}
