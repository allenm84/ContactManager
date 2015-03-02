using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "SpecialDateType", Namespace = Program.Namespace)]
  public enum SpecialDateType
  {
    [EnumMember]
    Birthday,
    [EnumMember]
    Anniversary,
    [EnumMember]
    Other,
  }
}
