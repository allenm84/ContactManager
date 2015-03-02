namespace ContactManager
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridContacts = new DevExpress.XtraGrid.GridControl();
      this.contacts = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewContacts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colKey = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbAdd = new DevExpress.XtraBars.BarButtonItem();
      this.tbbView = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.tbbEdit = new DevExpress.XtraBars.BarButtonItem();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtFilter = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.contacts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.txtFilter);
      this.layoutControl1.Controls.Add(this.gridContacts);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(859, 317, 368, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(298, 319);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridContacts
      // 
      this.gridContacts.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridContacts.DataSource = this.contacts;
      this.gridContacts.Location = new System.Drawing.Point(24, 110);
      this.gridContacts.MainView = this.gridViewContacts;
      this.gridContacts.MenuManager = this.barManager1;
      this.gridContacts.Name = "gridContacts";
      this.gridContacts.Size = new System.Drawing.Size(250, 185);
      this.gridContacts.TabIndex = 5;
      this.gridContacts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContacts});
      this.gridContacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridContacts_MouseDoubleClick);
      // 
      // contacts
      // 
      this.contacts.DataSource = typeof(ContactManager.Contact);
      // 
      // gridViewContacts
      // 
      this.gridViewContacts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKey,
            this.colID,
            this.colName,
            this.colNotes});
      this.gridViewContacts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewContacts.GridControl = this.gridContacts;
      this.gridViewContacts.GroupCount = 1;
      this.gridViewContacts.GroupFormat = "{1}";
      this.gridViewContacts.Name = "gridViewContacts";
      this.gridViewContacts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewContacts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewContacts.OptionsBehavior.AllowIncrementalSearch = true;
      this.gridViewContacts.OptionsBehavior.AutoExpandAllGroups = true;
      this.gridViewContacts.OptionsBehavior.Editable = false;
      this.gridViewContacts.OptionsBehavior.ReadOnly = true;
      this.gridViewContacts.OptionsCustomization.AllowColumnMoving = false;
      this.gridViewContacts.OptionsCustomization.AllowColumnResizing = false;
      this.gridViewContacts.OptionsCustomization.AllowFilter = false;
      this.gridViewContacts.OptionsCustomization.AllowQuickHideColumns = false;
      this.gridViewContacts.OptionsDetail.EnableMasterViewMode = false;
      this.gridViewContacts.OptionsMenu.EnableColumnMenu = false;
      this.gridViewContacts.OptionsMenu.EnableFooterMenu = false;
      this.gridViewContacts.OptionsMenu.EnableGroupPanelMenu = false;
      this.gridViewContacts.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewContacts.OptionsView.EnableAppearanceEvenRow = true;
      this.gridViewContacts.OptionsView.ShowColumnHeaders = false;
      this.gridViewContacts.OptionsView.ShowGroupPanel = false;
      this.gridViewContacts.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewContacts.OptionsView.ShowIndicator = false;
      this.gridViewContacts.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewContacts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKey, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewContacts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewContacts_FocusedRowChanged);
      this.gridViewContacts.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridViewContacts_CustomRowFilter);
      this.gridViewContacts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewContacts_KeyDown);
      // 
      // colKey
      // 
      this.colKey.FieldName = "Key";
      this.colKey.Name = "colKey";
      this.colKey.Visible = true;
      this.colKey.VisibleIndex = 0;
      // 
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colNotes
      // 
      this.colNotes.FieldName = "Notes";
      this.colNotes.Name = "colNotes";
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbAdd,
            this.tbbEdit,
            this.tbbView});
      this.barManager1.MaxItemId = 5;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbView, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableClose = true;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.Glyph")));
      this.tbbSave.Id = 0;
      this.tbbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.LargeGlyph")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // tbbAdd
      // 
      this.tbbAdd.Caption = "Add";
      this.tbbAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbAdd.Glyph")));
      this.tbbAdd.Id = 1;
      this.tbbAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbAdd.LargeGlyph")));
      this.tbbAdd.Name = "tbbAdd";
      this.tbbAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbAdd_ItemClick);
      // 
      // tbbView
      // 
      this.tbbView.Caption = "View";
      this.tbbView.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbView.Glyph")));
      this.tbbView.Id = 3;
      this.tbbView.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbView.LargeGlyph")));
      this.tbbView.Name = "tbbView";
      this.tbbView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbView_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(298, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 350);
      this.barDockControlBottom.Size = new System.Drawing.Size(298, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 319);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(298, 31);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 319);
      // 
      // tbbEdit
      // 
      this.tbbEdit.Caption = "Edit";
      this.tbbEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbEdit.Glyph")));
      this.tbbEdit.Id = 2;
      this.tbbEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbEdit.LargeGlyph")));
      this.tbbEdit.Name = "tbbEdit";
      this.tbbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbEdit_ItemClick);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(298, 319);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Contacts";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 67);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(278, 232);
      this.layoutControlGroup3.Text = "Contacts";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.gridContacts;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(254, 189);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // txtFilter
      // 
      this.txtFilter.Location = new System.Drawing.Point(24, 43);
      this.txtFilter.MenuManager = this.barManager1;
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(250, 20);
      this.txtFilter.StyleController = this.layoutControl1;
      this.txtFilter.TabIndex = 6;
      this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtFilter;
      this.layoutControlItem1.CustomizationFormText = "Filter";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(254, 24);
      this.layoutControlItem1.Text = "Filter";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Filter";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(278, 67);
      this.layoutControlGroup2.Text = "Filter";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 350);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Contacts";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.contacts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbAdd;
    private DevExpress.XtraBars.BarButtonItem tbbEdit;
    private DevExpress.XtraBars.BarButtonItem tbbView;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraGrid.GridControl gridContacts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewContacts;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private System.Windows.Forms.BindingSource contacts;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    private DevExpress.XtraGrid.Columns.GridColumn colKey;
    private DevExpress.XtraEditors.TextEdit txtFilter;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
  }
}

