using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "SpecialDate", Namespace = Program.Namespace)]
  public class SpecialDate : ExtensibleDataObject
  {
    [DataMember]
    public bool IncludeYear { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
    [DataMember]
    public SpecialDateType Type { get; set; }

    public override string ToString()
    {
      string text;

      if (IncludeYear)
      {
        text = Date.ToLongDateString();
      }
      else
      {
        text = Date.ToString("MMMM, d");
      }

      return string.Format("{0}: {1}", Type, text);
    }
  }
}
