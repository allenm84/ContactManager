using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactManager
{
  public static class Importer
  {
    public static void Import(List<Contact> data)
    {
      string filepath = @"C:\Users\mallen\Dropbox\Paige\Programs\ContactManager\addressBook.xml";
      XDocument doc = XDocument.Load(filepath);
      foreach (var entry in doc.Descendants("Entry"))
      {
        var contact = new Contact
        {
          Addresses = new List<StreetAddress>(),
          Dates = new List<SpecialDate>(),
          Emails = new List<EmailAddress>(),
          ID = Arbiter.ID,
          Name = null,
          Notes = string.Empty,
          Phones = new List<PhoneNumber>(),
        };

        contact.Name = new ContactName { First = entry.Element("FirstName").Value, Last = entry.Element("LastName").Value };
        contact.ID = Arbiter.ID;

        var addr = entry.Element("Address");
        var address = new StreetAddress();
        address.City = addr.Element("City").Value;
        address.Line1 = addr.Element("Line1").Value;
        address.Line2 = addr.Element("Line2").Value;
        address.State = (USState)Enum.Parse(typeof(USState), addr.Element("State").Value);
        address.Type = AddressType.Other;
        address.ZipCode = (int)addr.Element("Zip");
        contact.Addresses.Add(address);

        var phones = contact.Phones;
        phones.Add(ParsePhoneNumber(entry.Element("MainPhone")));
        foreach (var v in entry.Descendants("PhoneNumber"))
        {
          phones.Add(ParsePhoneNumber(v));
        }

        phones.RemoveAll(p => p == null);
        data.Add(contact);
      }
    }

    private static PhoneNumber ParsePhoneNumber(XElement element)
    {
      string number = element.Element("Number").Value;
      if (string.IsNullOrWhiteSpace(number))
        return null;

      var parts = number.Split(new char[] { '(', ')', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

      var ext = (int)element.Element("Extension");
      return new PhoneNumber
      {
        AreaCode = int.Parse(parts[0]),
        Extension = ext,
        HasExtension = ext != 0,
        Line = int.Parse(parts[2]),
        Prefix = int.Parse(parts[1]),
        Type = (PhoneNumberType)Enum.Parse(typeof(PhoneNumberType), element.Element("Type").Value),
      };
    }
  }
}
