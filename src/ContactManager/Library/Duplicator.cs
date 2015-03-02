using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  public static partial class Extensions
  {
    public static string Duplicate(this string str)
    {
      return string.Copy(str ?? string.Empty);
    }

    public static Contact Duplicate(this Contact contact)
    {
      return new Contact
      {
        Addresses = contact.Addresses.Select(a => a.Duplicate()).ToList(),
        Dates = contact.Dates.Select(d => d.Duplicate()).ToList(),
        Emails = contact.Emails.Select(e => e.Duplicate()).ToList(),
        ID = contact.ID.Duplicate(),
        Name = contact.Name.Duplicate(),
        Notes = contact.Notes.Duplicate(),
        Phones = contact.Phones.Select(p => p.Duplicate()).ToList(),
      };
    }

    public static ContactName Duplicate(this ContactName name)
    {
      return new ContactName
      {
        First = name.First.Duplicate(),
        Last = name.Last.Duplicate(),
        Middle = name.Middle.Duplicate(),
      };
    }

    public static SpecialDate Duplicate(this SpecialDate date)
    {
      return new SpecialDate
      {
        Date = date.Date,
        IncludeYear = date.IncludeYear,
        Type = date.Type,
      };
    }

    public static EmailAddress Duplicate(this EmailAddress email)
    {
      return new EmailAddress
      {
        Type = email.Type,
        Value = email.Value,
      };
    }

    public static StreetAddress Duplicate(this StreetAddress address)
    {
      return new StreetAddress
      {
        City = address.City.Duplicate(),
        Line1 = address.Line1.Duplicate(),
        Line2 = address.Line2.Duplicate(),
        State = address.State,
        Type = address.Type,
        ZipCode = address.ZipCode,
      };
    }

    public static PhoneNumber Duplicate(this PhoneNumber number)
    {
      return new PhoneNumber
      {
        AreaCode = number.AreaCode,
        Extension = number.Extension,
        HasExtension = number.HasExtension,
        Label = number.Label.Duplicate(),
        Line = number.Line,
        Prefix = number.Prefix,
        Type = number.Type,
      };
    }
  }
}
