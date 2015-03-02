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
  public partial class EditEmailAddressDialog : BaseForm
  {
    public EditEmailAddressDialog(EmailAddress email)
    {
      InitializeComponent();
      cboTypes.Properties.FillWithEnum<AddressType>();

      txtValue.DataBindings.Add("Text", email, "Value");
      cboTypes.DataBindings.Add("EditValue", email, "Type");
    }
  }
}
