using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace ContactManager
{
  public partial class EditContactDialog : BaseForm
  {
    private bool parseNeeded = false;
    private bool ignoreTextChanged = false;

    private Contact contact;
    private BindingList<PhoneNumber> phones;
    private BindingList<StreetAddress> addresses;
    private BindingList<EmailAddress> emails;
    private BindingList<SpecialDate> dates;

    public EditContactDialog(Contact contact)
    {
      this.contact = contact;
      InitializeComponent();
      InitializeLists();
      memoEdit1.DataBindings.Add("Text", contact, "Notes");
      ReadName();
    }

    public void SetToViewMode()
    {
      foreach (Control control in layoutControl1.Controls)
      {
        DataListEditor editor = control as DataListEditor;
        if (editor != null)
        {
          editor.SetToViewMode();
        }
      }

      txtName.Properties.ReadOnly = true;
      txtName.Properties.Buttons[0].Enabled = false;
      memoEdit1.Properties.ReadOnly = true;
    }

    private void InitializeLists()
    {
      phones = new BindingList<PhoneNumber>(contact.Phones);
      lstPhones.DataSource = phones;

      addresses = new BindingList<StreetAddress>(contact.Addresses);
      lstAddresses.DataSource = addresses;

      emails = new BindingList<EmailAddress>(contact.Emails);
      lstEmails.DataSource = emails;

      dates = new BindingList<SpecialDate>(contact.Dates);
      lstDates.DataSource = dates;
    }

    private ContactName ParseName()
    {
      var name = new ContactName
      {
        First = string.Empty,
        Last = string.Empty,
        Middle = string.Empty,
      };

      var parts = txtName.Text.Split(' ').ToList();
      if (parts.Count == 1)
      {
        name.First = parts[0];
      }
      else if (parts.Count == 2)
      {
        name.First = parts[0];
        name.Last = parts[1];
      }
      else if (parts.Count > 2)
      {
        name.Last = parts.PopLast();
        name.Middle = parts.PopLast();
        name.First = string.Join(" ", parts);
      }

      return name;
    }

    private void ReadName()
    {
      parseNeeded = false;
      ignoreTextChanged = true;
      txtName.Text = contact.Name.GetDisplay();
      ignoreTextChanged = false;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);
      if (parseNeeded)
      {
        var name = ParseName();
        if (!string.Equals(name.GetDisplay(), contact.Name.GetDisplay()))
        {
          contact.Name = name;
        }
      }
    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      if (ignoreTextChanged)
      {
        return;
      }

      parseNeeded = true;
    }

    private void txtName_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      using (var dlg = new EditNameDialog())
      {
        var name = ParseName();
        dlg.First = name.First;
        dlg.Middle = name.Middle;
        dlg.Last = name.Last;
        dlg.Text = "Edit Name";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          name.First = dlg.First;
          name.Middle = dlg.Middle;
          name.Last = dlg.Last;
          contact.Name = name;
          ReadName();
        }
      }
    }

    private void lstPhones_AddClick(object sender, EventArgs e)
    {
      var number = new PhoneNumber
      {
        AreaCode = 123,
        HasExtension = false,
        Line = 7890,
        Prefix = 456,
        Type = PhoneNumberType.Other,
      };

      using (var dlg = new EditPhoneNumberDialog(number))
      {
        dlg.Text = "Add Phone Number";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          phones.Add(number);
        }
      }
    }

    private void lstPhones_EditClick(object sender, EventArgs e)
    {
      var item = lstPhones.SelectedItems.Cast<PhoneNumber>().FirstOrDefault();
      if (item != null)
      {
        var copy = item.Duplicate();
        using (var dlg = new EditPhoneNumberDialog(copy))
        {
          dlg.Text = "Edit Phone Number";
          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            var index = phones.IndexOf(item);
            phones[index] = copy;
            phones.ResetItem(index);
          }
        }
      }
    }

    private void lstAddresses_AddClick(object sender, EventArgs e)
    {
      var address = new StreetAddress
      {
        City = "West Allis",
        Line1 = "1111 South Fake Street",
        Line2 = "",
        State = USState.WI,
        Type = AddressType.Other,
        ZipCode = 12345,
      };

      using (var dlg = new EditStreetAddressDialog(address))
      {
        dlg.Text = "Add Address";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          addresses.Add(address);
        }
      }
    }

    private void lstAddresses_EditClick(object sender, EventArgs e)
    {
      var item = lstAddresses.SelectedItems.Cast<StreetAddress>().FirstOrDefault();
      if (item != null)
      {
        var copy = item.Duplicate();
        using (var dlg = new EditStreetAddressDialog(copy))
        {
          dlg.Text = "Edit Address";
          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            var index = addresses.IndexOf(item);
            addresses[index] = copy;
            addresses.ResetItem(index);
          }
        }
      }
    }

    private void lstEmails_AddClick(object sender, EventArgs e)
    {
      var email = new EmailAddress
      {
        Type = AddressType.Other,
        Value = "test@test.com",
      };

      using (var dlg = new EditEmailAddressDialog(email))
      {
        dlg.Text = "Add Email";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          emails.Add(email);
        }
      }
    }

    private void lstEmails_EditClick(object sender, EventArgs e)
    {
      var item = lstEmails.SelectedItems.Cast<EmailAddress>().FirstOrDefault();
      if (item != null)
      {
        var copy = item.Duplicate();
        using (var dlg = new EditEmailAddressDialog(copy))
        {
          dlg.Text = "Edit Email";
          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            var index = emails.IndexOf(item);
            emails[index] = copy;
            emails.ResetItem(index);
          }
        }
      }
    }

    private void lstDates_AddClick(object sender, EventArgs e)
    {
      var date = new SpecialDate
      {
        Date = DateTime.Today,
        IncludeYear = false,
        Type = SpecialDateType.Birthday,
      };

      using (var dlg = new EditSpecialDateDialog(date))
      {
        dlg.Text = "Add Date";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dates.Add(date);
        }
      }
    }

    private void lstDates_EditClick(object sender, EventArgs e)
    {
      var item = lstEmails.SelectedItems.Cast<SpecialDate>().FirstOrDefault();
      if (item != null)
      {
        var copy = item.Duplicate();
        using (var dlg = new EditSpecialDateDialog(copy))
        {
          dlg.Text = "Edit Date";
          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            var index = dates.IndexOf(item);
            dates[index] = copy;
            dates.ResetItem(index);
          }
        }
      }
    }
  }
}
