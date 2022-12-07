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
        int[] buttonNums;
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
            foreach(Button btn in buttons)
            {
                btn.Background = Brushes.OrangeRed;
            }
        }

        public void GenerateBlue()
        {
            int buttonNumCount = 0;
            int blueAmt = random.Next(3, 6);
            buttonNums = new int[blueAmt];
            for (int i = 0; i < blueAmt; i++)
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

            for(int i = 0; i < blueBtns.Length; i++)
            {
                if (blueBtns[i] == 1)
                {
                    buttonNums[buttonNumCount] = random.Next(1, 4);
                    buttons[i].Background = Brushes.Blue;
                    buttons[i].Content = buttonNums[buttonNumCount];
                    buttonNumCount++;
                }
            }
        }

        public void GeneratePuzzle(int buttonNum)
        {
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GenerateBlue();
        }
    }
}
