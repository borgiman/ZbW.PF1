namespace MB08.A12_2
{
    public class Digit
    {
        private int value;
        public int Limit { get; set; }
        public int Value
        {
            get { return value; }
            set
            {
                if ((value >= 0) && (value < Limit))
                    this.value = value;
            }
        }
        public Digit(int limit)
        {
            Limit = limit;
            Value = 0;
        }
        public string GetValueAsString()
        {
            return value < 10 ? "0" + value : "" + value;
        }
        public void Increase()
        {
            value = (value + 1) % Limit;
        }
    }
}