using System.Net.Sockets;
using System.Text;

namespace Client
{
    internal static class Program
    {
        const int port = 8888;
        const string address = "127.0.0.1";

        private static TcpClient? client = new TcpClient(address, port);
        private static NetworkStream? stream = client?.GetStream();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        /// <summary>
        /// отправить сообщение
        /// </summary>
        /// <param name="message">сообщение</param>
        public static void SendMessage(string? message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream?.Write(data, 0, data.Length);
        }

        /// <summary>
        /// получить сообщение
        /// </summary>
        /// <returns>сообщение</returns>
        public static string ReceiveMessage()
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
    }
}