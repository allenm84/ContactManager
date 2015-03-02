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
  public partial class EditNameDialog : BaseForm
  {
    public string First
    {
      get { return txtFirst.Text; }
      set { txtFirst.Text = value; }
    }

    public string Middle
    {
      get { return txtMiddle.Text; }
      set { txtMiddle.Text = value; }
    }

    public string Last
    {
      get { return txtLast.Text; }
      set { txtLast.Text = value; }
    }

    public EditNameDialog()
    {
      InitializeComponent();
    }
  }
}
