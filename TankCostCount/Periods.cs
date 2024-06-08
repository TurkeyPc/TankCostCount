namespace TankCostCount
{
    class Periods
    {
        public IEnumerable<Period> all
        {
            get
            {
                yield return new Period(0, 0);


                for (int st = 1; st <= 10; st++)
                {
                    for (int en = st; en <= 10; en++)
                    {
                        yield return new Period(st, en);
                    }
                }
            }
        }
    }
}