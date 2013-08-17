using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Net.Http; 

namespace LeagueOfLegendsAutoChat
{
    // essa classe ta virando o faz tudo.. n curto isso mas VQV
    public class Program : Form
    {

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private LOLScanner scanner;
        private Mahape mahape;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }
        public Program()
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
           // trayMenu.MenuItems.Add("login", loginTest);
            trayMenu.MenuItems.Add("Config", OnConfig);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "LOLChat";
     
            trayIcon.Icon = new Icon("images/lol.ico", 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

           //start API
            mahape = new Mahape();


            //agora bora scanear pelo LOL
            //essa classe ta tão lixo que tudo que vc precisa fazer é instanciar ela e ela começa a funcionar..
            scanner = new LOLScanner();
            scanner.LOLOpened += new EventHandler(this.lolwasopened);
            scanner.LOLClosed += new EventHandler(this.lolwasClosed);
            
            //se não tiver summoner name setado setar abrir a tela e forçar o summoner name
            if(Properties.Settings.Default.summoner.ToString() == "")
            {
                OnConfig(this, EventArgs.Empty);
            }

        }
       
   
        private void lolwasopened(object sender, EventArgs e)
        {
            //agora vamos pegar a lista dos invocadores do seu time

            List<string> l = mahape.getPlayersOnMyTeam();

            string temp = "Seu time é: ";
            if (l == null)
            {
                temp = "Erro ao pegar a lista de invocadores.";
            }
            else
            {
                foreach (string s in l)
                {
                    temp += " " + s + " |";
                }
            }
            MessageBox.Show(temp);
 
         //   MessageBox.Show("LOL WAS OPENED");
        }

        private void lolwasClosed(object sender, EventArgs e)
        {
            MessageBox.Show("LOL was closed");
        }


        private void OnConfig(object sender, EventArgs e)
        {
            //OMG SEU NUBA.. vai mesmo instaciar toda vez a classe? DANE O GC MESMO NE
            Form1 f = new Form1();
            f.Show();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            //peguei from web sample.. prov tem uma forma melhro de fazer.. mas funfa... GG
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            //.NET é mto easy hauhauhauha
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
    }
    
}
