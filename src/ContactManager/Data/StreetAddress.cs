using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "StreetAddress", Namespace = Program.Namespace)]
  public class StreetAddress : ExtensibleDataObject
  {
    [DataMember]
    public string Line1 { get; set; }
    [DataMember]
    public string Line2 { get; set; }
    [DataMember]
    public string City { get; set; }
    [DataMember]
    public USState State { get; set; }
    [DataMember]
    public int ZipCode { get; set; }
    [DataMember]
    public AddressType Type { get; set; }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      if (!string.IsNullOrWhiteSpace(Line1))
      {
        sb.Append(Line1);
      }

      if (!string.IsNullOrWhiteSpace(Line2))
      {
        if (sb.Length > 0)
          sb.Append(',');
        sb.Append(Line2);
      }

      if (!string.IsNullOrWhiteSpace(City))
      {
        if (sb.Length > 0)
          sb.Append(',');
        sb.Append(City);
      }

      if(sb.Length > 0)
        sb.Append(',');
      sb.AppendFormat("{0} {1}", State, ZipCode);

      sb.Insert(0, Type + ": ");
      return sb.ToString();
    }
  }
}
