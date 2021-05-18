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
                        }))
                .ForMember(dest => dest.Status,
                    map => map.MapFrom(
                        source => new Status
                        {
                            Id = source.StatusId
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
            
         
            
            CreateMap<TerminatedContract, TerminatedContractDTO>()
                .ForMember(dest => dest.ContractId,
                    map =>
                        map.MapFrom(source =>source.Contract.Id))
                .ForMember(dest => dest.ReasonId,
                    map =>
                        map.MapFrom(source => source.Reason.Id));
            
            CreateMap<Contract, ContractDTO>()
                .ForMember(e => e.AgentId,
                    map => map.MapFrom(src => src.Agent.Id))
                .ForMember(e => e.RiskId,
                    map => map.MapFrom(src => src.Risk.Id))
                .ForMember(e => e.TariffId,
                    map => map.MapFrom(src => src.Tariff.Id))
                .ForMember(e => e.AgentId,
                    map => map.MapFrom(src => src.TypeInsurance.Id))
                .ForMember(e => e.StatusId,
                    map => map.MapFrom(src => src.Status.Id));;


            CreateMap<StatusDTO, Status>()
                .ForMember(dest => dest.Reason,
                    map =>map.MapFrom(source => new Reason()
                    {
                        Id = source.ReasonId
                    }));

            CreateMap<Status, StatusDTO>()
                .ForMember(e => e.ReasonId,
                    map => map.MapFrom(src => src.Reason.Id));
            
            
            CreateMap<AgentDTO, Agent>()
                .ForMember(dest=>dest.Branch,
                map=>map.MapFrom(s => new Branch()
                {
                    Id = s.BranchId
                }));
            CreateMap<Agent, AgentDTO>()
                .ForMember(dest =>dest.BranchId,
                    map => map.MapFrom(s =>s.Branch.Id));
            
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