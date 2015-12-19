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

namespace IndTask
{
    /// <summary>
    /// Логика взаимодействия для BusinessCard.xaml
    /// </summary>
    public partial class BusinessCard : UserControl
    {
        public static DependencyProperty PersonalNameProperty;
        public static DependencyProperty EmailProperty;
        public static DependencyProperty PhoneProperty;
        public static DependencyProperty ImagePathProperty;
        string phoneString = "Phone: ";
        static BusinessCard()
        {
            PersonalNameProperty = DependencyProperty.Register("Personal Name", typeof(string), typeof(BusinessCard));
            EmailProperty = DependencyProperty.Register("E-mail", typeof(string), typeof(BusinessCard));
            PhoneProperty = DependencyProperty.Register("Phone number", typeof(string), typeof(BusinessCard));
            ImagePathProperty = DependencyProperty.Register("Image source", typeof(ImageSource), typeof(BusinessCard));
        }
        public BusinessCard()
        {
            InitializeComponent();
        }
        public string PersonalName
        {
            get 
            { 
                return (string)GetValue(PersonalNameProperty); 
            }
            set 
            {
                persName.Text = value;
                SetValue(PersonalNameProperty, value); 
            }
        }
        public string Email
        {
            get
            {
                return (string)GetValue(EmailProperty);
            }
            set
            {
                email.Text = value;
                SetValue(EmailProperty, value);
            }
        }
        public string Phone
        {
            get
            {
                return (string)GetValue(PhoneProperty);
            }
            set
            {
                phone.Text = phoneString + value;
                SetValue(PhoneProperty, value);
            }
        }

        public ImageSource ImagePath
        {
            get
            {
                return (ImageSource)GetValue(ImagePathProperty);
            }
            set
            {
                img.Source = value;
                SetValue(ImagePathProperty, value);
            }
        }
    }
}
