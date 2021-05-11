using System;

namespace Front_endTemplate.Data
{
    public class ContractModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Risk { get; set; }
        public int Tariff { get; set; }
        public int TypeInsurance { get; set; }
        public int Branch { get; set; }
        public int Agent { get; set; }
    }
}