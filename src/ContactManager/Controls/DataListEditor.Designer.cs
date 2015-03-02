namespace ContactManager
{
  partial class DataListEditor
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnClear = new DevExpress.XtraEditors.SimpleButton();
      this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
      this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
      this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
      this.lstItems = new DevExpress.XtraEditors.ListBoxControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnClear);
      this.layoutControl1.Controls.Add(this.btnRemove);
      this.layoutControl1.Controls.Add(this.btnEdit);
      this.layoutControl1.Controls.Add(this.btnAdd);
      this.layoutControl1.Controls.Add(this.lstItems);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(771, 212, 443, 545);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(250, 150);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(174, 80);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(74, 22);
      this.btnClear.StyleController = this.layoutControl1;
      this.btnClear.TabIndex = 8;
      this.btnClear.Text = "Clear";
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(174, 54);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(74, 22);
      this.btnRemove.StyleController = this.layoutControl1;
      this.btnRemove.TabIndex = 7;
      this.btnRemove.Text = "Remove";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(174, 28);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(74, 22);
      this.btnEdit.StyleController = this.layoutControl1;
      this.btnEdit.TabIndex = 6;
      this.btnEdit.Text = "Edit";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(174, 2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(74, 22);
      this.btnAdd.StyleController = this.layoutControl1;
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Add";
      // 
      // lstItems
      // 
      this.lstItems.Location = new System.Drawing.Point(2, 2);
      this.lstItems.Name = "lstItems";
      this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstItems.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
      this.lstItems.Size = new System.Drawing.Size(168, 146);
      this.lstItems.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.lstItems.StyleController = this.layoutControl1;
      this.lstItems.TabIndex = 4;
      this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
      this.lstItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseDoubleClick);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(250, 150);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.lstItems;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(172, 150);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.btnAdd;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnEdit;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnRemove;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnClear;
      this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 78);
      this.layoutControlItem5.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem5.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(78, 72);
      this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "layoutControlItem5";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
      this.layoutControlGroup2.GroupBordersVisible = false;
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
      this.layoutControlGroup2.Location = new System.Drawing.Point(172, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(78, 150);
      this.layoutControlGroup2.Text = "layoutControlGroup2";
      this.layoutControlGroup2.TextVisible = false;
      // 
      // DataListEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "DataListEditor";
      this.Size = new System.Drawing.Size(250, 150);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.lstItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SimpleButton btnClear;
    private DevExpress.XtraEditors.SimpleButton btnRemove;
    private DevExpress.XtraEditors.SimpleButton btnEdit;
    private DevExpress.XtraEditors.SimpleButton btnAdd;
    private DevExpress.XtraEditors.ListBoxControl lstItems;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
  }
}
