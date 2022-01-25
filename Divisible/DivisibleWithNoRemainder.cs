namespace Divisible
{
    public class DivisibleWithNoRemainder
    {

        private int _start, _end, _divider, count;

        public int Start { get => _start; set => _start = value; }
        public int End { get => _end; set => _end = value; }
        public int Divider { get => _divider; set => _divider = value; }
        public int Count
        {
            get
            {

                return Math.Abs((Start - End) / Divider);
            }
        }

        public DivisibleWithNoRemainder(int start, int end, int divider)
        {
            if (divider > end)
                throw new ArgumentException(nameof(divider), "Divider is greater than End.");
            if (divider <= 0)
                throw new ArgumentException(nameof(divider), "Divider is equal or lesser than 0.");
            Start = start;
            End = end;
            Divider = divider;
        }

        public string GetNumbersInRange()
        {
            string output = "";
            for (int i = Start; i <= End; i++)
            {
                if (i % Divider != 0) continue;
                output += i != End - 1 ? $"{i} | " : $"{i}";
            }
            return output;
        }

        public override string ToString()
        {
            return $"Start is {Start}\nEnd is {End}\nInterval between numbers is {Divider}";
        }
    }

}