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

namespace lab3WPF
{
    /// <summary>
    /// Логика взаимодействия для userInter.xaml
    /// </summary>
    public partial class userInter : UserControl
    {
        public userInter()
        {
            InitializeComponent();
        }
        public  void lik_Click()
        {
            _1p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/2.png"));
            _1p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/2.png"));
            _1p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/2.png"));
            _2p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/3.png"));
            _2p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/3.png"));
            _2p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/3.png"));
            _3p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/3.png"));
            _3p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/1.png"));
            _3p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyL/3.png"));
            fone.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/berdsk.jpg"));
            mainpic.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/Likh.jpg"));

            stat.Text = "I really tired doing it... I want it working... But! That was the most interesting work i have ever done in design!";
            name_changed.Text = "Andrey Likhnitskiy";
            visiting.Text = "last visit: 16:53 yesterday";
        }
        public void iv_Click()
        {
            _1p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/2.png"));
            _1p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/2.png"));
            _1p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/2.png"));
            _2p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/3.jpg"));
            _2p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/3.jpg"));
            _2p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/3.jpg"));
            _3p1.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/3.jpg"));
            _3p2.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/1.jpg"));
            _3p3.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/AndreyI/3.jpg"));
            fone.Source = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/mirnyi.jpg"));
            stat.Text = "This work was reaaly interesting! i got a lot of new information!!!";
            name_changed.Text = "Andrey Ivanov";
            visiting.Text = "last visit: 23:47 Monday";
            mainpic.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Images/ivanov.jpg"));
        }
    }
}
