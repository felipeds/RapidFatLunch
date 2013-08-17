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
            //Popula a Drop Primeiro senão nao consigo dar o selected value =/
            populaDrop();

            txtSummonerName.Text = Properties.Settings.Default.summoner.ToString();
            cbRegion.SelectedValue = Properties.Settings.Default.region.ToString();

            //ugly tem que mudar isso depois para um default melhor
            if (cbRegion.SelectedText == "")
            {
                cbRegion.SelectedValue = "br";
                //cbRegion.SelectedText = "Brazil";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSServer.Stop();
        }



        private void populaDrop()
        {
            //Limpa a Combo pra nao Bugar :D

            cbRegion.Items.Clear();
            var dict = new Dictionary<string, string>();

            //Adiciona as Regioes
            dict.Add("br", "Brazil");
            dict.Add("na", "North America");
            dict.Add("euw", "EU West");
            dict.Add("eune", "EU Nordic & East");
            dict.Add("tr", "Turkey");
            dict.Add("ru", "Russia");
            dict.Add("lan", "Latin America North");
            dict.Add("las", "Latin America South");
            dict.Add("oce", "Oceania");
            cbRegion.DataSource = new BindingSource(dict, null);
            cbRegion.DisplayMember = "Value";
            cbRegion.ValueMember = "Key";
   
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
           // TSServer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSummonerName.Text == "")
            {
                MessageBox.Show("Define ae o nome do seu invocador, seu relaxo");
                return;
            }
            Properties.Settings.Default.summoner = txtSummonerName.Text;
            Properties.Settings.Default.region = cbRegion.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            this.Close();

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

    public static class WinAPI
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]

        public static extern int FindWindow(string lpClassName, string lpWindowName);

    }

}
