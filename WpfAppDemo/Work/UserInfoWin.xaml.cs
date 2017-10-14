using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppDemo.Work
{
  /// <summary>
  /// Interaction logic for UserInfoWin.xaml
  /// </summary>
  public partial class UserInfoWin : Window
  {
    ObservableCollection<UserInfo> _UList;
    public UserInfoWin()
    {
      InitializeComponent();
      Loaded += UserInfoWin_Loaded;
    }

    private void UserInfoWin_Loaded(object sender, RoutedEventArgs e)
    {
      _UList = new ObservableCollection<UserInfo>();
      _UList.Add(new UserInfo { UName = "Mukund", Age = 25, FavColor = "Light Blue" });
      _UList.Add(new UserInfo { UName = "Rahul", Age = 23, FavColor = "Blue" });
      _UList.Add(new UserInfo { UName = "Pratik", Age = 24, FavColor = "Pink" });
      _UList.Add(new UserInfo { UName = "Sachin", Age = 25, FavColor = "Yellow" });
      _UList.Add(new UserInfo { UName = "Vikas", Age = 24, FavColor = "Brown" });
      this.DataContext = _UList;

    }

    private void AddNewUser_Click(object sender, RoutedEventArgs e)
    {
      _UList.Add(new UserInfo { UName = TxtName.Text, Age = Convert.ToInt32(Txtage.Text), FavColor = Txtcolor.Text });
      MessageBox.Show("Record Added Successfully  !!");
    }
  }
}
