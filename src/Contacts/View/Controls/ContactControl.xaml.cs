using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Хранит допустимые символы.
        /// </summary>
        private static Regex regex = new Regex(@"^[\d\-\+\(\)\s]+$");

        /// <summary>
        /// Создает объект класса <see cref="ContactControl"/>
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
            PhoneNumberTextBox.PreviewTextInput += PhoneNumberTextBox_PreviewTextInput;
            DataObject.AddPastingHandler(PhoneNumberTextBox, PhoneNumberTextBox_Pasting);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = (string)e.DataObject.GetData(typeof(string));

                if (!regex.IsMatch(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// Регистрирует <see cref="IsReadOnly"/>
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(ContactControl),
                new PropertyMetadata(true));

        /// <summary>
        /// Задает и возвращает свойство readonly.
        /// </summary>
        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }
    }
}