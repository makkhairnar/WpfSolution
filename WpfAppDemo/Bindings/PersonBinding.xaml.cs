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

namespace WpfAppDemo.Bindings
{
  /// <summary>
  /// Interaction logic for Person.xaml
  /// </summary>
  public partial class Person12 : Window
  {
    Person objPer;
    public Person12()
    {
      InitializeComponent();
      Loaded += Person12_Loaded;
    }

    private void Person12_Loaded(object sender, RoutedEventArgs e)
    {
      objPer = new Person { Age = 25, Name = "Mukund" };
      this.DataContext = objPer;
    }

    private void BtnSubmit_Click(object sender, RoutedEventArgs e)
    {
      objPer.Name = "Sachin";
      objPer.Age = 25;
    }

    private void BtnShow_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show($"Name :{objPer.Name},\n Age :{objPer.Age}");
    }
  }
}
