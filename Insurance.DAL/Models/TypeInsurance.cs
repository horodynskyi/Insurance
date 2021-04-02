using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class TypeInsurance:IEntity<int>
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}