using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Button Click event handler for Submit button
    private void btnSubmit_Click(object sender, RoutedEventArgs e)
    {
        string name = txtName.Text;
        string color = (comboColors.SelectedItem as ComboBoxItem)?.Content.ToString();
        bool isAgreed = chkAgree.IsChecked ?? false;

        txtMessage.Text = $"Hello {name}, you selected {color}. Agreed: {isAgreed}.";
    }

    // Button Click event handler for Reset button
    private void btnReset_Click(object sender, RoutedEventArgs e)
    {
        txtName.Clear();
        comboColors.SelectedIndex = -1;
        chkAgree.IsChecked = false;
        txtMessage.Text = "Please enter your details.";
    }

    // KeyDown event handler for numeric TextBox
    private void txtNumeric_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        // Allow backspace, delete, and numeric keys
        if (e.Key == System.Windows.Input.Key.Back || e.Key == System.Windows.Input.Key.Delete ||
            (e.Key >= System.Windows.Input.Key.D0 && e.Key <= System.Windows.Input.Key.D9) ||
            (e.Key >= System.Windows.Input.Key.NumPad0 && e.Key <= System.Windows.Input.Key.NumPad9)) //Test this later
        {
            // Allow the key press if it's a number or allowed control key
            return;
        }

        // If the key pressed is not numeric or allowed control, show an error
        e.Handled = true; // Block the invalid key
        MessageBox.Show("Only Numbers Are Allowed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    // Button Click event handler for Show Time button
    private void btnShowTime_Click(object sender, RoutedEventArgs e)
    {
        DateTime currentTime = DateTime.Now;
        MessageBox.Show($"Current Time: {currentTime.ToString("HH:mm:ss")}", "Current Time");
    }

    private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        //Add a value changed even for slider control
    }
}