using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SgartSPQueryViewer
{
  public class MyListItem
  {
      public MyListItem()
      {
          Key = "";
          Value = "";
      }

      public MyListItem(string key, string value)
      {
          this.Key = key;
          this.Value = value;
      }
      public string Key { get; set; }
      public string Value { get; set; }

      public override string ToString()
      {
          return Value;
      }
  }
}
