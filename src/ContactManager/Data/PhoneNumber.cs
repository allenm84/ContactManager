using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "PhoneNumber", Namespace = Program.Namespace)]
  public class PhoneNumber : ExtensibleDataObject
  {
    [DataMember]
    public int AreaCode { get; set; }
    [DataMember]
    public int Prefix { get; set; }
    [DataMember]
    public int Line { get; set; }
    [DataMember]
    public bool HasExtension { get; set; }
    [DataMember]
    public int Extension { get; set; }
    [DataMember]
    public PhoneNumberType Type { get; set; }
    [DataMember]
    public string Label { get; set; }

    public override string ToString()
    {
      object ext = string.Empty;
      if (HasExtension)
        ext = string.Format(" (x{0})", Extension);

      string label = string.Empty;
      if (!string.IsNullOrWhiteSpace(Label))
        label = " [" + Label + "]";

      return string.Format("{0}: ({1}) {2}-{3}{4}{5}",
        Type,
        AreaCode,
        Prefix,
        Line,
        ext,
        label);
    }
  }
}
