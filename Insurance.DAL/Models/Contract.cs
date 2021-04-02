using System;
using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Contract:IEntity<int>
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public int riskId { get; set; }
        public int tariffId { get; set; }
        public int typeInsuranceId { get; set; }
        public int branchId { get; set; }
        public int agentId { get; set; }
    }
}