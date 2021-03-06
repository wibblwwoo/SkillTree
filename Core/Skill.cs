﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Core
{
    public class Skill
    {
        public readonly string name;
        public readonly string iconPath;
        public readonly string displayName;
        public readonly string tooltip;
        public readonly int cost;
        public readonly int cooldown;
        public bool used = false;
        public readonly int chance;
        public readonly int level;
        public readonly List<Skill> requirements;

        public Skill(string name, string iconPath, string displayName, string tooltip, int level, bool used = false, List<Skill> requirements = null, int chance = 0, int cost = 0, int cooldown = 0)
        {
            this.name = name;
            this.iconPath = iconPath;
            this.displayName = displayName;
            this.tooltip = tooltip;
            this.cost = cost;
            this.cooldown = cooldown;
            this.used = used;
            this.chance = chance;
            this.level = level;
            if (requirements == null)
            {
                this.requirements = new List<Skill>();
            }
            else
            {
                this.requirements = requirements;
            }
        }

        public static Skill blankSkill()
        {
            return new Skill("", "", "", "", 0);
        }
    }
}
