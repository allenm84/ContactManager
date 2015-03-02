using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
  public partial class EditSpecialDateDialog : BaseForm
  {
    public EditSpecialDateDialog(SpecialDate date)
    {
      InitializeComponent();
      cboTypes.Properties.FillWithEnum<SpecialDateType>();

      chkIncludeYear.DataBindings.Add("Checked", date, "IncludeYear");
      dtDate.DataBindings.Add("DateTime", date, "Date");
      cboTypes.DataBindings.Add("EditValue", date, "Type");
    }

    private void UpdateFormat()
    {
      if (chkIncludeYear.Checked)
      {
        dtDate.Properties.EditFormat.FormatString = "D";
        dtDate.Properties.DisplayFormat.FormatString = "D";
        dtDate.Properties.EditMask = "D";
      }
      else
      {
        dtDate.Properties.EditFormat.FormatString = "MMMM, dd";
        dtDate.Properties.DisplayFormat.FormatString = "MMMM, dd";
        dtDate.Properties.EditMask = "MMMM, dd";
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateFormat();
    }

    private void chkIncludeYear_CheckedChanged(object sender, EventArgs e)
    {
      UpdateFormat();
    }
  }
}
