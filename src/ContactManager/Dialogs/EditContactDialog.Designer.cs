namespace ContactManager
{
  partial class EditContactDialog
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
      this.lstDates = new ContactManager.DataListEditor();
      this.lstEmails = new ContactManager.DataListEditor();
      this.lstAddresses = new ContactManager.DataListEditor();
      this.lstPhones = new ContactManager.DataListEditor();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.txtName = new DevExpress.XtraEditors.ButtonEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.memoEdit1);
      this.layoutControl1.Controls.Add(this.lstDates);
      this.layoutControl1.Controls.Add(this.lstEmails);
      this.layoutControl1.Controls.Add(this.lstAddresses);
      this.layoutControl1.Controls.Add(this.lstPhones);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(795, 192, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(360, 304);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // memoEdit1
      // 
      this.memoEdit1.Location = new System.Drawing.Point(24, 86);
      this.memoEdit1.Name = "memoEdit1";
      this.memoEdit1.Size = new System.Drawing.Size(312, 168);
      this.memoEdit1.StyleController = this.layoutControl1;
      this.memoEdit1.TabIndex = 16;
      this.memoEdit1.UseOptimizedRendering = true;
      // 
      // lstDates
      // 
      this.lstDates.Location = new System.Drawing.Point(24, 86);
      this.lstDates.Name = "lstDates";
      this.lstDates.Size = new System.Drawing.Size(312, 168);
      this.lstDates.TabIndex = 15;
      this.lstDates.AddClick += new System.EventHandler(this.lstDates_AddClick);
      this.lstDates.EditClick += new System.EventHandler(this.lstDates_EditClick);
      // 
      // lstEmails
      // 
      this.lstEmails.Location = new System.Drawing.Point(24, 86);
      this.lstEmails.Name = "lstEmails";
      this.lstEmails.Size = new System.Drawing.Size(312, 168);
      this.lstEmails.TabIndex = 14;
      this.lstEmails.AddClick += new System.EventHandler(this.lstEmails_AddClick);
      this.lstEmails.EditClick += new System.EventHandler(this.lstEmails_EditClick);
      // 
      // lstAddresses
      // 
      this.lstAddresses.Location = new System.Drawing.Point(24, 86);
      this.lstAddresses.Name = "lstAddresses";
      this.lstAddresses.Size = new System.Drawing.Size(312, 168);
      this.lstAddresses.TabIndex = 13;
      this.lstAddresses.AddClick += new System.EventHandler(this.lstAddresses_AddClick);
      this.lstAddresses.EditClick += new System.EventHandler(this.lstAddresses_EditClick);
      // 
      // lstPhones
      // 
      this.lstPhones.Location = new System.Drawing.Point(24, 86);
      this.lstPhones.Name = "lstPhones";
      this.lstPhones.Size = new System.Drawing.Size(312, 168);
      this.lstPhones.TabIndex = 12;
      this.lstPhones.AddClick += new System.EventHandler(this.lstPhones_AddClick);
      this.lstPhones.EditClick += new System.EventHandler(this.lstPhones_EditClick);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(274, 270);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(196, 270);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 10;
      this.btnOK.Text = "OK";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(12, 28);
      this.txtName.Name = "txtName";
      this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.txtName.Size = new System.Drawing.Size(336, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 4;
      this.txtName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtName_ButtonClick);
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.tabbedControlGroup1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(360, 304);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtName;
      this.layoutControlItem1.CustomizationFormText = "Name:";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(340, 40);
      this.layoutControlItem1.Text = "Name:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 13);
      // 
      // tabbedControlGroup1
      // 
      this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
      this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 40);
      this.tabbedControlGroup1.Name = "tabbedControlGroup1";
      this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
      this.tabbedControlGroup1.SelectedTabPageIndex = 0;
      this.tabbedControlGroup1.Size = new System.Drawing.Size(340, 218);
      this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.layoutControlGroup6});
      this.tabbedControlGroup1.Text = "tabbedControlGroup1";
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Phone";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(316, 172);
      this.layoutControlGroup3.Text = "Phone";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.lstPhones;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(316, 172);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Addresses";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(316, 172);
      this.layoutControlGroup2.Text = "Addresses";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.lstAddresses;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(316, 172);
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.CustomizationFormText = "Email";
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(316, 172);
      this.layoutControlGroup4.Text = "Email";
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.lstEmails;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(316, 172);
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlGroup5
      // 
      this.layoutControlGroup5.CustomizationFormText = "Dates";
      this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
      this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new System.Drawing.Size(316, 172);
      this.layoutControlGroup5.Text = "Dates";
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.lstDates;
      this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(316, 172);
      this.layoutControlItem5.Text = "layoutControlItem5";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlGroup6
      // 
      this.layoutControlGroup6.CustomizationFormText = "Notes";
      this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
      this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup6.Name = "layoutControlGroup6";
      this.layoutControlGroup6.Size = new System.Drawing.Size(316, 172);
      this.layoutControlGroup6.Text = "Notes";
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.memoEdit1;
      this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(316, 172);
      this.layoutControlItem6.Text = "layoutControlItem6";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextToControlDistance = 0;
      this.layoutControlItem6.TextVisible = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnOK;
      this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
      this.layoutControlItem7.Location = new System.Drawing.Point(184, 258);
      this.layoutControlItem7.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem7.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem7.Text = "layoutControlItem7";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextToControlDistance = 0;
      this.layoutControlItem7.TextVisible = false;
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.Control = this.btnCancel;
      this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
      this.layoutControlItem8.Location = new System.Drawing.Point(262, 258);
      this.layoutControlItem8.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem8.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem8.Text = "layoutControlItem8";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem8.TextToControlDistance = 0;
      this.layoutControlItem8.TextVisible = false;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 258);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(184, 26);
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // EditContactDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(360, 304);
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditContactDialog";
      this.Text = "EditContactDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.ButtonEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    private DataListEditor lstPhones;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DataListEditor lstDates;
    private DataListEditor lstEmails;
    private DataListEditor lstAddresses;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
    private DevExpress.XtraEditors.MemoEdit memoEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
  }
}