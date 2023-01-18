
using EasyCaptcha.Wpf;
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
using app;

namespace WpfApp1
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool FirstTryToEnter = true;
        private bool LogIn = false;
        Context context = new Context();
        
       
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void CB_Checked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Visible;
            PasswordHidden.Visibility = Visibility.Hidden;
            PasswordUnmask.Text = PasswordHidden.Password;
        }
        private void CB_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordUnmask.Visibility = Visibility.Hidden;
            PasswordHidden.Visibility = Visibility.Visible;
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordHidden.Password;
            if (login.Length !=0 && password.Length != 0)
            {
                if (context.Accountant.Where(a => a.Login == login).FirstOrDefault() != null )
                {
                    if (context.Accountant.Where(a => a.Password == password).FirstOrDefault().Password == password)
                    {
                        User.userType = "Accountant";

                        User.Id = context.Accountant.Where(a => a.Password == password).FirstOrDefault().IdAccountant;
                        LogIn = true;
                    }
                }
                else if (context.Administrator.Where(a => a.Login == login).FirstOrDefault() != null)
                {
                    if (context.Administrator.Where(a => a.Password == password).FirstOrDefault().Password == password)
                    {
                        User.userType = "Administrator";
                        User.Id = context.Administrator.Where(a => a.Password == password).FirstOrDefault().IdAdministrator;
                        //user.userType = User.UserType.Manager;
                        //user.Id = context.Administrator.Where(a => a.Password == password).FirstOrDefault().IdAdministrator;
                        LogIn = true;
                    }
                }
                else if (context.DataOfLaboratoryAssistants.Where(a => a.Login == login).FirstOrDefault() != null)
                {
                    if (context.DataOfLaboratoryAssistants.Where(a => a.Password == password).FirstOrDefault().Password == password)
                    {
                        User.userType = "Laborant";
                        User.Id = context.DataOfLaboratoryAssistants.Where(a => a.Password == password).FirstOrDefault().IdAssistant;
                        //user.userType = User.UserType.Manager;
                        //user.Id = context.DataOfLaboratoryAssistants.Where(a => a.Password == password).FirstOrDefault().IdAssistant;
                        LogIn = true;
                    }
                }
                else if (context.PatientData.Where(a => a.Login == login).FirstOrDefault() != null)
                {
                    if (context.PatientData.Where(a => a.Password == password).FirstOrDefault().Password == password)
                    {
                        User.userType = "Patient";
                        User.Id = context.PatientData.Where(a => a.Password == password).FirstOrDefault().IdPatient;
                        //user.userType = User.UserType.Manager;
                        //user.Id = context.PatientData.Where(a => a.Password == password).FirstOrDefault().IdPatient;
                        LogIn = true;
                    }
                }

                
                    if (FirstTryToEnter)
                    {
                        if (LogIn)
                        {
                            BarcodePage barcodePage = new BarcodePage();
                            this.Close();
                            barcodePage.Show();
                        }
                        else
                        {
                            FirstTryToEnter = false;
                            MessageBox.Show("Аккаунт не найден ");
                            EnterButton.Margin = new Thickness(358, 353, 0, 0);
                            MyCaptcha.Visibility = Visibility.Visible;
                            CaptchaTextBox.Visibility = Visibility.Visible;
                            ButtonAnotherCaptcha.Visibility = Visibility.Visible;
                            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                        }
                    }
                    else
                    {
                        if (LogIn)
                        {
                            BarcodePage barcodePage = new BarcodePage();
                        //barcodePage.avatarImg.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        //  user.pic.GetHbitmap(),
                        //  IntPtr.Zero,
                        //  Int32Rect.Empty,
                        //  BitmapSizeOptions.FromEmptyOptions()
                        //  );
                        this.Close();
                            barcodePage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не найден");
                            EnterButton.Margin = new Thickness(358, 353, 0, 0);
                            MyCaptcha.Visibility = Visibility.Visible;
                            CaptchaTextBox.Visibility = Visibility.Visible;
                            ButtonAnotherCaptcha.Visibility = Visibility.Visible;
                            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
                        }
                    }
            }
            //try
            //{
            //    if (FirstTryToEnter)
            //    {
            //        if (PasswordHidden.Password == "Admin" && LoginTextBox.Text == "Admin")
            //        {
            //            BarcodePage barcodePage = new BarcodePage();
            //            this.Close();
            //            barcodePage.Show();
            //        }
            //        else
            //        {
            //            FirstTryToEnter = false;
            //            MessageBox.Show("Аккаунт не найден ");
            //            EnterButton.Margin = new Thickness(358, 353, 0, 0);
            //            MyCaptcha.Visibility = Visibility.Visible;
            //            CaptchaTextBox.Visibility = Visibility.Visible;
            //            ButtonAnotherCaptcha.Visibility = Visibility.Visible;
            //            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
            //        }
            //    }
            //    else
            //    {
            //        if (PasswordHidden.Password == "Admin" && LoginTextBox.Text == "Admin" && MyCaptcha.CaptchaText == CaptchaTextBox.Text)
            //        {
            //            BarcodePage barcodePage = new BarcodePage();
            //            this.Close();
            //            barcodePage.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Аккаунт не найден");
            //            EnterButton.Margin = new Thickness(358, 353, 0, 0);
            //            MyCaptcha.Visibility = Visibility.Visible;
            //            CaptchaTextBox.Visibility = Visibility.Visible;
            //            ButtonAnotherCaptcha.Visibility = Visibility.Visible;
            //            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
            //        }
            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка!", $"Вы ничего не ввели!");
            //}
            
            
        }
        private void ButtonAnotherCaptcha_Click(object sender, RoutedEventArgs e)
        {
            MyCaptcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 4);
        }
    }
}
