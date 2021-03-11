using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            q=1;
            gain = 0;
            InitializeComponent();
        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }
    }
}
