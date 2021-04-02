using System;
using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Contract:IEntity<int>
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public Risk risk { get; set; }
        public Tariff tariff { get; set; }
        public TypeInsurance typeInsurance { get; set; }
        public Branch branch { get; set; }
        public Agent agent { get; set; }
    }
}