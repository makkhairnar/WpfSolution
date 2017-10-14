using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDemo.Work
{
  public class UserInfo
  {
    string _UName;
    string _FavColor;
    int _Age;

    public string UName
    {
      get
      {
        return _UName;
      }

      set
      {
        _UName = value;
      }
    }

    public string FavColor
    {
      get
      {
        return _FavColor;
      }

      set
      {
        _FavColor = value;
      }
    }

    public int Age
    {
      get
      {
        return _Age;
      }

      set
      {
        _Age = value;
      }
    }
  }
}
