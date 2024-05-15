using System;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            // Địa chỉ IP của máy tính server (máy tính đích)
            string serverIp = "192.168.11.102"; // Địa chỉ IP của máy tính đích

            // Cổng kết nối
            int port = 9999;

            // Tạo kết nối đến server
            TcpClient client = new TcpClient(serverIp, port);
            Console.WriteLine("Connected to server.");

            // Lấy NetworkStream để gửi và nhận dữ liệu
            NetworkStream stream = client.GetStream();

            // Dữ liệu cần gửi
            string message = "Hello, server!";
            byte[] data = Encoding.ASCII.GetBytes(message);

            // Gửi dữ liệu đến server
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Sent: " + message);

            // Nhận phản hồi từ server
            data = new byte[256];
            StringBuilder responseBuilder = new StringBuilder();
            int bytesRead;
            while ((bytesRead = stream.Read(data, 0, data.Length)) != 0)
            {
                responseBuilder.Append(Encoding.ASCII.GetString(data, 0, bytesRead));
            }
            Console.WriteLine("Response from server: " + responseBuilder.ToString());

            // Đóng kết nối
            client.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
