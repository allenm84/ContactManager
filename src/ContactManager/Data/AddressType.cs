using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "AddressType", Namespace = Program.Namespace)]
  public enum AddressType
  {
    [EnumMember]
    Home,
    [EnumMember]
    Work,
    [EnumMember]
    Other,
  }
}
