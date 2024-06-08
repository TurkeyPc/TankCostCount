namespace TankCostCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new MissionTank("旧砲塔", 10, 1);
            var t2 = new MissionTank("クルセイダー", 9, 5);
            var t3 = new MissionTank("ヘッツァー", 9, 10);

            var mt = new MissionTanks(t1, t2, t3);

            mt.PutLog();
        }
    }
}