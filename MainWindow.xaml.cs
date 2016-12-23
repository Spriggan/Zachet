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
using System.Web;

namespace WpfApplication2
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
        public bool array_created = false;
        public Int32[] array;
        public Random rand = new Random();
        private void but_arr_gen_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb1.Text + "Генерация массива..." + Environment.NewLine;
            Array.Resize(ref array, 10);
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(-10, 20);
            }
            array_created = true;
            for (int i = 0; i < 10; i++)
            {
                tb1.Text = tb1.Text + "Элемент №" + i + ": " + array[i] + Environment.NewLine;
            }
            tb1.Text = tb1.Text + "Генерация массива завершена." + Environment.NewLine;
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 1: " + Environment.NewLine + "Дан массив из n чисел. Сколько элементов массива больше своих «соседей»,­ т.е. предыдущег­о и последующе­го. Первый и последний элементы не рассматрив­ать." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (array[i] > array[i + 1])
                    {
                        counter++;
                    }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 4: " + Environment.NewLine + "Определить­, превосходи­т ли первый элемент массива из десяти чисел среднее значение элементов этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            Int32 sum = array.Sum() / array.Length;
            string counter;
            if (array[0] > sum)
            {
                counter = "Превосходит.";
            }
            else
            {
               counter = "Не прквосходит.";
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Среднее арифмет.: " + sum +". Вердикт: " + counter + Environment.NewLine;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 5: " + Environment.NewLine + "Дан массив из 10 чисел. Определить­ сколько раз меняется знак у его элементов." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    if (array[i-1] <0 )
                    {
                        counter++;
                    }
                }
                else
                    if (array[i] < 0)
                    {
                        if (array[i - 1] > 0)
                        {
                            counter++;
                        }
                    }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 6: " + Environment.NewLine + "Найти, сколько элементов массива из 10 чисел больше, чем четвертый элемент этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[3])
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 7: " + Environment.NewLine + "Найти сумму элементов массива из 10 чисел, меньших, чем 21." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 21)
                {
                    counter=counter+array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 8: " + Environment.NewLine + "Дан массив из 10 чисел. Увеличить на единицу значения всех элементов кратных 5." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 5)==0)
                {
                    array[i] = array[i] + 1;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Вывод массива: " + Environment.NewLine;
            for (int i = 0; i < 10; i++)
            {
                tb1.Text = tb1.Text + "Элемент №" + i + ": " + array[i] + Environment.NewLine;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            int counter=0;
            tb1.Text = tb1.Text + "Задание 9: " + Environment.NewLine + "Для массива из 10 целых чисел подчитать сумму элементов,­ значения которых не кратны 3." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 3) != 0)
                {
                    counter = counter + array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter+ Environment.NewLine;
        }

        private void but10_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 10: " + Environment.NewLine + "Для массива из десяти чисел подсчитать­, сколько чисел меньше первого элемента массива и одновремен­но больше последнего­ элемента." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] >array[array.Length-1])
                {
                    if (array[i] < array[0])
                    {
                        counter++;
                    }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;
        }

        private void but12_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 12: " + Environment.NewLine + "Дан массив из 10 разных чисел. Найти элемент, меньше всего отличающий­ся от второго. Указание: функция абсолютной­ величины – ABS." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int default_dif = Math.Abs(array[1]-array[0]);
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] !=array[1] )
                {
                    int temp =Math.Abs(array[1]-array[i]);
                    if (temp < default_dif)
                    { counter = i; }
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;
        }

        private void but11_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 11: " + Environment.NewLine + "Дан массив из 10 чисел. Подсчитать­ количество­ не отрицатель­ных элементов массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    counter++; 
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;
        }

        private void but13_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 13: " + Environment.NewLine + "Дан массив из 10 чисел. Подсчитать­ количество­ не нулевых элементов массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;

        }

        private void but14_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 14: " + Environment.NewLine + "В массиве из 10 целых чисел подсчитать­ количество­ элементов,­ кратных 3." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    counter++;
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Количество: " + counter + Environment.NewLine;
        }

        private void but15_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 15: " + Environment.NewLine + "Найти сумму элементов массива из 10 чисел, меньших, чем 5-й элемент этого массива." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<array[4])
                {
                    counter=counter+array[i];
                }
            }
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
            tb1.Text = tb1.Text + "Сумма: " + counter + Environment.NewLine;
        }

        private void but16_Click(object sender, RoutedEventArgs e)
        {
            if (array_created == false)
            {
                tb1.Text = tb1.Text + "Err#1. Проведетие генерацию массива" + Environment.NewLine;
                return;
            }
            tb1.Text = tb1.Text + "Задание 16: " + Environment.NewLine + "Отобразить массив виде гистораммы." + Environment.NewLine + "Выполнение..." + Environment.NewLine;
            Form1 f = new Form1();
            int[] array_Y = new int[10];
            array_Y[0] = -10;
            for (int i = 1; i < 10; i++)
            {
                array_Y[i] = array_Y[i - 1] + 3;
            }
            f.chart1.Series["Элементы массива"].Points.DataBindXY(array_Y, array);
            f.ShowDialog();
            tb1.Text = tb1.Text + "Выполнено... " + Environment.NewLine;
        }
    }
}
