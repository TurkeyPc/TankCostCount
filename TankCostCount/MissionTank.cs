namespace TankCostCount
{
    class MissionTank
    {
        public string Name;
        public int Cost;
        public int MissionNumber;

        public MissionTank(string name, int cost, int missionNumber)
        {
            this.Name = name;
            this.Cost = cost;
            this.MissionNumber = missionNumber;
        }
    }
}