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
  /// Interaction logic for TunnelingEventWin.xaml
  /// </summary>
  public partial class TunnelingEventWin : Window
  {
    public TunnelingEventWin()
    {
      InitializeComponent();
      Root.PreviewMouseDown += Root_PreviewMouseDown;
      Inner.PreviewMouseDown += Inner_PreviewMouseDown;
      Btn1.PreviewMouseDown += Btn1_PreviewMouseDown;
      chk1.PreviewMouseDown += Chk1_PreviewMouseDown;
    }

    private void Chk1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Comming From CheckBox !!");          
    }

    private void Btn1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Comming From Button !!");
    }

    private void Inner_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Comming From Inner !!");
    }

    private void Root_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Comming From Root !!");
    }
  }
}
