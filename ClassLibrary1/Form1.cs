using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Define an Cimatron Provider object
            interop.CimServicesAPI.CimApplicationProvider AppProvider = new interop.CimServicesAPI.CimApplicationProvider();
            //Get Application object from AppProvider object.
            interop.CimatronE.IApplication CimApp = (interop.CimatronE.IApplication)AppProvider.GetApplication();
            interop.CimatronE.IPdm aPdm = CimApp.GetPdm();
            try {

                aPdm.OpenDocument(textBox1.Text); 
            }
               catch {
                MessageBox.Show("you made a mistake");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
