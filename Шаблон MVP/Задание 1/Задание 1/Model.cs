using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace Задание_1
{
    class Model
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Stopwatch stopWatch = new Stopwatch();
        public string currentTime = string.Empty;

        public Model()
        {
            dispatcherTimer.Tick += new EventHandler(dt_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        public void dt_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        public void StartTimer()
        {
            stopWatch.Start();
            dispatcherTimer.Start();
        }

        public void StopTimer()
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        public void ResetTimer()
        {
            stopWatch.Reset();
            currentTime = "00:00:00";
        }
    }
}

