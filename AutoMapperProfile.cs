using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
        }
    }
}