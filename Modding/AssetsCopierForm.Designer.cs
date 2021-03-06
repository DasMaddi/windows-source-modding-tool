﻿namespace source_modding_tool.Tools
{
    partial class AssetsCopierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsCopierForm));
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.readMapButton = new DevExpress.XtraEditors.SimpleButton();
            this.vmfList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.removeButton = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.statusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.vmfList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonSearch.ImageOptions.SvgImage")));
            this.buttonSearch.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.buttonSearch.Location = new System.Drawing.Point(3, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(23, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Add";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // readMapButton
            // 
            this.readMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readMapButton.Enabled = false;
            this.readMapButton.Location = new System.Drawing.Point(355, 8);
            this.readMapButton.Margin = new System.Windows.Forms.Padding(8);
            this.readMapButton.Name = "readMapButton";
            this.readMapButton.Size = new System.Drawing.Size(75, 23);
            this.readMapButton.TabIndex = 3;
            this.readMapButton.Text = "Copy assets";
            this.readMapButton.Click += new System.EventHandler(this.readMapButton_Click);
            // 
            // vmfList
            // 
            this.vmfList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn3});
            this.vmfList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vmfList.Location = new System.Drawing.Point(8, 8);
            this.vmfList.Name = "vmfList";
            this.vmfList.OptionsBehavior.Editable = false;
            this.vmfList.Size = new System.Drawing.Size(393, 194);
            this.vmfList.TabIndex = 5;
            this.vmfList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.vmfList_FocusedNodeChanged);
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "VMFs";
            this.treeListColumn3.FieldName = "vmf";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("removeButton.ImageOptions.SvgImage")));
            this.removeButton.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.removeButton.Location = new System.Drawing.Point(3, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(23, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.statusLabel});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statusLabel)});
            this.statusBar.OptionsBar.AllowCollapse = true;
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DisableClose = true;
            this.statusBar.OptionsBar.DisableCustomization = true;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // statusLabel
            // 
            this.statusLabel.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.statusLabel.Caption = "Ready";
            this.statusLabel.Id = 0;
            this.statusLabel.Name = "statusLabel";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(438, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 241);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(438, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(438, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 241);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.readMapButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 202);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(438, 39);
            this.panelControl1.TabIndex = 11;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.buttonSearch);
            this.panelControl3.Controls.Add(this.removeButton);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(401, 8);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(29, 194);
            this.panelControl3.TabIndex = 6;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            this.xtraOpenFileDialog1.Filter = "Valve Map Files (*.vmf)|*.vmf";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.vmfList);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.panelControl2.Size = new System.Drawing.Size(438, 202);
            this.panelControl2.TabIndex = 18;
            // 
            // AssetsCopierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 265);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetsCopierForm";
            this.Text = "Assets copier";
            this.Load += new System.EventHandler(this.AssetsCopierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vmfList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton buttonSearch;
        private DevExpress.XtraEditors.SimpleButton readMapButton;
        private DevExpress.XtraTreeList.TreeList vmfList;
        private DevExpress.XtraEditors.SimpleButton removeButton;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarStaticItem statusLabel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}