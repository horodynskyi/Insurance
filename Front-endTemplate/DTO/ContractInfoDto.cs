using System;

namespace Front_endTemplate.DTO
{
    public class ContractInfoDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double Risk { get; set; }
        public double Tariff { get; set; }
        public string TypeInsurance { get; set; }
        public string Status { get; set; }
        public string Agent { get; set; }
    }
}