using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
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
  public partial class EditPhoneNumberDialog : BaseForm
  {
    public EditPhoneNumberDialog(PhoneNumber number)
    {
      InitializeComponent();
      cboTypes.Properties.FillWithEnum<PhoneNumberType>();

      txtLabel.DataBindings.Add("Text", number, "Label");

      numAreaCode.DataBindings.Add("Value", number, "AreaCode");
      numPrefix.DataBindings.Add("Value", number, "Prefix");
      numLine.DataBindings.Add("Value", number, "Line");

      chkExtension.DataBindings.Add("Checked", number, "HasExtension");
      numExtension.DataBindings.Add("Enabled", chkExtension, "Checked");
      numExtension.DataBindings.Add("Value", number, "Extension");

      cboTypes.DataBindings.Add("EditValue", number, "Type");
    }
  }
}
