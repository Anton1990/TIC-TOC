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






namespace TIC_TOC {




        public class writer{
        
    public void WriteTOC(TextBox a, string stra) {

            a.Text = stra;
        }


        public string CheckVinner(string[] arr1)

        {
            if ((arr1[0] == arr1[1] & arr1[0] == arr1[2]) & (arr1[0] !=""))
            {
                return arr1[0];
                

            }
            if (arr1[3] == arr1[4] & arr1[3] == arr1[5]& (arr1[3] != ""))
            {
                return arr1[3];

            }
            if (arr1[6] == arr1[7] & arr1[6] == arr1[8] &(arr1[6] != ""))
            {
                return arr1[6];

            }


            if ((arr1[0] == arr1[3] & arr1[0] == arr1[6]) & (arr1[0] != ""))
            {
                return arr1[0];


            }
            if (arr1[1] == arr1[4] & arr1[1] == arr1[7] & (arr1[1] != ""))
            {
                return arr1[1];

            }
            if (arr1[2] == arr1[5] & arr1[2] == arr1[8] & (arr1[2] != ""))
            {
                return arr1[2];

            }
            if (arr1[0] == arr1[4] & arr1[0] == arr1[8] & (arr1[0] != ""))
            {
                return arr1[0];

            }
            if (arr1[2] == arr1[4] & arr1[2] == arr1[6] & (arr1[2] != ""))
            {
                return arr1[2];

            }




            return "";

        }


    }







    public partial class MainWindow : Window

{
       
        writer rezult_writer = new writer();
        int cntMouseClick = 0;
        static int vinner_0 = 11;
        static int vinner_X = 0;
        public string VINNER_O;
        int  W1 { get; set; } = vinner_0;





        string[] str1 = new string[9]{ "1", "1", "1", "1", "1", "1", "1", "1", "1" };
    public MainWindow()
        {
            InitializeComponent();
            textBox2.Text = vinner_0.ToString();
            textBox3.Text = vinner_X.ToString();
            //this.DataContext = person;
            DataContext = this;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            cntMouseClick=  cntMouseClick + 1;
            System.Windows.Controls.Primitives.ToggleButton btn = (System.Windows.Controls.Primitives.ToggleButton)sender;
         
          if (btn != null)
            {if (cntMouseClick%2==0)
                btn.Content = "X";
            else
                    btn.Content = "O";
                if (btn.IsChecked == false)
                    btn.Content = "";

              }
            str1[0]= (string)button1.Content;
            str1[1] = (string)button2.Content;
            str1[2] = (string)button3.Content;
            str1[3] = (string)button4.Content;
            str1[4] = (string)button5.Content;
            str1[5] = (string)button6.Content;
            str1[6] = (string)button7.Content;
            str1[7] = (string)button8.Content;
            str1[8] = (string)button9.Content;

            rezult_writer.CheckVinner(str1);
           // rezult_writer.WriteTOC(this.textBox1, rezult_writer.CheckVinner(str1));

            if (rezult_writer.CheckVinner(str1) == "X" || cntMouseClick > 8 || rezult_writer.CheckVinner(str1) == "O")
            {
                buttonNew.IsEnabled = true;
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
                button4.IsEnabled = false;
                button5.IsEnabled = false;
                button6.IsEnabled = false;
                button7.IsEnabled = false;
                button8.IsEnabled = false;
                button9.IsEnabled = false;





            }
            if (rezult_writer.CheckVinner(str1) == "X") {

                vinner_X = vinner_X + 1;
                W1 = W1 + 1;
            }

            if (rezult_writer.CheckVinner(str1) == "O")
            {

                vinner_0 = vinner_0 + 1;
            }
            textBox2.Text = vinner_0.ToString();
            textBox3.Text = vinner_X.ToString();

        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
            textBox2.Text = vinner_0.ToString();
            textBox3.Text = vinner_X.ToString();

        }
    }
}
