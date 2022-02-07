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
using System.Data;

namespace BasicCalculator
{
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        //Adds the content of the button to the text.
        private void button_Click(object sender, RoutedEventArgs e)
        {          
            Button button = (Button)sender;
            text.Text += button.Content.ToString();          
        }
        //When equal button pressed
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            //dataTable.Compute function to perform operations
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(text.Text);
            try
            {
                double result = Convert.ToDouble(dataTable.Compute(text.Text.ToString(), ""));
                text.Text = result.ToString();

            }catch(Exception ex)
            {
                text.Text = "ERROR!!";
            }
        }
        // Converts number to +/-
        private void plusminus_Click(object sender, RoutedEventArgs e)
        {
            text.Text = (double.Parse(text.Text) * -1).ToString();
        }
        //Clears text.
        private void ce_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }
        //Calculates the multiplication 
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            text.Text += "*"; //Adds the multiplication symbol * to the text instead of X
        }
        //calculates the remainder.
        private void remainder_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            text.Text += "%";
        }
        //Calculates the sine of the given angle.
        private void sin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double res = Math.Round(Math.Sin(Convert.ToDouble(text.Text) * Convert.ToDouble(System.Math.PI / 180)),3);
                text.Text = res.ToString();
            }
            catch(Exception ex)
            {
                text.Text = "ENTER THE NUMBER FIRST";
            }
        }
        //Adds pinumber to the text.
        private void pi_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "3.141592654";
        }
        //calculating square root of number
        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double res =Math.Round(Math.Sqrt(Convert.ToDouble(text.Text)),3);
                text.Text = res.ToString();
            }
            catch (Exception ex)
            {
                text.Text = "ENTER THE NUMBER FIRST";
            }
        }
        //calculating power of number
        private void pow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double res = Math.Round(Math.Pow(Convert.ToDouble(text.Text),2),3);
                text.Text = res.ToString();
            }
            catch (Exception ex)
            {
                text.Text = "ENTER THE NUMBER FIRST";
            }
        }
    }
}
