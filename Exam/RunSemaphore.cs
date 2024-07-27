using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System;

namespace Exam
{
    public class RunSemaphore
    {
        private Semaphore semaphore;
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int counter = 0;
        private int clickCounter = 0;

        public RunSemaphore(int places)
        {
            semaphore = new Semaphore(1, places);
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            counter++;
        }

        public void Run(ListBox waitingList, ListBox workingList)
        {
            waitingList.Items.Add($"Thread {Thread.CurrentThread.ManagedThreadId} -> waiting");
            semaphore.WaitOne();
            Thread.Sleep(5000);
            waitingList.Items.Remove($"Thread {Thread.CurrentThread.ManagedThreadId} -> waiting");

            counter = Thread.CurrentThread.ManagedThreadId;
            timer.Start();
            workingList.Items.Add($"Thread {Thread.CurrentThread.ManagedThreadId} -> {counter}");
            
        }

        private void workingItem_Click(object sender, EventArgs e)
        {
            workingList
        }
    }
}
