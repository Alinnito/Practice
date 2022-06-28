using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Задание_1
{
    class Presenter
    {
        private Model model = null;
        private MainWindow mainWin = null;

        public Presenter(MainWindow mainWin)
        {
            this.mainWin = mainWin;
            this.model = new Model();

            this.mainWin.myStartEvent += new EventHandler(mainWin_myStartEvent);
            this.mainWin.myStopEvent += new EventHandler(mainWin_myStopEvent);
            this.mainWin.myResetEvent += new EventHandler(mainWin_myResetEvent);

            model.dispatcherTimer.Tick += timer_Tick;

        }

        void mainWin_myStartEvent(object sender, System.EventArgs e)
        {
            model.StartTimer();
        }

        void mainWin_myStopEvent(object sender, System.EventArgs e)
        {
            model.StopTimer();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            mainWin.clocktxt.Text = model.currentTime;
        }

        void mainWin_myResetEvent(object sender, System.EventArgs e)
        {
            model.ResetTimer();
        }
    }
}
