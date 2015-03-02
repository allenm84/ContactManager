using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "ContactName", Namespace = Program.Namespace)]
  public class ContactName : ExtensibleDataObject
  {
    [DataMember]
    public string First { get; set; }
    [DataMember]
    public string Middle { get; set; }
    [DataMember]
    public string Last { get; set; }

    public string Key
    {
      get
      {
        var c = new[] { Last, First, Middle };
        foreach (var x in c)
        {
          if (string.IsNullOrWhiteSpace(x))
            continue;
          return x.First().ToString();
        }
        return string.Empty;
      }
    }

    public override string ToString()
    {
      return this.GetDisplay();
    }
  }
}
