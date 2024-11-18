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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        TaskManagementEntities TMS = new TaskManagementEntities();

        public SignUp()
        {
            InitializeComponent();

        }

        private void signupB_Click(object sender, RoutedEventArgs e)
        {

            if (signcopasstxt.Text == null || signpasstxt.Text == null)
            {
                MessageBox.Show("don't let any feild blank");
            }
            else if(signpasstxt.Text.Length<8)
            {
                MessageBox.Show("Password shold be more than 8 chars");
            }
            else
            {
                if (signcopasstxt.Text != signpasstxt.Text)
                {
                    MessageBox.Show("pass should match");
                    return;
                } 
                if (signnametxt.Text == null || signroletxt.Text == null)
                {
                    MessageBox.Show("don't let any feild blank");
                    if (signroletxt.Text == "Manager" ||signroletxt.Text == "Employee"|| signroletxt.Text == "manager" || signroletxt.Text=="employee")
                    {
                        MessageBox.Show("Your role should be Manager or Employee");
                    }
                        
                }
                else
                {
                    var dd = TMS.Users.FirstOrDefault(s => s.Email == signemailtxt.Text);

                    if (signemailtxt.Text == null)
                    {
                        MessageBox.Show("don't let any feild blank");
                    }
                    else if(dd!=null)

                    {
                        MessageBox.Show("you have registered before");
                    }
                    else
                    {
                        User j= new User();
                        j.Name = signnametxt.Text;
                        j.Email = signemailtxt.Text;
                        j.Name=signnametxt.Text;
                        j.EmployeeRole = signroletxt.Text;
                        j.Password = signpasstxt.Text;
                        TMS.Users.Add(j);
                        TMS.SaveChanges();
                        MessageBox.Show("Account created correctly!");
                        this.NavigationService.Navigate(new LogIn());
                    }
                }

            }
           
        }
    }
}
