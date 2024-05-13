using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkUtility.Services
{
    public class NetworkService
    {
        private readonly string ipAddress;

        public NetworkService()
        {
            ipAddress = GetLocalIPAddress();
        }

        public int SendPing()
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status == IPStatus.Success)
                    {
                        return 200;
                    }
                    else
                    {
                        return 404;
                    }
                }
                catch (Exception)
                {
                    return 500;
                }
            }
        }

        private string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try
            {
                // Get the local machine's IP addresses
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ip in localIPs)
                {
                    // Check if the IP address is IPv4 and not loopback
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip))
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving local IP address: {ex.Message}");
            }
            return localIP;
        }
    }
}
