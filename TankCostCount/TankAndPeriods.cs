namespace TankCostCount
{
    class TankAndPeriods
    {
        private readonly List<TankAndPeriod> v = new();

        public void Add(TankAndPeriod item)
        {
            v.Add(item);
        }

        public void PutLog()
        {
            Console.WriteLine((string?)string.Join("\r\n", v.Select(_ => _.ToString())) + "\r\n");

            Console.WriteLine("　　　 編,Mis,NoC");
            foreach (var v in kari)
            {
                Console.WriteLine($"{v.Item1:00}回戦,{v.Item2.CostPoint:00},{v.Item2.MissionPoint:000},{v.Item2.NoChangePoint:000}");
            }
            Console.WriteLine($"合計：{SumPoint()}");
        }

        public int SumPoint()
        {
            return this.kari.Sum(_ => _.Item2.Sum);
        }

        private IEnumerable<Tuple<int, CalcPointResult>> kari
        {
            get
            {
                string? maename = null;
                for (int i = 1; i <= 10; i++)
                {
                    var target = new MissionTanks(this.v.Where(_ => _.p.IsGo(i)).Select(_ => _.t));

                    var v = target.CalcPoint(i);

                    v.NoChangePoint = maename != null && maename != v.Name ? 0 : 100;

                    maename = v.Name;

                    yield return new Tuple<int, CalcPointResult>(i, v);
                }
            }
        }
    }
}