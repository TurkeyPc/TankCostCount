namespace TankCostCount
{
    class CalcPointResult
    {
        public int CostPoint;
        public int MissionPoint;
        public string Name;
        public int NoChangePoint;

        public int Sum => this.CostPoint + this.MissionPoint + this.NoChangePoint;
    }
}