using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miilionare
{
    /* Класс, хранящий в себе данные об окне,
     * в котором отображается игра, а также 
     * показываются вопросы и анализируютсяс ответы игрока
     * 
     * @author Krikun
     * @Version 1.0.1.1
     * @copyright delited
     * @ todo реализовать все функции
     */
    public partial class Form1 : Form
    {
        /* Уровень вопроса
         * только целые числа, стартовое значение и после сброса - 1
         * ответственна за сложность вопроса и размер награды за вопрос
         * 
         * @var int q;
         */
        int q;
        /* Массив наград за каждый уровень вопроса
         * Только целые числа, неизменны по ходу игры
         * 
         * @var int[] reward;
         */
        int[] reward = new int[15];

        /* Выигрыш игрока
         * только целые числа, стартовое значение и после сброса - 0
         * показывает объем выигрыша игрока
         * 
         * @var int gain;
         */
        int gain;

        /* Инициализация окна и компонентов класса,
         * установление стартовых значений для уровня вопроса и выигрыша
         * 
         * @param q - уровень вопроса
         *        gain - размер выигрыша
         * @return инициализированное окно и первый вопрос
         */

        int answ;
        public Form1()
        {
            q=1;
            gain = 0;
            InitializeComponent();
            getQuest(q);
        }

        void getQuest(int q)
        {
            string[] F = File.ReadAllLines(@"Questions\1quest\1.txt");
            Question.Text = F[0];
            answ = 1;
            Answ1.Text = F[1];
            Answ2.Text = F[2];
            Answ3.Text = F[3];
            Answ4.Text = F[4];
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            if (answ == 1)
                if (Answ1.Checked == true)
                {
                    MessageBox.Show("Правильно!", "Результат");
                    gain += 1000;
                    Money.Text = gain.ToString();
                }
                else
                {
                    MessageBox.Show("Не правильно", "Результат");
                    gain = 0;
                    Money.Text = gain.ToString();
                }
            if (answ == 2)
                if (Answ2.Checked == true)
                {
                    MessageBox.Show("Правильно!", "Результат");
                    gain += 1000;
                    Money.Text = gain.ToString();
                }
                else
                {
                    MessageBox.Show("Не правильно", "Результат");
                    gain = 0;
                    Money.Text = gain.ToString();
                }
            if (answ == 3)
                if (Answ3.Checked == true)
                {
                    MessageBox.Show("Правильно!", "Результат");
                    gain += 1000;
                    Money.Text = gain.ToString();
                }
                else
                {
                    MessageBox.Show("Не правильно", "Результат");
                    gain = 0;
                    Money.Text = gain.ToString();
                }
            if (answ == 4)
                if (Answ4.Checked == true)
                {
                    MessageBox.Show("Правильно!", "Результат");
                    gain += 1000;
                    Money.Text = gain.ToString();
                }
                else
                {
                    MessageBox.Show("Не правильно", "Результат");
                    gain = 0;
                    Money.Text = gain.ToString();
                }
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            q = 1;
            gain = 0;
            Money.Text = gain.ToString();
            MessageBox.Show("Спасибо за игру", "Завершено");
            getQuest(q);
        }
    }
}
