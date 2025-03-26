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
        if (e.Key < System.Windows.Input.Key.D0 || e.Key > System.Windows.Input.Key.D9)
        {
            e.Handled = true;
        }
    }

    // Button Click event handler for Show Time button
    private void btnShowTime_Click(object sender, RoutedEventArgs e)
    {
        DateTime currentTime = DateTime.Now;
        MessageBox.Show($"Current Time: {currentTime.ToString("HH:mm:ss")}", "Current Time");
    }
}