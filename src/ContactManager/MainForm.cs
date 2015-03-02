using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace ContactManager
{
  public partial class MainForm : BaseForm
  {
    private DataContractFile<List<Contact>> dcf;

    public MainForm()
    {
      InitializeComponent();
      contacts.ListChanged += contacts_ListChanged;
      UpdateButtons();
    }

    private void UpdateButtons()
    {
      tbbView.Enabled = gridViewContacts.SelectedRowsCount == 1;
    }

    private void SetIsWorking(bool working)
    {
      Cursor = working 
        ? Cursors.WaitCursor 
        : Cursors.Default;
      Enabled = !working;
    }

    private async void LoadContacts()
    {
      dcf = new DataContractFile<List<Contact>>(Path.Combine(Application.StartupPath, "contacts.xml"));
      SetIsWorking(true);
      var data = await Task.Run(() =>
      {
        return dcf.Read();
      });
      SetIsWorking(false);

      if (data == null)
      {
        data = new List<Contact>();
      }

      if (data != null)
      {
        gridViewContacts.BeginDataUpdate();
        contacts.Clear();
        foreach (var c in data)
        {
          contacts.Add(c);
        }
        gridViewContacts.EndDataUpdate();
      }
    }

    private async void SaveContacts()
    {
      SetIsWorking(true);

      var data = contacts.Cast<Contact>().ToList();
      await Task.Run(() => dcf.Write(data));

      SetIsWorking(false);
    }

    private void EditContactByRow(int rowHandle)
    {
      EditContactByItem(gridViewContacts.GetRow(rowHandle) as Contact);
    }

    private void EditContactByItem(Contact contact)
    {
      if (contact == null) return;
      var copy = contact.Duplicate();
      using (var dlg = new EditContactDialog(copy))
      {
        dlg.Text = "Edit Contact";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridViewContacts.BeginDataUpdate();
          var index = contacts.IndexOf(contact);
          contacts[index] = copy;
          gridViewContacts.EndDataUpdate();
        }
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateButtons();
      LoadContacts();
    }

    private void contacts_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      SaveContacts();
    }

    private void tbbAdd_ItemClick(object sender, ItemClickEventArgs e)
    {
      var contact = new Contact
      {
        Addresses = new List<StreetAddress>(),
        Dates = new List<SpecialDate>(),
        Emails = new List<EmailAddress>(),
        ID = Arbiter.ID,
        Name = new ContactName(),
        Notes = "",
        Phones = new List<PhoneNumber>(),
      };

      using (var dlg = new EditContactDialog(contact))
      {
        dlg.Text = "Add Contact";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          contacts.Add(contact);
        }
      }
    }

    private void tbbEdit_ItemClick(object sender, ItemClickEventArgs e)
    {
      EditContactByRow(gridViewContacts.FocusedRowHandle);
    }

    private void tbbView_ItemClick(object sender, ItemClickEventArgs e)
    {
      var contact = gridViewContacts.GetFocusedRow() as Contact;
      if (contact == null) return;
      using (var dlg = new EditContactDialog(contact))
      {
        var title = "Contact";
        var name = contact.Name;
        if (name != null)
        {
          title = name.GetDisplay();
        }

        dlg.Text = "View " + title;
        dlg.SetToViewMode();
        dlg.ShowDialog(this);
      }
    }

    private void gridViewContacts_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete && gridViewContacts.SelectedRowsCount > 0)
      {
        var result = XtraMessageBox.Show(this,
          "Are you sure you want to delete the selected contacts?",
          "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == System.Windows.Forms.DialogResult.No) return;
        gridViewContacts.DeleteSelectedRows();
      }
    }

    private void gridViewContacts_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridContacts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewContacts.CalcHitInfo(e.Location);
        if (info.InRow || info.InRowCell)
        {
          EditContactByRow(info.RowHandle);
        }
      }
    }

    private void gridViewContacts_CustomRowFilter(object sender, RowFilterEventArgs e)
    {
      var item = contacts[e.ListSourceRow] as Contact;
      e.Handled = true;

      string text = item.Key.ToLower();
      if (item.Name != null)
      {
        text = item.Name.GetDisplay();
      }

      string filter = txtFilter.Text;
      e.Visible = text.Contains(filter);
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      gridViewContacts.RefreshData();
    }
  }
}
