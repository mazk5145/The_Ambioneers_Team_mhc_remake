using System;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Net;

//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145

namespace ambitioneersmhc
{
    static class Program
    {
        static HttpListener _httpListener = new HttpListener();
        static void Main(string[] args)
        {
            _httpListener.Prefixes.Add("http://localhost:8083/");
            _httpListener.Start();
            Thread _responseThread = new Thread(ResponseThread);
            _responseThread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }

        static void ResponseThread()
        {
            while (true)
            {
                HttpListenerContext context = _httpListener.GetContext(); // get a context
                                                                          // Now, you'll find the request URL in context.Request.Url
                byte[] _responseArray = Encoding.UTF8.GetBytes("<html><head><title>GTA5</title></head>" +
                "<head><body>Callback received. Feel free to close this page.</body></html>"); // get the bytes to response
                context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length); // write bytes to the output stream
                context.Response.KeepAlive = false; // set the KeepAlive bool to false
                context.Response.Close(); // close the connection
            }
        }
    }
}
