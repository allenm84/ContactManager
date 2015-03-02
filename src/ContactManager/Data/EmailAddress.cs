using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "EmailAddress", Namespace = Program.Namespace)]
  public class EmailAddress : ExtensibleDataObject
  {
    [DataMember]
    public string Value { get; set; }
    [DataMember]
    public AddressType Type { get; set; }

    public override string ToString()
    {
      return string.Format("{0}: {1}", Type, Value);
    }
  }
}
