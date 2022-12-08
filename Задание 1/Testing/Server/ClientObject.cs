using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class ClientObject
    {
        private TcpClient? client;
        private NetworkStream? stream;

        private ServerObject server;

        private int questionNumber = 0;

        public ClientObject(TcpClient? client, ServerObject server)
        {
            this.client = client;

            stream = client?.GetStream();

            Program.clients.Add(this);

            this.server = server;
        }


        public void Process()
        {
            try
            {
                string? name = ReceiveMessage();
                string? message = name + " connected";
                Console.WriteLine(message);

                message = server.questions?[questionNumber].question;
                SendMessage(message);

                while (true)
                {
                    try
                    {
                        string answer = ReceiveMessage();

                        if (string.IsNullOrEmpty(answer))
                            continue;

                        message = name + " : " + answer;
                        Console.WriteLine(message);

                        if (answer == "restart")
                        {
                            questionNumber = 0;
                            Console.WriteLine(name + " restarted the test");

                            message = server.questions?[questionNumber].question;
                        }
                        else if (questionNumber < 10)
                        {
                            if (CheckAnswer(answer))
                                Console.WriteLine(name + " gave the correct answer to question " + questionNumber);
                            else
                                Console.WriteLine(name + " gave an incorrect answer to question " + questionNumber);

                            if (questionNumber < 10)
                                message = server.questions?[questionNumber].question;
                            else
                                message = "Тест пройден!";
                        }
                        else
                            message = "Тест пройден!";

                        SendMessage(message);
                    }
                    catch
                    {
                        message = name + " disconnected";
                        Console.WriteLine(message);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Program.clients.Remove(this);
                Close();
            }
        }

        public void Close()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }

        /// <summary>
        /// отправить сообщение
        /// </summary>
        /// <param name="message">сообщение</param>
        private void SendMessage(string? message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream?.Write(data, 0, data.Length);
        }

        /// <summary>
        /// получить сообщение
        /// </summary>
        /// <returns>сообщение</returns>
        private string ReceiveMessage()
        {
            byte[] data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return builder.ToString();
        }

        /// <summary>
        /// проверка ответа
        /// </summary>
        /// <param name="answer">ответ</param>
        /// <returns>результат проверки</returns>
        private bool CheckAnswer(string answer)
        {
            if (answer == server.questions?[questionNumber].answer)
            {
                questionNumber++;
                return true;
            }

            return false;
        }
    }
}
