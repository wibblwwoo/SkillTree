﻿using SkillTree.Controls;
using SkillTree.Core;
using SkillTree.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace SkillTree.Player
{
    class SkillPlayer : ModPlayer
    {
        private List<string> ownedSkills = new List<string> { SkillDefinitionLoader.Names.BLOCK, SkillDefinitionLoader.Names.MIGHT, SkillDefinitionLoader.Names.LAYERED_ARMOR };
        private Way currentWay;
        private SkillDefinitionLoader skillDefinitionLoader;
        private PlayerGUI gui;


        public override void OnEnterWorld(Terraria.Player player)
        {
            base.OnEnterWorld(player);
            var mod = ModContent.GetInstance<SkillTreeMod>();
            this.gui = mod.gui;
            this.skillDefinitionLoader = mod.skillDefinitionLoader;
        }
  

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            base.ProcessTriggers(triggersSet);
            ModContent.GetInstance<SkillTreeMod>()?.hotkeyConfiguration.forEach((name, hotkey) =>
            {
                if (hotkey.JustPressed)
                {
                    doHotkeyAction(name);
                }
            });

        }

        private void doHotkeyAction(string name)
        {
            switch (name)
            {
                case HotkeyConfiguration.TOGGLE_UI:
                    ModContent.GetInstance<SkillTreeMod>()?.toggleUI();
                    break;
            }
        }
    }
}