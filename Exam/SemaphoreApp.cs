using System;
using System.Threading;
using System.Windows.Forms;

namespace Exam
{
    public partial class SemaphoreApp : Form
    {
        private RunSemaphore runSemaphore;
        private Thread[] threads;
        private int threadIndex = 1;
        private int clickCounter = 0;

        public SemaphoreApp()
        {
            InitializeComponent();
            CenterToScreen();
            semaphorePlaces.Maximum = 3;
        }

        private void createThreadBtn_Click(object sender, EventArgs e)
        {
            int places = Convert.ToInt32(semaphorePlaces.Value);
            if (places == 0) return;

            runSemaphore = new RunSemaphore(places);

            threads[threadIndex - 1] = new Thread(() => );
            creatingList.Items.Add($"Thread {threadIndex} -> created");
            threadIndex++;
        }


        private void StartThread(int index)
        {
            threads[index].Start();
            threads[index].Join();
        }
    }
}
