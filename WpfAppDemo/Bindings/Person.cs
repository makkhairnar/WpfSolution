using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfAppDemo.Bindings
{
  public class Person:INotifyPropertyChanged
  {
    int _Age;
    string _Name;

    public int Age
    {
      get
      {
        return _Age;
      }

      set
      {
        _Age = value;
        //PropertyChanged(this, new PropertyChangedEventArgs("Age"));
      }
    }

    public string Name
    {
      get
      {
        return _Name;
      }

      set
      {
        _Name = value;
        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged= delegate { } ;
  }
}

