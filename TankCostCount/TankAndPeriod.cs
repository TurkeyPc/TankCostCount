namespace TankCostCount
{
    class TankAndPeriod
    {
        public MissionTank t;
        public Period p;

        public TankAndPeriod(MissionTank t, Period p)
        {
            this.t = t;
            this.p = p;
        }

        public override string ToString()
        {
            return $"{t.Name}:{p}";
        }
    }
}