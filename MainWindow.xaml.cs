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

namespace JR_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Random random = new Random();
        List<Button> buttons;
        int[] blueBtns = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public MainWindow()
        {
            InitializeComponent();

            buttons = new List<Button>();
            ButtonInit();
        }

        public void ButtonInit()
        {
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(btn10);
            buttons.Add(btn11);
            buttons.Add(btn12);
            buttons.Add(btn13);
            buttons.Add(btn14);
            buttons.Add(btn15);
            buttons.Add(btn16);
        }

        public void GenerateBlue()
        {
            for (int i = 0; i < random.Next(3, 6); i++)
            {
                int bluePos = random.Next(blueBtns.Length);
                if (blueBtns[bluePos] != 1)
                {
                    blueBtns[bluePos] = 1;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
