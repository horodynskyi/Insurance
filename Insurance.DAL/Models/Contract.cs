using System;
using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Contract:IEntity<int>
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Risk Risk { get; set; }
        public Tariff Tariff { get; set; }
        public TypeInsurance TypeInsurance { get; set; }
        public Branch Branch { get; set; }
        public Agent Agent { get; set; }
    }
}