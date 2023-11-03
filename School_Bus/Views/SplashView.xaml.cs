using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace School_Bus.Views
{
    /// <summary>
    /// Interaction logic for SplashView.xaml
    /// </summary>
    public partial class SplashView : Window
    {
        static public LoginView loginscreen = new LoginView();
        public SplashView()
        {
            InitializeComponent();
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_dowork;
            worker.ProgressChanged += worker_progresschanged;
            worker.RunWorkerAsync();
        }

        void worker_dowork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(80);
            }
        }

        void worker_progresschanged(object sender, ProgressChangedEventArgs e)
        {
            prog_bar.Value = e.ProgressPercentage;
            if (prog_bar.Value == 50)
            {
                Close();
                loginscreen.ShowDialog();
            }
        }
    }
}
