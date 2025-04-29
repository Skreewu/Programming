using System.Windows;
using System.Windows.Controls;
using View.Model;

namespace View.Controls
{
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CurrentContactProperty =
            DependencyProperty.Register("CurrentContact", typeof(Contact), typeof(ContactControl),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Contact CurrentContact
        {
            get => (Contact)GetValue(CurrentContactProperty);
            set => SetValue(CurrentContactProperty, value);
        }
            
        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(ContactControl),
                new PropertyMetadata(true));

        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }
    }
}