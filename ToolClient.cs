using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationTool_Client
{
    public partial class ToolClient : Form
    {
        private bool clientStatus = false;
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receivedBuf = new byte[1024];
        Thread thr;
        public ToolClient()
        {
            InitializeComponent();
        }

        private void pictureBox_BroadcastMsg_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected && richTextBox_chatInput.Text != "")
            {

                byte[] buffer = Encoding.ASCII.GetBytes(textBox_UserName.Text + " diz : " + richTextBox_chatInput.Text + "\n");
                _clientSocket.Send(buffer);
                //richTextBox_chatStream.AppendText("Client: " + richTextBox_chatInput.Text + "\n");
            }
            richTextBox_chatInput.Text = "";
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                if (_clientSocket.Connected && richTextBox_chatInput.Text != "")
                {

                    byte[] buffer = Encoding.ASCII.GetBytes(textBox_UserName.Text + " diz : " + richTextBox_chatInput.Text + "\n");
                    _clientSocket.Send(buffer);
                    //richTextBox_chatStream.AppendText("Client: " + richTextBox_chatInput.Text + "\n");
                }
                richTextBox_chatInput.Text = "";
            }
        }

        private void btn_ConnectServer_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text != "")
                ControlClientStatus();
        }

        public void ControlClientStatus()
        {
            if (clientStatus == false)
            {
                clientStatus = true;

                richTextBox_chatStream.Text += "System Info: Cliente conectado. \n";
                //btn_ConnectServer.Text = "Desconectar";               
                btn_ConnectServer.BackColor = System.Drawing.Color.Red;
                btn_ConnectServer.Enabled = false;
                btn_ConnectServer.Text = "Conectado";
                textBox_UserName.Enabled = false;

                LoopConnect();
                // SendLoop();
                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                byte[] buffer = Encoding.ASCII.GetBytes("@@" + textBox_UserName.Text + " se conectou. \n");
                _clientSocket.Send(buffer);
            }
        }
        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];
            Array.Copy(receivedBuf, dataBuf, received);
            //richTextBox_chatStream.Text = (Encoding.ASCII.GetString(dataBuf));
            SetText(Encoding.ASCII.GetString(dataBuf));
            //rb_chat.AppendText("\nServer: " + lb_stt.Text);
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
        }

        private void SendLoop()
        {
            while (true)
            {
                //Console.WriteLine("Enter a request: ");
                //string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                //_clientSocket.Send(buffer);

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    richTextBox_chatStream.Text = ("Received: " + Encoding.ASCII.GetString(data) + "\n");
                    richTextBox_chatStream.AppendText("Server: " + Encoding.ASCII.GetString(data) + "\n");
                }
                else _clientSocket.Close();

            }
        }

        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    //_clientSocket.Connect(IPAddress.Loopback, 100);
                    _clientSocket.Connect("192.168.75.1", 100);
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    richTextBox_chatStream.Text = ("Connection attempts: " + attempts.ToString() + "\n");
                }
            }
            richTextBox_chatStream.Text = ("Connected to server! \n");
        }

        delegate void SetTextCallback(string text);

        public void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBox_chatStream.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox_chatStream.Text += text;
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox_chatStream.SelectionStart = richTextBox_chatStream.Text.Length;
            // scroll it automatically
            richTextBox_chatStream.ScrollToCaret();
        }
    }
}
