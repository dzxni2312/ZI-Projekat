using WindowsFormsApp1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaWFC
{
    public partial class Form1 : Form
    {
        private bool encrypt;
        private string algorithm;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            if (actionBox.SelectedIndex ==-1 || algorithm == null)
            {
                MessageBox.Show("Moras selektovati i algoritam i akciju koju zelis");
                return;
            }

            switch(algorithm)
            {
                case "One-time-pad":
                    OTP otpform = new OTP(encrypt);
                    otpform.Show();
                    break;

                case "Four-Square Cipher":
                    Foursquare fsqform = new Foursquare(encrypt);
                    fsqform.Show();
                    break;

                case "OFB":
                    OFB ofbform = new OFB(encrypt);
                    ofbform.Show();
                    break;

                case "XXTEA":
                    XXTEA xxteaform = new XXTEA(encrypt);
                    xxteaform.Show();
                    break;
            }
        }

        private void ActionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionBox.SelectedIndex == 0)
                encrypt = true;
            else encrypt = false;
        }

        private void AlgorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            algorithm = algorithmBox.Items[algorithmBox.SelectedIndex].ToString();
        }

    }
}
