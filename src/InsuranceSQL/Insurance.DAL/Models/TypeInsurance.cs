using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class TypeInsurance:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}