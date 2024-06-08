namespace TankCostCount
{
    class Period
    {
        public int st;
        public int en;

        public Period(int st, int en)
        {
            this.st = st;
            this.en = en;
        }

        public bool IsGo(int i)
        {
            return this.st <= i && i <= this.en;
        }

        public override string ToString()
        {
            return $"[{st}-{en}]";
        }
    }
}