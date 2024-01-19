namespace banvemaybay.DTO
{
    class SANBAYDTO
    {
        private string _masanbay;
        private string _tensanbay;
        public string MASANBAY
        {
            get { return _masanbay; }
            set { _masanbay = value; }
        }
        public string TENSANBAY
        {
            get { return _tensanbay; }
            set { _tensanbay = value; }
        }
        public SANBAYDTO()
        {
            _masanbay = "";
            _tensanbay = "";

        }
        public SANBAYDTO(string MASANBAY, string TENSANBAY)
        {
            _masanbay = MASANBAY;
            _tensanbay = TENSANBAY;
        }
    }
}
