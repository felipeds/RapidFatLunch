using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace LeagueOfLegendsAutoChat
{
    //Ainda não sei se deveria ser uma classe estática ou não
    // a priore não gosto da idéia de iniciar threads em classes estáticas.
    // this class is bad and I should feel bad
    class LOLScanner
    {
        //evento disparado quando o LOL é aberto
        public event EventHandler LOLOpened;

        //evento disparado quando o LOL é fechado
        public event EventHandler LOLClosed;

        //determina se o o jog está rolando no momento;
        private bool isRunning;

        //Ugly thread is ugly
        Thread t;

    

        //Importar a user32 para encontrar a janela do lol
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]

        public static extern int FindWindow(string lpClassName, string lpWindowName);



        //Aqui a coisa começa a ficar feia.... na verdade essa técnica é meio nojenta.. mas ta valendo.. vai funcionar por agora
        //O ideal seria fazer um trigger quando a aplicação for lançada e não ficar lendo por ela o tempo todo
        public LOLScanner()
        {
           // isRunning = isLolRunning();

            //ugly code is ugly
            t = new Thread(new ThreadStart(this.run));
            t.Start();
        }

        ~LOLScanner()  
        {
            // isso é necessário ou o destructor do pbjeto já apra ela? n sei e por garantia deixei um suspend aqui
            t.Abort();
        }

        private void run()
        {
            while (true)
            {
                //OMG I FAIL, also executar o codigo de verificação a cada 2 segundos :( I suck at coding..
                Thread.Sleep(2000);
                if (!isRunning && isLolRunning())
                {
                    isRunning = true;
                    if (this.LOLOpened != null)
                    {
                        this.LOLOpened(this, EventArgs.Empty);
                    }
                }
                else if (isRunning && !isLolRunning())
                {
                    isRunning = false;
                    if (this.LOLClosed != null)
                    {
                        this.LOLClosed(this, EventArgs.Empty);
                    }
                }
            }
        }

        

        private bool isLolRunning()
        {

            int hWnd = FindWindow(null, "League of Legends (TM) Client");
            if (hWnd > 0) //If found
            {
                return true;
            }
            return false;
        }

    }
}
