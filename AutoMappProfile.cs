using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dot_rpg.Dtos.Character;
using dot_rpg.Dtos.Skill;
using dot_rpg.Dtos.Weapon;

namespace dot_rpg
{
    public class AutoMappProfile : Profile
    {
        public AutoMappProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            
        }
    }
}