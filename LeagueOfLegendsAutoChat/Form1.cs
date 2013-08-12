using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



 

namespace LeagueOfLegendsAutoChat
{

    public partial class Form1 : Form
    {
        LOLScanner lols;

        public Form1()
        {
            InitializeComponent();
            Mahape m = new Mahape();
            lols = new LOLScanner();
            lols.LOLOpened += new EventHandler(this.lolwasopened);
            lols.LOLClosed += new EventHandler(this.lolwasClosed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSServer.Stop();
        }

        private void lolwasopened(object sender, EventArgs e)
        {
            MessageBox.Show("LOL was opened");
        }

        private void lolwasClosed(object sender, EventArgs e)
        {
            MessageBox.Show("LOL was closed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TSServer.Start();
        }

    }

    public static class WinAPI
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]

        public static extern int FindWindow(string lpClassName, string lpWindowName);

    }

}
