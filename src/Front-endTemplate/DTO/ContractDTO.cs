using System;

namespace Front_endTemplate.DTO
{
    public class ContractDTO
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int RiskId { get; set; }
        public int TariffId { get; set; }
        public int TypeInsuranceId { get; set; }
        public int BranchId { get; set; }
        public int AgentId { get; set; }
    }
}