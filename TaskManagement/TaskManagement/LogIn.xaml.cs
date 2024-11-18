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

namespace TaskManagement
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        TaskManagementEntities TME = new TaskManagementEntities();
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, RoutedEventArgs e)
        {
            var man = TME.Users.FirstOrDefault(u => u.Email == logemailtxt.Text && u.Password == logpasstxt.Text && u.EmployeeRole == "Manager");
            var emp = TME.Users.FirstOrDefault(u=> u.Email==logemailtxt.Text && u.Password==logpasstxt.Text&& u.EmployeeRole=="Employee");
            if (emp != null)
            {
                this.NavigationService.Navigate(new ViewTask(emp.Name));
            }
            else if (man != null)
            {
                this.NavigationService.Navigate(new Admin(man.Name));
            }
            else
            {
                MessageBox.Show("User Not Found!");
            }
        }

        private void signupB_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SignUp());
        }
    }
}
