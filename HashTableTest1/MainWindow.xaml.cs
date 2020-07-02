using System;
using System.Collections;
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

namespace HashTableTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashTable;

        public MainWindow()
        {
            InitializeComponent();
            hashTable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(keyTxt.Text) || String.IsNullOrEmpty(valTxt.Text))
            {
                MessageBox.Show("Please input data before Add");
            }
            else
            {
                //Add data
                hashTable.Add(keyTxt.Text,valTxt.Text);
                keyTxt.Clear();
                valTxt.Clear();
                MessageBox.Show("Completed");
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if(String.IsNullOrEmpty(keyTxt.Text))
            {
                MessageBox.Show("Please input data for Delete or data not have");
            }
            else
            {
                int i = 0; // keep array count
                string inText = keyTxt.Text;
                //Icollection importance
                ICollection icollection = hashTable.Keys;
                foreach (string key in icollection)
                {
                    if (key == inText)
                    {
                        i++;
                    }
                }
                if(i>0)
                {
                    hashTable.Remove(inText);
                    keyTxt.Clear();
                    valTxt.Clear();
                    MessageBox.Show("Already Remove");
                }
                else
                {
                    MessageBox.Show(inText + " Data not found");
                }
            }
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hashTable.Count == 0)
            {
                MessageBox.Show("Data not found");
            }
            else
            {
                    int i = 1;
                ICollection icollection = hashTable.Keys;
                foreach (string key in icollection)
                {
                    MessageBox.Show(hashTable[key].ToString());
                    i++;
                }
            }
        }
    }
}
