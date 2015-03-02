using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  [DataContract(Name = "Contact", Namespace = Program.Namespace)]
  public class Contact : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public ContactName Name { get; set; }
    [DataMember]
    public List<PhoneNumber> Phones { get; set; }
    [DataMember]
    public List<StreetAddress> Addresses { get; set; }
    [DataMember]
    public List<EmailAddress> Emails { get; set; }
    [DataMember]
    public List<SpecialDate> Dates { get; set; }
    [DataMember]
    public string Notes { get; set; }

    public string Key
    {
      get
      {
        if (Name == null)
          return string.Empty;
        return Name.Key;
      }
    }
  }
}
