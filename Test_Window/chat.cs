using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Test_Window
{
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
            
        }
        static Socket clientSocket;
/*        Thread s = new Thread(new ThreadStart(shy));*/
        public static void shy()
        {
/*            while (true)
            {
                byte[] inBuffer = new byte[1024];
                clientSocket.Receive(inBuffer, 1024, SocketFlags.None);//如果接收的消息为空 阻塞 当前循环 
                Console.WriteLine("服务器说：");
*//*                ListViewItem list = new ListViewItem(Encoding.UTF8.GetString(inBuffer));
                chat c = new chat();
                c.listView1.Items.Add(list);*//*
            }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Form1.user);
            //Console.WriteLine(Fri.fir);

            //将网络端点表示为IP地址和端口 用于socket侦听时绑定  
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.31.235"), 8888); //填写自己电脑的IP或者其他电脑的IP，如果是其他电脑IP的话需将ConsoleApplication_socketServer工程放在对应的电脑上。 
            clientSocket = new Socket(ipep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //将Socket连接到服务器  
            try
            {
                clientSocket.Connect(ipep);
                string outBufferStr;
                byte[] outBuffer = new byte[1024];
                
                outBufferStr = send.Text;
                outBuffer = Encoding.UTF8.GetBytes(outBufferStr);
                clientSocket.Send(outBuffer, outBuffer.Length, SocketFlags.None);

                byte[] inBuffer = new byte[1024];
                clientSocket.Receive(inBuffer, 1024, SocketFlags.None);//如果接收的消息为空 阻塞 当前循环 
                Console.WriteLine("服务器说：");
                Console.WriteLine(Encoding.UTF8.GetString(inBuffer));
                ListViewItem list = new ListViewItem(Encoding.UTF8.GetString(inBuffer));
                this.listView1.Items.Add(list);
            }
            catch
            {
                Console.WriteLine("服务未开启！");
                Console.ReadLine();
            }
        }
    }
}
