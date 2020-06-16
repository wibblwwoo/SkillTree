﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Core
{
    public class Way : Skill
    {
        public Way(string name, string iconPath, string displayName, string tooltip, int level, bool used = false, List<Skill> requirements = null, int chance = 0, int cost = 0, int cooldown = 0) : base(name, iconPath, displayName, tooltip, level, used, requirements, chance, cost, cooldown)
        {
        }
    }
}
