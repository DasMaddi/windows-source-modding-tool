﻿namespace SourceModdingTool
{
    partial class NewModForm
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewModForm));
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.textFolder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.createButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelFolderInfo = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.textFolder.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFolder
            // 
            this.textFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFolder.Location = new System.Drawing.Point(0, 0);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(754, 20);
            this.textFolder.TabIndex = 1;
            this.textFolder.EditValueChanged += new System.EventHandler(this.textFolder_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Folder name";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(631, 8);
            this.createButton.Margin = new System.Windows.Forms.Padding(8);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 760F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 241);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.AutoSize = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.textFolder);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(68, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(754, 38);
            this.panelControl3.TabIndex = 8;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.labelFolderInfo);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 20);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(754, 18);
            this.panelControl4.TabIndex = 1;
            // 
            // labelFolderInfo
            // 
            this.labelFolderInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFolderInfo.Location = new System.Drawing.Point(691, 0);
            this.labelFolderInfo.Name = "labelFolderInfo";
            this.labelFolderInfo.Size = new System.Drawing.Size(63, 13);
            this.labelFolderInfo.TabIndex = 7;
            this.labelFolderInfo.Text = "Invalid folder";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.createButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 283);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(714, 39);
            this.panelControl1.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.galleryControl1);
            this.panelControl2.Controls.Add(this.tableLayoutPanel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.panelControl2.Size = new System.Drawing.Size(714, 283);
            this.panelControl2.TabIndex = 10;
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Games";
            galleryItem1.Caption = "Half-Life 2";
            galleryItem1.Enabled = false;
            galleryItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            galleryItem1.Tag = "Source SDK Base 2013 Singleplayer/hl2";
            galleryItem2.Caption = "Half-Life 2: Episode One";
            galleryItem2.Enabled = false;
            galleryItem2.Hint = "hey";
            galleryItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            galleryItem2.Tag = "Source SDK Base 2013 Singleplayer/episodic";
            galleryItem3.Caption = "Half-Life 2: Episode Two";
            galleryItem3.Enabled = false;
            galleryItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            galleryItem3.Tag = "Source SDK Base 2013 Singleplayer/ep2";
            galleryItem4.Caption = "Portal";
            galleryItem4.Enabled = false;
            galleryItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            galleryItem4.Tag = "Portal/portal";
            galleryItem5.Caption = "Half-Life 2: Deathmatch";
            galleryItem5.Enabled = false;
            galleryItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            galleryItem5.Tag = "Source SDK Base 2013 Multiplayer/hl2mp";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5});
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(111, 166);
            this.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            this.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.galleryControl1.Gallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.galleryControl1_Gallery_ItemCheckedChanged);
            this.galleryControl1.Location = new System.Drawing.Point(8, 8);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(698, 233);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryGames";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(677, 229);
            // 
            // NewModForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 322);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewModForm";
            this.Text = "New Mod";
            this.Load += new System.EventHandler(this.NewModForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textFolder.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textFolder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton createButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelFolderInfo;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}