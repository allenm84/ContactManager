namespace ContactManager
{
  partial class EditNameDialog
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
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.txtFirst = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtMiddle = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtLast = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtFirst.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMiddle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLast.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.txtLast);
      this.layoutControl1.Controls.Add(this.txtMiddle);
      this.layoutControl1.Controls.Add(this.txtFirst);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(616, 87, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(186, 129);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(186, 129);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // txtFirst
      // 
      this.txtFirst.Location = new System.Drawing.Point(46, 12);
      this.txtFirst.Name = "txtFirst";
      this.txtFirst.Size = new System.Drawing.Size(128, 20);
      this.txtFirst.StyleController = this.layoutControl1;
      this.txtFirst.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtFirst;
      this.layoutControlItem2.CustomizationFormText = "First";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(166, 24);
      this.layoutControlItem2.Text = "First";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 13);
      // 
      // txtMiddle
      // 
      this.txtMiddle.Location = new System.Drawing.Point(46, 36);
      this.txtMiddle.Name = "txtMiddle";
      this.txtMiddle.Size = new System.Drawing.Size(128, 20);
      this.txtMiddle.StyleController = this.layoutControl1;
      this.txtMiddle.TabIndex = 6;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.txtMiddle;
      this.layoutControlItem3.CustomizationFormText = "Middle";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(166, 24);
      this.layoutControlItem3.Text = "Middle";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(30, 13);
      // 
      // txtLast
      // 
      this.txtLast.Location = new System.Drawing.Point(46, 60);
      this.txtLast.Name = "txtLast";
      this.txtLast.Size = new System.Drawing.Size(128, 20);
      this.txtLast.StyleController = this.layoutControl1;
      this.txtLast.TabIndex = 7;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.txtLast;
      this.layoutControlItem4.CustomizationFormText = "Last";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(166, 24);
      this.layoutControlItem4.Text = "Last";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(30, 13);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(22, 95);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 9;
      this.btnOK.Text = "OK";
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnOK;
      this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem6.Location = new System.Drawing.Point(10, 83);
      this.layoutControlItem6.MaxSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem6.MinSize = new System.Drawing.Size(78, 26);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(78, 26);
      this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem6.Text = "layoutControlItem6";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextToControlDistance = 0;
      this.layoutControlItem6.TextVisible = false;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(100, 95);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnCancel;
      this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
      this.layoutControlItem7.Location = new System.Drawing.Point(88, 83);
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
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 83);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(10, 26);
      this.emptySpaceItem1.Text = "emptySpaceItem1";
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 72);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(166, 11);
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // EditNameDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(186, 129);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditNameDialog";
      this.Text = "EditNameDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtFirst.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMiddle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLast.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtLast;
    private DevExpress.XtraEditors.TextEdit txtMiddle;
    private DevExpress.XtraEditors.TextEdit txtFirst;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
  }
}