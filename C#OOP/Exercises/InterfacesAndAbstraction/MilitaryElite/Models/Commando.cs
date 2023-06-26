﻿using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : ISoldier, IPrivate, ISpecialisedSolider, ICommando
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Corps { get; set; }
        public List<IMission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            Missions = new List<IMission>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            Missions.ForEach(m => sb.AppendLine(m.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
