namespace Server
{
    public class Program
    {
        public static List<ClientObject> clients = new List<ClientObject>(); // все подключения

        static void Main(string[] args)
        {
            ServerObject server = new ServerObject();
            Thread thread = new Thread(new ThreadStart(server.Process));
            thread.Start();
        }
    }
}
