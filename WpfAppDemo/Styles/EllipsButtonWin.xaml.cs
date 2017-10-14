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

namespace WpfAppDemo.Styles
{
  /// <summary>
  /// Interaction logic for EllipsButtonWin.xaml
  /// </summary>
  public partial class EllipsButtonWin : Window
  {
    public EllipsButtonWin()
    {
      InitializeComponent();
    }

    private void BtnClick_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Click ME ....!!");
    }
  }
}
