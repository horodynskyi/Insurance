namespace InsuranceQueue.Persistance.Interfaces
{
    public interface IClient
    {
       
        public int GetId();

        public string GetFirstName();

        public string GetSecondName();

        public void SetId(int id);

        public void SetFirstName(string firstName);

        public void SetSecondName(string secondName);
    }
}