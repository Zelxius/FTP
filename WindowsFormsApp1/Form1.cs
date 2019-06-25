using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string user = "test1pweb";
        private string password = "computadora321";
        private string ftpAddress = "ftp://files.000webhost.com/public_html";
        private string filePath = "C:\\Users\\kiara\\Documents\\Escuela\\Programación - Estructura y base de datos\\a20140912.txt";
        private FtpWebRequest request;

        public Form1()
        {
            InitializeComponent();
            FtpConnection();
        }

        private void FtpConnection()
        {
            this.request = (FtpWebRequest)FtpWebRequest.Create(this.ftpAddress + "/" + Path.GetFileName(this.filePath));
            this.request.Method = WebRequestMethods.Ftp.UploadFile;
            this.request.Credentials = new NetworkCredential(this.user, this.password);
            this.request.UsePassive = true;
            this.request.UseBinary = true;
            this.request.KeepAlive = false;
        }

        private byte[] LoadFile()
        {
            FileStream stream = File.OpenRead(this.filePath);
            byte[] buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);
            stream.Close();
            return buffer;
        }

        private void UploadFile(byte[] buffer)
        {
            Stream reqStream = this.request.GetRequestStream();
            reqStream.Write(buffer, 0, buffer.Length);
            reqStream.Close();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            byte[] fileBuffer = LoadFile();
            UploadFile(fileBuffer);
        }
    }
}
