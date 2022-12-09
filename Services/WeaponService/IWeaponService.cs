using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_rpg.Dtos.Character;
using dot_rpg.Dtos.Weapon;

namespace dot_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}