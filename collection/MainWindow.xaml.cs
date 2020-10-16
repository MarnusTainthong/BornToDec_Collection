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

namespace collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        Hashtable hashtable;
        SortedList sortedList;
        Stack stack;
        Queue queue;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
            hashtable = new Hashtable();
            sortedList = new SortedList();
            stack = new Stack();
            queue = new Queue();

        }

        // ArrayList

        private void btnShowAll1_Click(object sender, RoutedEventArgs e)
        {
            
            if(arrayList.Count == 0)
            {
                MessageBox.Show("Empty data!");
            }
            else
            {
                foreach (int data in arrayList)
                {
                    MessageBox.Show(data.ToString());
                }
            }
            tbInputData.Clear();

        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(int.Parse(tbInputData.Text));
            tbInputData.Clear();
            MessageBox.Show("Add complete");
        }

        private void btnRemove1_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(int.Parse(tbInputData.Text));
            tbInputData.Clear();
            MessageBox.Show("Remove complete");
        }

        // HashTables

        private void btnAddHash_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(tbInputKey.Text, tbInputValue.Text);
            tbInputKey.Clear();
            tbInputValue.Clear();
        }

        private void btnRemoveHash_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(tbInputKey.Text);
            tbInputKey.Clear();
        }

        private void btnShowAllHash_Click(object sender, RoutedEventArgs e)
        {
            if(hashtable.Count != 0)
            {
                ICollection icollection = hashtable.Keys;
                foreach (string key in icollection)
                {
                    MessageBox.Show(hashtable[key].ToString());
                }
            }
            else
            {
                MessageBox.Show("Hashtable Empty!");
            }
            
        }

        // SortedList
        private void btnAddSortList_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(tbInputKeySortList.Text,tbInputValueSortList.Text);
            tbInputKeySortList.Clear();
            tbInputValueSortList.Clear();
        }

        private void btnRemoveSortList_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Remove(tbInputKeySortList.Text);
            tbInputKeySortList.Clear();
        }

        private void btnShowAllSortList_Click(object sender, RoutedEventArgs e)
        {
            
            if(sortedList.Count == 0)
            {
                MessageBox.Show("Empty Data!");
            }
            else
            {
                ICollection icollection = sortedList.Keys;
                foreach (string key in icollection)
                {
                    MessageBox.Show("key["+key+"] "+sortedList[key].ToString());
                }
            }
        }

        private void btnPushStack_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(tbInputValueStack.Text);
            tbInputValueStack.Clear();
        }

        private void btnPopStack_Click(object sender, RoutedEventArgs e)
        {
            stack.Pop();
        }
        private void btnShowAllStack_Click(object sender, RoutedEventArgs e)
        {
            if(stack.Count != 0)
            {
                string showData = "";
                int count = stack.Count;
                foreach (string data in stack)
                {
                    showData += "[" + count + "] ";
                    showData += data;
                    showData += "\n";
                    count--;
                }
                MessageBox.Show(showData);
            }
            else
            {
                MessageBox.Show("Stack Empty!");
            }
            
        }

        private void btnEnQueues_Click(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(tbInputValueQueues.Text);
            tbInputValueQueues.Clear();
        }

        private void btnDeQueues_Click(object sender, RoutedEventArgs e)
        {
            queue.Dequeue();
            tbInputValueQueues.Clear();
        }

        private void btnShowAllQueues_Click(object sender, RoutedEventArgs e)
        {
            if(queue.Count != 0)
            {
                string showData = "";
                int count = 1;
                foreach (string data in queue)
                {
                    showData += "[" + count + "] ";
                    showData += data;
                    showData += "\n";
                    count++;
                }
                MessageBox.Show(showData);
            }
            else
            {
                MessageBox.Show("Queue Empty!");
            }
            
        }
    }
}
