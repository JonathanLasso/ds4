internal class Program
{
    private static void Main(String[] args)
    {
        Client client = new Client();
        client.FirstName = "Jonathan";
        client.LastName = "Lasso";
        client.Age = 19;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }

    public class Client
    {
        public int Id
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public ushort Age
        {
            get; set;
        }

        public string GetFullName ()
        {
            return FirstName + " " + LastName;
        }
    }
}