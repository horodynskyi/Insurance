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
            CreateMap<TerminatedContractDTO, TerminatedContract>()
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
            CreateMap<Contract, ContractDTO>()
                .ForMember(e => e.AgentId,
                    map => map.MapFrom(src => src.Agent.Id))
                .ForMember(e => e.BranchId,
                    map => map.MapFrom(src => src.Branch.Id))
                .ForMember(e => e.RiskId,
                    map => map.MapFrom(src => src.Risk.Id))
                .ForMember(e => e.TariffId,
                    map => map.MapFrom(src => src.Tariff.Id))
                .ForMember(e => e.AgentId,
                    map => map.MapFrom(src => src.TypeInsurance.Id));

            CreateMap<AgentDTO, Agent>();
            CreateMap<Agent, AgentDTO>();
            
            CreateMap<BranchDTO, Branch>();
            CreateMap<Branch, BranchDTO>();
            
            CreateMap<ReasonDTO, Reason>();
            CreateMap<Reason, ReasonDTO>();
            
            CreateMap<RiskDTO, Risk>();
            CreateMap<Risk, RiskDTO>();
            
            CreateMap<TariffDTO, Tariff>();
            CreateMap<Tariff, TariffDTO>();
            
            CreateMap<TypeInsuranceDTO, TypeInsurance>();
            CreateMap<TypeInsurance, TypeInsuranceDTO>();
        }
    }
}