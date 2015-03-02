using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "PhoneNumberType", Namespace = Program.Namespace)]
  public enum PhoneNumberType
  {
    [EnumMember]
    Cell,
    [EnumMember]
    Business,
    [EnumMember]
    Office,
    [EnumMember]
    Home,
    [EnumMember]
    Main,
    [EnumMember]
    WorkFax,
    [EnumMember]
    HomeFax,
    [EnumMember]
    Pager,
    [EnumMember]
    Other,
  }
}
