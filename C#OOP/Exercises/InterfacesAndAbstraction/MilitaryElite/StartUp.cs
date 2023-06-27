using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myArmy = new List<ISoldier>();

            while (input != "End")
            {
                var soldierInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                var specialisation = soldierInfo[0];
                var id = int.Parse(soldierInfo[1]);
                var firstName = soldierInfo[2];
                var lastName = soldierInfo[3];
                var salary = 0m;
                var corps = "";

                if (specialisation == "Private")
                {
                    salary = decimal.Parse(soldierInfo[4]);
                    var @private = new Private(id, firstName, lastName, salary);

                    myArmy.Add(@private);
                }
                else if (specialisation == "LieutenantGeneral")
                {
                    salary = decimal.Parse(soldierInfo[4]);

                    var privateIds = soldierInfo.Skip(5).Select(int.Parse).ToList();
                    var privates = new List<IPrivate>();

                    privateIds.ForEach(id =>
                    {
                        var currentSoldier = (IPrivate)myArmy.FirstOrDefault(s => s.Id == id);

                        if (currentSoldier != null)
                        {
                            privates.Add(currentSoldier);
                        }
                    });

                    var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary, privates);

                    myArmy.Add(lieutenantGeneral);
                }
                else if (specialisation == "Engineer")
                {
                    salary = decimal.Parse(soldierInfo[4]);
                    corps = soldierInfo[5];

                    if (corps == Corps.Airforces.ToString() || corps == Corps.Marines.ToString())
                    {
                        var repairsInfo = soldierInfo.Skip(6).ToList();
                        var repairs = new List<IRepair>();

                        if (repairsInfo.Count > 0)
                        {
                            for (int i = 0; i <= repairsInfo.Count - 1; i += 2)
                            {
                                var repairPart = repairsInfo[i];
                                var repairHours = int.Parse(repairsInfo[i + 1]);
                                var repair = new Repair(repairPart, repairHours);
                                repairs.Add(repair);
                            }
                        }

                        var engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        myArmy.Add(engineer);
                    }
                }
                else if (specialisation == "Commando")
                {
                    salary = decimal.Parse(soldierInfo[4]);
                    corps = soldierInfo[5];

                    if (corps == Corps.Airforces.ToString() || corps == Corps.Marines.ToString())
                    {
                        var missionsInfo = soldierInfo.Skip(6).ToList();
                        var missions = new List<IMission>();

                        if (missionsInfo.Count > 0)
                        {
                            for (int i = 0; i <= missionsInfo.Count - 1; i += 2)
                            {
                                var missionName = missionsInfo[i];
                                var missionState = missionsInfo[i + 1];

                                if (missionState == MissionState.inProgress.ToString() || missionState == MissionState.Finished.ToString())
                                {
                                    var mission = new Mission(missionName, missionState);
                                    missions.Add(mission);
                                }
                            }
                        }

                        var commando = new Commando(id, firstName, lastName, salary, corps, missions);
                        myArmy.Add(commando);
                    }
                }
                else if (specialisation == "Spy")
                {
                    var codeNumber = int.Parse(soldierInfo[4]);

                    var spy = new Spy(id, firstName, lastName, codeNumber);
                    myArmy.Add(spy);
                }

                input = Console.ReadLine();
            }

            myArmy.ForEach(s => Console.WriteLine(s));
        }
    }
}