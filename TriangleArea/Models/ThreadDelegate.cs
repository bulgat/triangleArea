using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace TriangleArea.Models
{
    public class ThreadDelegate
    {
        public static void Main()
        {
            Thread FormInit = new Thread(delegate() { LabelChange("KOL KRIKUNOV"); });
            FormInit.Start();
            new Thread(delegate () { System.Diagnostics.Debug.WriteLine("---444444   = "); }) { IsBackground=true, Priority=ThreadPriority.Highest}.Start();
            new Thread(delegate () {
                Action action = () =>
                {
                    System.Diagnostics.Debug.WriteLine("--555555  = ");
                };
              

                }).Start();
            new Thread(delegate () {
                Action action = () =>
                {
                    System.Diagnostics.Debug.WriteLine("--555555  = ");
                };


            }).Start();
            Parallel.Invoke(
                () => {
                    System.Diagnostics.Debug.WriteLine("--56666  = ");
                },
                () => {
                    System.Diagnostics.Debug.WriteLine("--57777  = ");
                },
                () => {
                    System.Diagnostics.Debug.WriteLine("--58888  = ");
                }
                );
        }

        static void LabelChange(string Label)
        {
            System.Diagnostics.Debug.WriteLine("---4   = "+ Label);
        }
    }
}