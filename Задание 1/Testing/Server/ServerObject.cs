using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace Server
{
    public class ServerObject
    {
        private TcpListener listener = new TcpListener(IPAddress.Any, 8888); // сервер для прослушивания

        public List<Question> questions = new List<Question>(); // тест


        public void Process()
        {
            try
            {
                listener?.Start();

                GenerateTest(10);
                LoadDatabase();

                Console.WriteLine("The server is running. Waiting for connections...");

                while (true)
                {
                    TcpClient? client = listener?.AcceptTcpClient();

                    ClientObject clientObject = new ClientObject(client, this);

                    Thread thread = new Thread(new ThreadStart(clientObject.Process));
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        private void Disconnect()
        {
            foreach (ClientObject client in Program.clients)
            {
                client.Close();
            }

            listener?.Stop();
            Environment.Exit(0);
        }

        private void GenerateTest(int questionsCount)
        {
            questions.Clear();

            for (int i = 0; i < questionsCount; i++)
            {
                Question question = new Question(i.ToString() + " + 10", (i + 10).ToString());
                questions.Add(question);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));

            using (FileStream fs = new FileStream("Database.xml", FileMode.Create))
            {
                serializer.Serialize(fs, questions);
            }
        }

        private void LoadDatabase()
        {
            questions.Clear();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));

            using (FileStream fs = new FileStream("Database.xml", FileMode.OpenOrCreate))
            {
                questions = serializer.Deserialize(fs) as List<Question>;
            }
        }
    }
}
