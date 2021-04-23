
using Insurance.DTO.DTO;
using AutoMapper;
using Insurance.DAL.Models;

namespace Insurance.DTO.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ContractDTO, Contract>();
        }
    }
}