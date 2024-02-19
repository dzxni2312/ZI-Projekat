using WindowsFormsApp1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaWFC
{
    public partial class OFB : Form, IServerCallback
    {
        private bool encrypt;
        private string fileName;
        private ServerClient proxy;

        public OFB(bool e)
        {
            encrypt = e;
            proxy = new ServerClient(new InstanceContext(this));
            InitializeComponent();

            if (e)
                actionButton.Text = "Encrypt";
            else
                actionButton.Text = "Decrypt";
        }

        private byte[] ReadBMP()
        {
            if(fileName==null)
            {
                MessageBox.Show("Moras izabrati BMP fajl!");
                return null;
            }

            Bitmap img = new Bitmap(fileName);

            ImageConverter converter = new ImageConverter();
            byte[] data = (byte[])converter.ConvertTo(img, typeof(byte[]));

            img.Dispose();

            return data;
        }

        private void SaveBMP(byte[] data)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
            {
                Bitmap img = new Bitmap(ms);
                img.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                img.Dispose();
            }
            MessageBox.Show("Fajl je sacuvan kao " + fileName);
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileTbx.Text = fileName;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            byte[] data = ReadBMP();

            if (encrypt==false)
                proxy.OFBDecrypt(data);
            
            else
                proxy.OFBEncrypt(data);
        }

        public void Message(byte[] msg)
        {
            SaveBMP(msg);
        }
    }
}
