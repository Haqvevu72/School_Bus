using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Window = System.Windows.Window;

namespace School_Bus.Views
{
    /// <summary>
    /// Interaction logic for ClassView.xaml
    /// </summary>
    public partial class ClassView : UserControl
    {
        public static Window inputWindow;
        public static Window outputWindow;
        public ClassView()
        {
            InitializeComponent();
        }

        private void btn_AddClass_Click(object sender, RoutedEventArgs e)
        {
            ClassAddView inputControl = new ClassAddView();
            inputWindow = new Window()
            {
                Content = inputControl,
                Height = 300,
                Width = 400,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            inputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    inputWindow.DragMove();
                }
            };
            inputWindow.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassRemoveView outputControl = new ClassRemoveView();
            outputWindow= new Window
            {
                Content = outputControl,
                Height = 400,
                Width = 400,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            outputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                   outputWindow.DragMove();
                }
            };
            outputWindow.ShowDialog();
        }
    }
}
