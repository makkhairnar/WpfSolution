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
using System.Windows.Shapes;

namespace WpfAppDemo.Events
{
  /// <summary>
  /// Interaction logic for BubblingEventWin.xaml
  /// </summary>
  public partial class BubblingEventWin : Window
  {
    public BubblingEventWin()
    {
      InitializeComponent();
      Chk1.KeyDown += Chk1_KeyDown;
      Btn1.Click += Btn1_Click;
      InnerPanel.KeyDown += InnerPanel_KeyDown;
      RootPanel.KeyDown += RootPanel_KeyDown;
    }

    private void RootPanel_KeyDown(object sender, KeyEventArgs e)
    {
      MessageBox.Show("Comming From Root");
    }

    private void InnerPanel_KeyDown(object sender, KeyEventArgs e)
    {
      MessageBox.Show("Comming From Inner");
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Comming From Button");
    }

    private void Chk1_KeyDown(object sender, KeyEventArgs e)
    {

      MessageBox.Show("Comming From Checkbox");
    }
  }
}
