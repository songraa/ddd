using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        TaskManagementEntities TMS = new TaskManagementEntities();
        public Admin(string name)
        {
            InitializeComponent();
            adminDG.ItemsSource = TMS.Tasks.ToList();
        }
        
        private void DelB_Click(object sender, RoutedEventArgs e)
        {
            var fg = TMS.Tasks.FirstOrDefault(q => q.TaskId == int.Parse(taskidtxt.Text));
             TMS.Tasks.Remove(fg);
            TMS.SaveChanges();
            refresh();
        }

        private void EditB_Click(object sender, RoutedEventArgs e)
        {
            var save = TMS.Tasks.Where(s => s.TaskId == int.Parse(taskidtxt.Text));
            if (save != null)
            {
                Task task = new Task
                {
                    Status = adStatusCombo.SelectedItem.ToString(),
                    Title= titletxt.Text,
                    Description=desctxt.Text
                };    
                
                User user = new User
                { 
                Email = emailtxt.Text
                };

                TMS.Tasks.AddOrUpdate(task);
                TMS.Users.AddOrUpdate(user);
                TMS.SaveChanges();
                refresh();
            }
        }

        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dd = TMS.Users.FirstOrDefault(s => s.Email == emailtxt.Text);
                var ew = string.IsNullOrEmpty(taskidtxt.Text);
                if (dd != null && ew)
                {
                    var vw = TMS.Tasks.FirstOrDefault(d => d.TaskId == int.Parse(taskidtxt.Text));
                    vw.Status = adStatusCombo.SelectedItem.ToString();
                    vw.Title = titletxt.Text;
                    vw.Description = desctxt.Text;
                    dd.Email = emailtxt.Text;
                    vw.EmployeeId = dd.EmployeeId;
                    TMS.Tasks.AddOrUpdate(vw);
                    TMS.Users.AddOrUpdate(dd);
                    TMS.SaveChanges();
                    refresh();
                }
                else
                {
                    MessageBox.Show("You can't enter ID");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh()
        {
            adminDG.ItemsSource = TMS.Tasks.Where(i => i.EmployeeId == i.User.EmployeeId).ToList();

        }

        private void adStatusCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

