using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.UViewModels;
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
using System.Windows.Shapes;

namespace ShortBody.Windows
{
    /// <summary>
    /// Interaction logic for MasterPasswordWindow.xaml
    /// </summary>
    public partial class MasterPasswordWindow : Window
    {
        string passWord;
        LocalAppContext db;
        DashBoardPages page;
        bool IsPage;
        public MasterPasswordWindow(DashBoardPages page,bool isPage = true)
        {
            InitializeComponent();
            db = new LocalAppContext();
            passWord = GetPassword();
            IsPage = isPage;
            this.page = page;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            
                if (tbPassword.Password == passWord)
                {
                    if(IsPage)
                    DashBoardViewModel.dbPage = page;
                    this.DialogResult = true;
                    this.Close();
                }
                else
                {
                    topError.Text = "Invalid Password";
                }
           
       
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            Height = 280;
            spTop.Visibility = Visibility.Collapsed;
            spBottom.Visibility = Visibility.Visible;
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Height = 180;
            spBottom.Visibility = Visibility.Collapsed;
            spTop.Visibility = Visibility.Visible;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if(tbNewPassword.Password != tbConfirmNewPassword.Password)
            {
                downError.Text = "Passwords do not match";
                return;
            }

            if(tbOldPassword.Password != passWord)
            {
                downError.Text = "Wrong Password";
                return;
            }

            if (tbOldPassword.Password == passWord)
            {
                db.MasterPasswords.FirstOrDefault().Password = tbNewPassword.Password;
                db.SaveChanges();
                passWord = tbNewPassword.Password;
                downError.Text = "PassWord changed successfully";
                tbOldPassword.Password = "";
                tbNewPassword.Password = "";
                tbConfirmNewPassword.Password = "";
            }
        }

        public string GetPassword()
        {
            return db.MasterPasswords.FirstOrDefault().Password;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
         
        }

        
    }
}
