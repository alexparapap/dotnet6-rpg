using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_rpg.Dtos.Skill;
using dot_rpg.Dtos.Weapon;

namespace dot_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
         public int Id { get; set; }

        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
    }
}