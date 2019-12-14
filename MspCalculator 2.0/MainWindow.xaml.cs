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
using MahApps.Metro.Controls;
namespace MspCalculator
{
    public partial class MainWindow : MetroWindow
    {
        String Number1 = null, Number2 = null, Flag = null , Number3 = null , Number4 = null , Number5 = null;
        int Symbol_Plus_Minus_Change = 0 , Symbol_DorpChange=0  ;

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null && Number1 == null && Number2 == null)
            {
                Count.Content = "0";
            }
            else if (Flag == null && Number1 != null && Number2 == null)
            {
                Number1 = Number1 + "0";
                Count.Content = Number1;
            }
            else if (Flag != null && Number1 != null && Number2 == null)
            {
                Count.Content = "0";
            }
            else if (Flag != null && Number1 != null  && Number2 != null)
            {
                Number2 = Number2 + "0";
                Count.Content = Number2;
            }
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "1";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "1";
                Count.Content = Number2;
            }

        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "2";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "2";
                Count.Content = Number2;
            }
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "4";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "4";
                Count.Content = Number2;
            }
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "5";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "5";
                Count.Content = Number2;
            }
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "6";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "6";
                Count.Content = Number2;
            }
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "7";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "7";
                Count.Content = Number2;
            }
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "8";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "8";
                Count.Content = Number2;
            }
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "9";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "9";
                Count.Content = Number2;
            }
        }

        private void Symbol_Plus_Click(object sender, RoutedEventArgs e)
        {
            Flag = "+";
            Operator.Content = "+";
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Number3 = null;
            Number4 = null;
            Symbol_Plus.IsEnabled = false;
            Symbol_Remainder.IsEnabled = false;
            Symbol_Multiply.IsEnabled = false;
            Symbol_Minus.IsEnabled = false;
            Symbol_Except.IsEnabled = false;
        }

        private void Symbol_Minus_Click(object sender, RoutedEventArgs e)
        {
            Flag = "-";
            Operator.Content = "-";
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Number3 = null;
            Number4 = null;
            Symbol_Plus.IsEnabled = false;
            Symbol_Remainder.IsEnabled = false;
            Symbol_Multiply.IsEnabled = false;
            Symbol_Minus.IsEnabled = false;
            Symbol_Except.IsEnabled = false;
        }

        private void Symbol_Multiply_Click(object sender, RoutedEventArgs e)
        {
            Flag = "*";
            Operator.Content = "*";
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Number3 = null;
            Number4 = null;
            Symbol_Plus.IsEnabled = false;
            Symbol_Remainder.IsEnabled = false;
            Symbol_Multiply.IsEnabled = false;
            Symbol_Minus.IsEnabled = false;
            Symbol_Except.IsEnabled = false;
        }

        private void Symbol_Except_Click(object sender, RoutedEventArgs e)
        {
            Flag = "/";
            Operator.Content = "/";
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Number3 = null;
            Number4 = null;
            Symbol_Plus.IsEnabled = false;
            Symbol_Remainder.IsEnabled = false;
            Symbol_Multiply.IsEnabled = false;
            Symbol_Minus.IsEnabled = false;
            Symbol_Except.IsEnabled = false;
        }

        private void Symbol_Remainder_Click(object sender, RoutedEventArgs e)
        {
            Flag = "%";
            Operator.Content = "%";
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Number3 = null;
            Number4 = null;
            Symbol_Plus.IsEnabled = false;
            Symbol_Remainder.IsEnabled = false;
            Symbol_Multiply.IsEnabled = false;
            Symbol_Minus.IsEnabled = false;
            Symbol_Except.IsEnabled = false;
        }

        private void Symbol_Dorp_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null && Symbol_DorpChange == 0 && Number1 == null)
            {
                Number4 = "0";
                Symbol_DorpChange = 1;
                Number1 = Number1 + "0.";
                Count.Content = Number1;
            }
            else if (Flag == null && Symbol_DorpChange ==0 && Number1 != null)
            {
                Number4 = Number1;
                Symbol_DorpChange = 1;
                Number1 = Number1 + ".";
                Count.Content = Number1;
            }
            else if (Flag == null && Symbol_DorpChange == 1 && Number1 != null)
            {
                Symbol_DorpChange = 1;
                Number1 = Number4 + ".";
                Count.Content = Number1;
            }
            else if (Flag != null && Symbol_DorpChange == 0 && Number2 == null)
            {
                Number4 = "0";
                Symbol_DorpChange = 1;
                Number2 = Number2 + "0.";
                Count.Content = Number2;
            }
            else if (Flag != null && Symbol_DorpChange == 0 && Number2 != null)
            {
                Number4 = Number2;
                Symbol_DorpChange = 1;
                Number2 = Number2 + ".";
                Count.Content = Number2;
            }
            else if (Flag != null && Symbol_DorpChange == 1 && Number2 != null)
            {
                Symbol_DorpChange = 1;
                Number2 = Number4 + ".";
                Count.Content = Number2;
            }
        }

        private void Symbol_C_Click(object sender, RoutedEventArgs e)
        {
            Symbol_DorpChange = 0;
            Symbol_Plus_Minus_Change = 0;
            Histroy.Content = "";
            Operator.Content = "";
            ResultExport.Content = "";
            Count.Content = "";
            Number1 = null;
            Number2 = null;
            Flag = null;
            Symbol_Plus.IsEnabled = true;
            Symbol_Remainder.IsEnabled = true;
            Symbol_Multiply.IsEnabled = true;
            Symbol_Minus.IsEnabled = true;
            Symbol_Except.IsEnabled = true;
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow SetWin = new SettingWindow();
            SetWin.Show();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Help HelpWindow = new Help();
            HelpWindow.Show();
        }

        private void MetroWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad0) || e.KeyStates == Keyboard.GetKeyStates(Key.D0))
            {
                Num0_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad1) || e.KeyStates == Keyboard.GetKeyStates(Key.D1))
            {
                Num1_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad2) || e.KeyStates == Keyboard.GetKeyStates(Key.D2))
            {
                Num2_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad3) || e.KeyStates == Keyboard.GetKeyStates(Key.D3))
            {
                Num3_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad4) || e.KeyStates == Keyboard.GetKeyStates(Key.D4))
            {
                Num4_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad5) || e.KeyStates == Keyboard.GetKeyStates(Key.D5))
            {
                Num5_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad6) || e.KeyStates == Keyboard.GetKeyStates(Key.D6))
            {
                Num6_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad7) || e.KeyStates == Keyboard.GetKeyStates(Key.D7))
            {
                Num7_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad8) || e.KeyStates == Keyboard.GetKeyStates(Key.D8))
            {
                Num8_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.NumPad9) || e.KeyStates == Keyboard.GetKeyStates(Key.D9))
            {
                Num9_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Enter))
            {
                Symbol_EqualTo_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Add))
            {
                // "+"
                Symbol_Plus_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Divide))
            {
                // "/"
                Symbol_Except_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Subtract))
            {
                // "-"
                Symbol_Minus_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Multiply))
            {
                // "*"
                Symbol_Multiply_Click(sender, e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Decimal))
            {
                // "."
                Symbol_Dorp_Click(sender,e);
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Delete))
            {
                Symbol_DorpChange = 0;
                Symbol_Plus_Minus_Change = 0;
                Histroy.Content = "";
                Operator.Content = "";
                ResultExport.Content = "";
                Count.Content = "";
                Number1 = null;
                Number2 = null;
                Number3 = null;
                Number4 = null;
                Number5 = null;
                Flag = null;
                Symbol_Plus.IsEnabled = true;
                Symbol_Remainder.IsEnabled = true;
                Symbol_Multiply.IsEnabled = true;
                Symbol_Minus.IsEnabled = true;
                Symbol_Except.IsEnabled = true;
            }
            else if (e.KeyStates == Keyboard.GetKeyStates(Key.Escape))
            {
                Close();
            }
        }

        private void Symbol_PlusChange_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null && Symbol_Plus_Minus_Change == 0)
            {
                Number3 = Number1;
                Number1 = "+" + Number1;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number1;
            }
            else if (Flag == null && Symbol_Plus_Minus_Change == 1)
            {
                Number1 = "+" + Number3;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number1;
            }
            else if (Flag != null && Symbol_Plus_Minus_Change == 0)
            {
                Number2 = Number3;
                Number2 = "+" + Number2;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number2;
            }
            else if (Flag != null && Symbol_Plus_Minus_Change == 1)
            {
                Number2 = "+" + Number3;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number2;
            }
        }

        private void Symbol_MinusChange_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null && Symbol_Plus_Minus_Change==0)
            {
                Number3 = Number1;
                Number1 = "-" + Number1;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number1;
            }
            else if (Flag == null && Symbol_Plus_Minus_Change == 1)
            {
                Number1 = "-" + Number3;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number1;
            }
            else if (Flag != null  && Symbol_Plus_Minus_Change == 0)
            {
                Number2 = Number3;
                Number2 = "-" + Number2;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number2;
            }
            else if (Flag != null && Symbol_Plus_Minus_Change == 1)
            {
                Number2 = "-" + Number3;
                Symbol_Plus_Minus_Change = 1;
                Count.Content = Number2;
            }
        }

        private void Symbol_EqualTo_Click(object sender, RoutedEventArgs e)
        {
            if (Number1 != null && Flag != null && Number2 !=null )
            {
                switch (Flag)
                {
                    case "+":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2));
                        break;
                    case "-":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2));
                        break;
                    case "*":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2));
                        break;
                    case "/":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2));
                        break;
                    case "%":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) % Convert.ToDouble(Number2));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) % Convert.ToDouble(Number2));
                        break;
                }
            }
            else if (Number1 != null && Flag == null && Number2 == null)
            {
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1));
            }
            else if (Number1 != null && Flag != null && Number2 == null)
            {
                switch (Flag)
                {
                    case "+":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2 = "0"));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) + Convert.ToDouble(Number2 = "0"));
                        break;
                    case "-":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2 = "0"));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) - Convert.ToDouble(Number2 = "0"));
                        break;
                    case "*":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2 = "0"));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) * Convert.ToDouble(Number2 = "0"));
                        break;
                    case "/":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2 = "0"));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) / Convert.ToDouble(Number2 = "0"));
                        break;
                    case "%":
                        ResultExport.Content = Convert.ToString(Convert.ToDouble(Number1) % Convert.ToDouble(Number2 = "0"));
                        Number5 = Convert.ToString(Convert.ToDouble(Number1) % Convert.ToDouble(Number2 = "0"));
                        break;
                }
            }
            Histroy.Content = ResultExport.Content;
            Symbol_Plus_Minus_Change = 0;
            Symbol_DorpChange = 0;
            Count.Content = "";
            Operator.Content = "=";
            Symbol_Plus.IsEnabled = true;
            Symbol_Remainder.IsEnabled = true;
            Symbol_Multiply.IsEnabled = true;
            Symbol_Minus.IsEnabled = true;
            Symbol_Except.IsEnabled = true;
            Number1 = Number5;
            Number2 = null;
            Flag = null;
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == null)
            {
                Number1 = Number1 + "3";
                Count.Content = Number1;
            }
            else
            {
                Number2 = Number2 + "3";
                Count.Content = Number2;
            }
        }

        public MainWindow()
        {
            ResizeMode= ResizeMode.CanMinimize;
            InitializeComponent();
        }
    }
}