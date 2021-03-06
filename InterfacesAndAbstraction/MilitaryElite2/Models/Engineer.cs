﻿using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite2.Contracts;
using MilitaryElite2.Enumerations;

namespace MilitaryElite2.Models
{
    public class Engineer : SpecialSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum soldierCorpEnum) 
            : base(id, firstName, lastName, salary, soldierCorpEnum)
        {
            this.Repairs = new List<Repair>();
        }

        public ICollection<Repair> Repairs { get; set; }

        public void AddRepair(Repair repairPart)
        {
            this.Repairs.Add(repairPart);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.soldierCorpEnum.ToString()}");
            sb.AppendLine("Repairs:");
            if (this.Repairs.Count != 0)
            {
                foreach (var item in this.Repairs)
                {
                    sb.AppendLine("  " + item.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
