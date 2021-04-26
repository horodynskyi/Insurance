using Insurance.DTO.DTO;
using AutoMapper;
using Insurance.DAL.Models;

namespace Insurance.DTO.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ContractDTO, Contract>()
                .ForMember(dest => dest.Agent,
                    map => map.MapFrom(
                        source => new Agent
                        {
                            Id = source.AgentId
                        }))
                .ForMember(dest => dest.Branch,
                    map => map.MapFrom(
                        source => new Branch
                        {
                            Id = source.BranchId
                        }))
                .ForMember(dest => dest.Risk,
                    map => map.MapFrom(
                        source => new Risk
                        {
                            Id = source.RiskId
                        }))
                .ForMember(dest => dest.Tariff,
                    map => map.MapFrom(
                        source => new Tariff
                        {
                            Id = source.TariffId
                        }))
                .ForMember(dest => dest.TypeInsurance,
                    map => map.MapFrom(
                        source => new TypeInsurance
                        {
                            Id = source.TypeInsuranceId
                        }));
            ;
            CreateMap<TerminatedContractDto, TerminatedContract>()
                .ForMember(dest => dest.Contract,
                    map =>
                        map.MapFrom(source => new Contract
                        {
                            Id = source.ContractId
                        }))
                .ForMember(dest => dest.Reason,
                    map =>
                        map.MapFrom(source => new Reason
                        {
                            Id = source.ReasonId
                        }));
        }
    }
}