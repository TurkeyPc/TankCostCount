namespace TankCostCount
{
    class MissionTanks
    {
        private readonly MissionTank[] values;

        public MissionTanks(params MissionTank[] p)
        {
            this.values = p;
        }

        public MissionTanks(IEnumerable<MissionTank> values)
        {
            this.values = values.ToArray();
        }

        public void PutLog()
        {
            var maxpattern = AllPattern().OrderByDescending(_ => _.SumPoint()).First();

            maxpattern.PutLog();
        }

        private IEnumerable<TankAndPeriods> AllPattern()
        {
            var t1period = new Periods();

            foreach (var item1 in t1period.all)
            {
                foreach (var item2 in t1period.all)
                {
                    foreach (var item3 in t1period.all)
                    {
                        var pattern = new TankAndPeriods();
                        pattern.Add(new TankAndPeriod(values[0], item1));
                        pattern.Add(new TankAndPeriod(values[1], item2));
                        pattern.Add(new TankAndPeriod(values[2], item3));

                        yield return pattern;
                    }
                }
            }
        }

        public CalcPointResult CalcPoint(int i)
        {
            const int TankMax = 5;
            const int MinimamTankCost = 2;

            int costPoint
                = 100
                - (values.Sum(_ => _.Cost) + (TankMax - values.Length) * MinimamTankCost);

            return new CalcPointResult()
            {
                CostPoint = costPoint,
                MissionPoint = values.Count(_ => _.MissionNumber == i) * 100,
                NoChangePoint = 0,
                Name = string.Join("", values.Select(_ => _.Name)),
            };
        }
    }
}