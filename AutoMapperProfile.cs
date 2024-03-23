using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg_net7.Dtos.Fight;
using dotnet_rpg_net7.Dtos.Skill;
using dotnet_rpg_net7.Dtos.Weapon;

namespace dotnet_rpg_net7
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDto>();
            // CreateMap<UpdateCharacterDto, Character>();
        }
    }
}