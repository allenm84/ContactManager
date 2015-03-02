using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Design;

namespace ContactManager
{
  public partial class DataListEditor : XtraUserControl
  {
    [DXCategory("Data")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
    [DefaultValue("")]
    [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
    public string DisplayMember
    {
      get { return lstItems.DisplayMember; }
      set { lstItems.DisplayMember = value; }
    }

    [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
    [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
    [DefaultValue("")]
    [DXCategory("Data")]
    public string ValueMember
    {
      get { return lstItems.ValueMember; }
      set { lstItems.ValueMember = value; }
    }

    [DefaultValue(null)]
    [RefreshProperties(RefreshProperties.Repaint)]
    [DXCategory("Data")]
    [AttributeProvider(typeof(IListSource))]
    public object DataSource
    {
      get { return lstItems.DataSource; }
      set { lstItems.DataSource = value; }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public int SelectedIndex
    {
      get { return lstItems.SelectedIndex; }
      set { lstItems.SelectedIndex = value; }
    }

    [Browsable(false)]
    public BaseListBoxControl.SelectedIndexCollection SelectedIndices
    {
      get { return lstItems.SelectedIndices; }
    }

    [Browsable(false)]
    public BaseListBoxControl.SelectedItemCollection SelectedItems
    {
      get { return lstItems.SelectedItems; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object SelectedValue
    {
      get { return lstItems.SelectedValue; }
      set { lstItems.SelectedValue = value; }
    }

    public event EventHandler AddClick
    {
      add { btnAdd.Click += value; }
      remove { btnAdd.Click -= value; }
    }

    public event EventHandler EditClick
    {
      add { btnEdit.Click += value; }
      remove { btnEdit.Click -= value; }
    }

    public DataListEditor()
    {
      InitializeComponent();
      lstItems.Items.ListChanged += Items_ListChanged;
    }

    public void SetToViewMode()
    {
      layoutControl1.SuspendLayout();
      layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
      layoutControl1.ResumeLayout(true);
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = lstItems.SelectedItems.Count == 1;
      btnRemove.Enabled = lstItems.SelectedIndex > -1;
      btnClear.Enabled = lstItems.Items.Count > 0;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateButtons();
    }

    private void Items_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this,
        "Are you sure you want to remove the selected items?",
        "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No) return;

      lstItems.BeginUpdate();
      var items = lstItems.SelectedItems.Cast<object>().ToArray();
      var list = (System.Collections.IList)lstItems.DataSource;
      foreach (var item in items)
      {
        list.Remove(item);
      }
      lstItems.EndUpdate();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this,
        "Are you sure you want to clear all the items?",
        "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.No) return;

      lstItems.BeginUpdate();
      var list = (System.Collections.IList)lstItems.DataSource;
      list.Clear();
      lstItems.EndUpdate();
    }

    private void lstItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var index = lstItems.IndexFromPoint(e.Location);
        var item = lstItems.GetItem(index);
        if (item != null)
        {
          btnEdit.PerformClick();
        }
      }
    }
  }
}
