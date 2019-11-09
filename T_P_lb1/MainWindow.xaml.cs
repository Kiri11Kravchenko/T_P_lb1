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
using System.Collections;
using Microsoft.Win32;
using System.Windows.Controls.Primitives;
using System;

namespace T_P_lb1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] myAL_g;
        HistoForm f = new HistoForm();
        public void gen(int a,int b,int [] array)
        {
            Random rnd1 = new Random();
            int num;
          //  array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                num = a + rnd1.Next(b);
                array[i] = num;
            }
            
        }
        public void btn1_click()
        {
            ArrayList myAL = new ArrayList();
            int index;
            try
            {
                int itemCount;
                try
                {
                    itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {

                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        int number;
                        lbMain.Items.Clear();
                        gen(0, 200, myAL_g);
                       
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL_g[index];
                            f.val[index] = number;
                            myAL.Add(number);
                            lbMain.Items.Add(number);
                        }
                       
                    }
                }

                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }



            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btn2_click()
        {
            ArrayList myAL = new ArrayList();
            int index;
            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                        Random rnd1 = new Random();
                        int number;
                        lbMain.Items.Clear();
                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        gen(0, 200, myAL_g);
                        
                        lbMain.Items.Add("Исходный массив");
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL_g[index];
                            f.val[index] = number;
                            myAL.Add(number);
                            lbMain.Items.Add(number);
                        }
                        myAL.Sort();
                        lbMain.Items.Add("Отсортированный массив");
                        foreach (int elem in myAL)
                        {
                            lbMain.Items.Add(elem);
                        }
                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz1_click()
        {
            int[] myAL;
            int index;

            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                        Random rnd1 = new Random();
                        int number;
                        int k = 0;
                        lbMain.Items.Clear();
                        myAL = new int[itemCount];
                        f.val = new int[itemCount];
                        myAL_g = new int[itemCount];
                        gen(0, 200, myAL);
                        
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL[index];
                             myAL_g[index] = number;
                            f.val[index] = number;
                            lbMain.Items.Add(number);
                        }
                        for (int i = 1; i < itemCount - 1; i++)
                        {
                            if (myAL[i] > myAL[i - 1] && myAL[i] > myAL[i + 1])
                            {
                                k++;
                            }

                        }
                        if (myAL[0] > myAL[1] && myAL[0] > myAL[itemCount - 1])
                        {
                            k++;
                        }
                        if (myAL[itemCount - 1] > myAL[0] && myAL[itemCount - 1] > myAL[itemCount - 2])
                        {
                            k++;
                        }
                        lbMain.Items.Add("Кол-во элементов больше своих соседей");
                        lbMain.Items.Add(k);
                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz2_click()
        {
            int[] myAL;
            int index;

            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                        
                        int number;
                        bool k = false;
                        lbMain.Items.Clear();
                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        myAL = new int[itemCount];
                        gen(0, 200, myAL);
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL[index];
                            
                            myAL_g[index] = number;
                            f.val[index] = number;
                            lbMain.Items.Add(number);
                        }
                        for (int i = 0; i < itemCount; i++)
                        {
                            if (myAL[i] > 25)
                            {
                                k = true;
                            }
                            if (k == true)
                            {
                                lbMain.Items.Add("Индекс элемента, большего 25");
                                lbMain.Items.Add(i);
                                break;
                            }

                        }
                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz3_click()
        {
            int[] myAL;
            int index;

            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                       
                        int number;
                        int sum = 0;
                        lbMain.Items.Clear();
                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        myAL = new int[itemCount];
                        gen(0, 200, myAL);
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL[index];
                            
                            myAL_g[index] = number;
                            f.val[index] = number;
                            lbMain.Items.Add(number);
                        }
                        for (int i = 0; i < itemCount; i++)

                        {
                            sum += myAL[i];
                            if (myAL[2] < sum)
                            {
                                lbMain.Items.Add("Сумма элементов, больше чем 2-й");
                                lbMain.Items.Add(sum);
                                break;
                            }
                        }

                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz4_click()
        {
            int index;

            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                        
                        int number;

                        lbMain.Items.Clear();
                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        gen(0, 200, myAL_g);
                        for (index = 0; index < itemCount; index++)
                        {
                            number = myAL_g[index];
                            
                            f.val[index] = number;
                            lbMain.Items.Add(number);
                        }
                        InputBox.Visibility = System.Windows.Visibility.Visible;

                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz5_click()
        {
            int index;

            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                       
                        int number;

                        lbMain.Items.Clear();
                        myAL_g = new int[itemCount];
                        f.val = new int[itemCount];
                        gen(0, 200, myAL_g);
                        for (index = 0; index < itemCount; index++)
                        {
                            number =  myAL_g[index];
                           
                            f.val[index] = number;
                            lbMain.Items.Add(number);
                        }
                        InputBox1.Visibility = System.Windows.Visibility.Visible;

                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        public void btnz6_click()
        {
            int[] myAL;
            int index;
            try
            {
                try
                {
                    int itemCount = Convert.ToInt32(tbN.Text);
                    if (itemCount < 0)
                    {
                        MessageBox.Show("Введите положителное число!");
                    }
                    else
                    {
                       
                        myAL = new int[itemCount];
                        f.val = new int[itemCount];
                        gen(0, 200, myAL);
                        int number;
                        lbMain.Items.Clear();
                        for (index = 0; index < itemCount; index++)
                        {
                            number=myAL[index];

                            f.val[index] = number;
                        }
                        for (int i = 1; i < itemCount - 1; i++)
                        {

                            if (myAL[i] > myAL[i - 1] && myAL[i] > myAL[i + 1])
                            {
                                ListBoxItem item = new ListBoxItem();
                                item.Content = Convert.ToString(myAL[i]);
                                item.Foreground = Brushes.Black;
                                item.Background = Brushes.LightSkyBlue;
                                lbMain.Items.Add(item);
                            }

                            lbMain.Items.Add(myAL[i]);

                        }

                    }
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Выход за пределы типа !");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }
        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            btn1_click();
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            btn2_click();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_z1_Click(object sender, RoutedEventArgs e)
        {
            btnz1_click();
        }

        private void Btn_z2_Click(object sender, RoutedEventArgs e)
        {
            btnz2_click();
        }

        private void Btn_z3_Click(object sender, RoutedEventArgs e)
        {
            btnz3_click();
        }

        private void Btn_z4_Click(object sender, RoutedEventArgs e)
        {

            btnz4_click();
        }
        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int K = Convert.ToInt32(InputTextBox.Text);
                int size = myAL_g.Length;
                bool check = false;
                for (int i = 0; i < size; i++)
                {
                    if (myAL_g[i] > K)
                    {
                        check = true;
                    }
                    if (check == true)
                    {
                        lbMain.Items.Add("номер первого элемента большего" + K);
                        lbMain.Items.Add(i);
                        break;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show(" номер первого элемента большего " + K + " не существут ");
                }
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            InputTextBox.Text = String.Empty;
        }

        private void YesButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int K = Convert.ToInt32(InputTextBox1.Text);

                int size = myAL_g.Length;
                if (K > size || K < 0)
                {

                    MessageBox.Show("Такого номера не существует !");

                    InputTextBox1.Text = "";

                }
                else
                {
                    bool check = false;
                    int count = 0;
                    for (int i = 0; i < size; i++)
                    {
                        count += myAL_g[i];
                        if (myAL_g[K] < count)
                        {
                            check = true;
                        }
                        if (check == true)
                        {
                            lbMain.Items.Add("Сумма элементов больше чем " + K);
                            lbMain.Items.Add(count);
                            break;
                        }
                    }
                    if (check == false)
                    {
                        MessageBox.Show("Сумма элементов больше чем " + K + "не существует");
                    }
                    InputBox1.Visibility = System.Windows.Visibility.Collapsed;

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите число без вещественной части!");
            }
        }

        private void NoButton1_Click(object sender, RoutedEventArgs e)
        {
            InputBox1.Visibility = System.Windows.Visibility.Collapsed;
            InputTextBox1.Text = String.Empty;
        }

        private void Btn_z5_Click(object sender, RoutedEventArgs e)
        {
            btnz5_click();
        }

        private void Btn_z6_Click(object sender, RoutedEventArgs e)
        {
            btnz6_click();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            double p = 1.0 / myAL_g.Length;
            int len = myAL_g.Length;
            double sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += myAL_g[i] * p;
            }
            for(int i = 0; i < len; i++)
            {
                if (myAL_g[i] > sum)
                {
                    lbMain.Items.Add("Номер элемента большего мат ожидания");
                    lbMain.Items.Add(i + 1);
                    break;

                }
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int len = myAL_g.Length;
            for(int i = 01; i < len; i++)
            {
                if (myAL_g[i-1] < myAL_g[i])
                {
                    sum++;
                }
            }
            if (myAL_g[len - 1] < myAL_g[0])
            {
                sum++;
            }
            lbMain.Items.Add("Количество элементов образующих упорядоченную последовательность");
            lbMain.Items.Add(sum);


        }
         int neibors(int []a)
        {
            int n = a.Length;
            int count = 0;
            for(int i = 1; i < n-1; i++)
            {
                if (a[i-1] < a[i] && a[i] > a[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            f.flag = true;
            this.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            if (f.val == null)
            {
                MessageBox.Show("Нет данных для вывода!");
            }
            else
            {

                f.Show();
                f.Refresh();
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Add("text");
            lbMain.Items.Add(neibors(myAL_g));
        }
    }
}
    

