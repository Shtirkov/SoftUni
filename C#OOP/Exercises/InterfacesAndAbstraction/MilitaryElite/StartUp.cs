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
            var privates = new List<ISoldier>();
            var allSoliders = new List<ISoldier>();

            while (input != "End")
            {
                var data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var soliderType = data[0];

                if (soliderType == "Private")
                {
                    var id = data[1];
                    var firstName = data[2];
                    var lastName = data[3];
                    var salary = decimal.Parse(data[4]);

                    var @private = new Private(id, firstName, lastName, salary);
                    privates.Add(@private);

                    allSoliders.Add(@private);
                }
                else if (soliderType == "LieutenantGeneral")
                {
                    var id = data[1];
                    var firstName = data[2];
                    var lastName = data[3];
                    var salary = decimal.Parse(data[4]);
                    var privateIds = data.Skip(5).ToList();
                    var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    privateIds.ForEach(id =>
                    {
                        var currentPrivate = privates.FirstOrDefault(p => p.Id == id);

                        if (currentPrivate != null)
                        {
                            lieutenantGeneral.Privates.Add((IPrivate)currentPrivate);
                        }
                    });

                   allSoliders.Add(lieutenantGeneral);
                }
                else if (soliderType == "Engineer")
                {
                    var id = data[1];
                    var firstName = data[2];
                    var lastName = data[3];
                    var salary = decimal.Parse(data[4]);
                    var corps = data[5];

                    if (corps == Corpses.Marines.ToString() || corps == Corpses.Airforces.ToString())
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corps);

                        var tasks = data.Skip(6).ToList();

                        if (tasks.Count != 0)
                        {
                            for (int i = 0; i <= tasks.Count / 2; i += 2)
                            {
                                var partName = tasks[i];
                                var hours = int.Parse(tasks[i + 1]);
                                var repair = new Repair(partName, hours);
                                engineer.Repairs.Add(repair);
                            }
                        }

                        allSoliders.Add(engineer);
                    }
                }
                else if (soliderType == "Commando")
                {
                    var id = data[1];
                    var firstName = data[2];
                    var lastName = data[3];
                    var salary = decimal.Parse(data[4]);
                    var corps = data[5];

                    if (corps == Corpses.Marines.ToString() || corps == Corpses.Airforces.ToString())
                    {
                        var comando = new Commando(id, firstName, lastName, salary, corps);

                        var missions = data.Skip(6).ToList();

                        if (missions.Count != 0)
                        {
                            for (int i = 0; i <= missions.Count / 2; i += 2)
                            {
                                var missionName = missions[i];
                                var missionState = missions[i + 1];

                                if (missionState == MissionStates.inProgress.ToString() || missionState == MissionStates.Finished.ToString())
                                {
                                    var mission = new Mission(missionName, missionState);
                                    comando.Missions.Add(mission);
                                }
                            }
                        }                        

                        allSoliders.Add(comando);
                    }
                }
                else if (soliderType == "Spy")
                {
                    var id = data[1];
                    var firstName = data[2];
                    var lastName = data[3];
                    var codeNumber = int.Parse(data[4]);

                    var spy = new Spy(id, firstName, lastName, codeNumber);

                    allSoliders.Add(spy);
                }

                input = Console.ReadLine();
            }

            allSoliders.ForEach(s => Console.WriteLine(s.ToString()));
        }
    }
}