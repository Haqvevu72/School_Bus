using Context.Contexts;
using System.Linq;
using System.Windows.Controls;
using Entity.DTO;
using System.Collections.Generic;

namespace School_Bus.Views
{
    /// <summary>
    /// Interaction logic for ClassView.xaml
    /// </summary>
    public partial class ClassView : UserControl
    {
        public ClassView()
        {
            InitializeComponent();
            SchoolBusDB db = new SchoolBusDB();
            List<ClassDTO> classes = db.Classes.Select(c => new ClassDTO{Id = c.Id,Name = c.Name}).ToList();
            Classes.ItemsSource = classes;
        }
    }
}
