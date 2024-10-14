namespace MB08.A12_2
{
    public class Clock
    {
        private readonly Digit hour;
        private readonly Digit minute;
        public string Hour
        {
            get { return hour.GetValueAsString(); }
        }
        public string Minute
        {
            get { return minute.GetValueAsString(); }
        }
        public Clock() : this(0, 0) { }
        public Clock(int hour, int minute)
        {
            this.hour = new Digit(24);
            this.minute = new Digit(60);
            SetTime(hour, minute);
        }
        public void SetTime(int hour, int minute)
        {
            this.hour.Value = hour >= 0 && hour <= this.hour.Limit ? hour :
                throw new ArgumentException("Value to big");
            this.minute.Value = minute >= 0 && minute <= this.minute.Limit ? minute :
                throw new ArgumentException("Value to big");
        }
        public void TriggerClockSignal()
        {
            minute.Increase();
            if (minute.Value == 0)
                hour.Increase();
        }
    }
}