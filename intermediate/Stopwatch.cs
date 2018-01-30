using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate
{
    class Stopwatch
    {
        public void stopwatch()
        {
            var t = 0;
            var time = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            while (t == 0)
            {
                Console.Write("Enter to start :");
                var c = Console.ReadLine();
                var b = (c == "reset") ? time = 0 : time = 1;
                if (time == 1)
                {
                    watch.Start();
                }
                else
                {
                    watch = System.Diagnostics.Stopwatch.StartNew();
                }

                if (c != "reset")
                {
                    Console.Write("Enter to stop :");
                    var s = Console.ReadLine();
                    if (s == "stop") { t = 1; break; }
                    watch.Stop();
                    time = 1;
                    TimeSpan ts = watch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    Console.WriteLine("RunTime " + elapsedTime);
                }
                
            }


            //var elapsedMs = watch.ElapsedMilliseconds;
        }
    }
}
