using InsuranceQueue.Persistance.Interfaces;

namespace InsuranceQueue.Persistance
{
    public class Client:IClient,IClientGetId
    {
        public Client(int id, string firstName, string secondName)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
        }

        protected int Id { get; set; }
        protected string FirstName { get; set;}
        protected string SecondName { get; set; }
        
        public int GetId() => Id;

        public string GetFirstName() => FirstName;

        public string GetSecondName() => SecondName;

        public void SetId(int id) => Id = id;

        public void SetFirstName(string firstName) => FirstName = firstName;

        public void SetSecondName(string secondName) => SecondName = secondName;
    }
}