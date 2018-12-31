// Type: MTechERP.ASTMControl
// Assembly: MTechERP, Version=4.7.51.0, Culture=neutral, PublicKeyToken=null
// MVID: D0AABECB-CB7F-42E6-A234-0752CE355F07
// Assembly location: D:\CodeData\MTechERP -TMP\MTechERP.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MTechERP
{
  public class ASTMControl
  {
    public IPAddress ServerIP;
    public int ServerPort;
    public TcpListener Server;
    public Thread CommThread;
    public bool IsListining;
    private TcpClient Client;
    private StreamReader ClientData;

    public event ASTMControl.MessageReceivedEventHandler MessageReceived;

    public ASTMControl()
    {
      this.ServerIP = IPAddress.Parse(ModUpdateDatabase.IP);
      this.ServerPort = ModUpdateDatabase.port;
      this.IsListining = true;
      this.Server = new TcpListener(this.ServerIP, this.ServerPort);
      this.Server.Start();
      this.CommThread = new Thread(new ThreadStart(this.Listining));
      this.CommThread.Start();
    }

    private void Listining()
    {
      while (this.IsListining)
      {
        try
        {
          byte[] numArray = new byte[1025];
          string str = (string) null;
          while (true)
          {
            TcpClient tcpClient = this.Server.AcceptTcpClient();
            str = (string) null;
            NetworkStream stream = tcpClient.GetStream();
            for (int count = stream.Read(numArray, 0, numArray.Length); (uint) count > 0U; count = stream.Read(numArray, 0, numArray.Length))
            {
              byte[] bytes1 = Encoding.ASCII.GetBytes(this.HandleMessage(Encoding.ASCII.GetString(numArray, 0, count).ToUpper()));
              stream.Write(bytes1, 0, bytes1.Length);
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameENQ, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameENQ.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameENQ = "";
              }
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameOrder0, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameOrder0.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameOrder0 = "";
              }
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameOrder1, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameOrder1.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameOrder1 = "";
              }
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameOrder2, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameOrder2.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameOrder2 = "";
              }
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameOrder3, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameOrder3.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameOrder3 = "";
              }
              if ((uint) Operators.CompareString(ModUpdateDatabase.gFrameEOT, "", false) > 0U)
              {
                byte[] bytes2 = Encoding.ASCII.GetBytes(ModUpdateDatabase.gFrameEOT.ToString());
                stream.Write(bytes2, 0, bytes2.Length);
                ModUpdateDatabase.gFrameEOT = "";
              }
            }
            tcpClient.Close();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private string HandleMessage(string data)
    {
      string str;
      try
      {
        // ISSUE: reference to a compiler-generated field
        ASTMControl.MessageReceivedEventHandler receivedEventHandler = this.MessageReceivedEvent;
        if (receivedEventHandler != null)
          receivedEventHandler(this, data);
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('\x0006');
        str = stringBuilder.ToString();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('\x0006');
        str = stringBuilder.ToString();
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public delegate void MessageReceivedEventHandler(ASTMControl sender, string data);
  }
}

