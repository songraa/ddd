using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace TaskManagement
{
    /// <summary>
    /// Interaction logic for ViewTask.xaml
    /// </summary>
    public partial class ViewTask : Page
    {
        TaskManagementEntities TMS= new TaskManagementEntities();
        public ViewTask(string name)
        {
            InitializeComponent();
            empname.Text = name;
            var employe = TMS.Users.Where(emp => emp.Name== name);
            try
            {
                if (employe != null)
                {
                    tastDG.ItemsSource = TMS.Tasks.Where(t => t.Status != "Completed").ToList();
                    comtaskDG.ItemsSource = TMS.Tasks.Where(c => c.Status == "Completed").ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveB_Click(object sender, RoutedEventArgs e)
        {

            var save = TMS.Tasks.Where(s=> s.TaskId== int.Parse(IDtxt.Text));
            if (save != null)
            {

              //  save.st = stutusCombo.SelectedItem.ToString();
               
                TMS.SaveChanges();
                tastDG.ItemsSource = TMS.Tasks.Where(t => t.Status != "Completed").ToList();
                comtaskDG.ItemsSource = TMS.Tasks.Where(c => c.Status == "Completed").ToList();

            }
        }

        private void stutusCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
