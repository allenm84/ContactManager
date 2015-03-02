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
  public partial class EditStreetAddressDialog : BaseForm
  {
    public EditStreetAddressDialog(StreetAddress address)
    {
      InitializeComponent();
      cboStates.Properties.FillWithEnum<USState>();
      cboTypes.Properties.FillWithEnum<AddressType>();

      txtLine1.DataBindings.Add("Text", address, "Line1");
      txtLine2.DataBindings.Add("Text", address, "Line2");
      txtCity.DataBindings.Add("Text", address, "City");
      cboStates.DataBindings.Add("EditValue", address, "State");
      numZip.DataBindings.Add("Value", address, "ZipCode");
      cboTypes.DataBindings.Add("EditValue", address, "Type");
    }
  }
}
