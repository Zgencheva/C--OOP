﻿using System;
using System.Collections.Generic;
using System.Text;

using MilitaryElite2.Models;

using MilitaryElite2.Enumerations;

namespace MilitaryElite2.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public ICollection<Repair> Repairs { get; set; }
    }
}
