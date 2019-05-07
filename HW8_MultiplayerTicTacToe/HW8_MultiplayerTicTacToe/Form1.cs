using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace HW8_MultiplayerTicTacToe
{
    public partial class Form1 : Form
    {
        CheckGame cg = new CheckGame();
        char[,] Board = new char[3,3];
        char FinalVal;
        int LocalValue1;
        int LocalValue2;        
        TcpClient Player;

        public Form1()
        {
            InitializeComponent();
            txt_IpConnection.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
            
        }    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Checks if the array has been filled already.
            if (Board[0, 0] == '\0')
            {
                //Returns the proper value to the board and text box.
                if (Return(textBox1, 0, 0))
                {
                    //Checks if the game is finished.
                    if (IsFin() == false)
                    {
                        //Commits the changes to the board.
                        CommitVals(0, 0);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Board[0, 1] == '\0')
            {
                if (Return(textBox2, 0, 1))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(0, 1);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Board[0, 2] == '\0')
            {
                if (Return(textBox3, 0, 2))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(0, 2);
                    }
                }
            }
        }        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Board[1, 0] == '\0')
            {
                if (Return(textBox4, 1, 0))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(1, 0);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Board[1, 1] == '\0')
            {
                if (Return(textBox5, 1, 1))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(1, 1);
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Board[1, 2] == '\0')
            {
                if (Return(textBox6, 1, 2))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(1, 2);
                    }
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (Board[2, 0] == '\0')
            {
                if (Return(textBox7, 2, 0))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(2, 0);
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (Board[2, 1] == '\0')
            {
            if (Return(textBox8, 2, 1))
            {
                if (IsFin() == false)
                {
                    CommitVals(2, 1);
                }
            }
        }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (Board[2, 2] == '\0')
            {                
                if (Return(textBox9, 2, 2))
                {
                    if (IsFin() == false)
                    {
                        CommitVals(2, 2);
                    }
                }
            }
        }

        //Commits the changes to each text box.
        void CommitVals( int pos1, int pos2)
        {
            List<TextBox> Boxes = TextBoxes();
            string val = Board[pos1, pos2].ToString();
            SendMessage(Player, pos1.ToString(), pos2.ToString(), val);
            //Boxes.Any(x => x.TextChanged == false).Wait();
            //while (BreakVal == false) { }
            //BreakVal = false;            
        }

        //Saves the value from the text box to the board character variables and changes them to correct values.
        private bool Return(TextBox Box, int loc1, int loc2)
        {
            string input = Box.Text;
            input = input.ToUpper();

            if ((input == "O") || (input == "X"))
            {
                Box.Enabled = false;
                Box.Text = input;
                Board[loc1, loc2] = char.Parse(input);
                return true;
            }
            else
            {
                MessageBox.Show("Enter either an X or an O");
                Box.Text = "";
                return false;
            }
            
        }

        //Returns if the boards values are all filled.
        bool IsFull()
        {
            List<TextBox> Boxes = TextBoxes();
            for(int i = 0; i < Boxes.Count; i++)
            {
                if (Boxes[i].Text == "")
                    return false;
            }

            return true;
        }

        //returns if the board is full or game values are a winning value.
        bool IsFin()
        {
            List<TextBox> Box = TextBoxes();
            if (IsFull())
            {
                if (cg.CheckBoard(Board, ref FinalVal))
                {
                    label1.Text = "Game Over";
                    GrayBoxes(Box, false);
                    MessageBox.Show($"{FinalVal}'s Win");
                    return true;
                }
                else
                {
                    label1.Text = "Game Over";
                    return true;
                }
            }
            else
            {
                if (cg.CheckBoard(Board, ref FinalVal))
                {
                    label1.Text = "Game Over";
                    GrayBoxes(Box, false);
                    MessageBox.Show($"{FinalVal}'s Win");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Grays out text boxes or resets the board.
        void GrayBoxes(List<TextBox> Boxes, bool enable)
        {
            for (int i = 0; i< Boxes.Count; i++)
            {
                Boxes[i].Enabled = enable;
                if(enable == true)
                {
                    Boxes[i].Text = "";                    
                }
            }

            if(enable == true)
            Board = new char[3, 3];
        }

        //Returns a list of the boards text boxes
        List<TextBox> TextBoxes()
        {
            List<TextBox> retBoxes = new List<TextBox>
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 
            };

            return retBoxes;
        }
        
        //Listens for other players and or starts the connection.
        async void Listen()
        {
            try
            {
                Player = new TcpClient(txt_IpConnection.Text, 5555);
            }
            catch
            {
                AddMessage("No listener found, opening listener.");
                TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
                listener.Start();
                Player = await listener.AcceptTcpClientAsync();
                await Task.Factory.StartNew(() => ListenForPacket(Player));
                listener.Stop();
                return;
            }
            AddMessage("Listener found, connection successful.");
            await Task.Factory.StartNew(() => ListenForPacket(Player));
        }

        //Returns the returned value from the listener.
        private void AddMessage(string inVal)
        {
            List<TextBox> Boxes = TextBoxes();
            this.Invoke(new MethodInvoker(delegate
            {
                if (inVal == "Reset")
                {
                    //Resets the board.
                    List<TextBox> Box = TextBoxes();
                    label1.Text = "Tic Tac Toe";
                    GrayBoxes(Box, true);                   
                }
                else
                {
                    if (inVal.Length == 3)
                    {
                        //Breaks up and places the values in the board and text box.
                        //string[] values = inVal.Split('\0');
                        char[] values = inVal.ToCharArray();
                        LocalValue1 = int.Parse(values[0].ToString());
                        LocalValue2 = int.Parse(values[1].ToString());
                        Board[LocalValue1, LocalValue2] = values[2];
                        Boxes[(LocalValue1 * 3) + LocalValue2].Enabled = false;
                        Boxes[(LocalValue1 * 3) + LocalValue2].Text = values[2].ToString();                        
                    }
                    else
                    {
                       //Changes the lables output depending in the input.
                        lbl_Connection.Text = inVal;
                    }
                }                
            }));
        }

        //Continuously listens for a return value.
        private void ListenForPacket(TcpClient connection)
        {
            NetworkStream stream = connection.GetStream();
            List<string> resul = new List<string>();
            while (true)
            {
                byte[] bytesToRead = new byte[connection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, connection.ReceiveBufferSize);
                string result = ASCIIEncoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "")
                {
                    AddMessage(result);                                       
                }
            }
        }

        //Sends a value for the game.
        private void SendMessage(TcpClient Connection, string loc1, string loc2, string Val)
        {
            string sender = (loc1 + loc2 + Val);
            byte[] bytesToSend = Encoding.ASCII.GetBytes(sender);
            Connection.GetStream().Write(bytesToSend, 0, bytesToSend.Count() );
        }

        //Resets the game and sends a value to reset the other end.
        private void btn_ResetGame_Click(object sender, EventArgs e)
        {
            List<TextBox> Box = TextBoxes();
            label1.Text = "Tic Tac Toe";
            GrayBoxes( Box, true);
            SendMessage(Player, "Reset", "", "");
        }

        //Tests the connection for players.
        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            Listen();            
            if (Player != null) { 
            SendMessage(Player, "Connection Success", ".", "");
                 }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Player. Dispose();
            Task.Yield();
            Player.Close();
            Close();
        }
    }
}
