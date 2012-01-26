﻿using System;
using BrightIdeasSoftware;
namespace TESVSnip.ObjectControls
{
    partial class RecordSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordSearch));
            this.toolStripIncrFind = new System.Windows.Forms.ToolStrip();
            this.toolStripSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripIncrFindText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripIncrFindTypeFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripIncrFindGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSynchronize = new System.Windows.Forms.ToolStripButton();
            this.toolStripIncrFindCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripIncrFindType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripIncrFindMatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripIncrFindExact = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIncrFindStatus = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listSearchView = new BrightIdeasSoftware.ObjectListView();
            this.toolStripIncrFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSearchView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripIncrFind
            // 
            resources.ApplyResources(this.toolStripIncrFind, "toolStripIncrFind");
            this.toolStripIncrFind.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripIncrFind.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchLabel,
            this.toolStripIncrFindText,
            this.toolStripIncrFindTypeFilter,
            this.toolStripIncrFindGo,
            this.toolStripSynchronize,
            this.toolStripIncrFindCancel,
            this.toolStripIncrFindType,
            this.toolStripIncrFindMatch,
            this.toolStripIncrFindExact,
            this.toolStripSeparator7,
            this.toolStripIncrFindStatus});
            this.toolStripIncrFind.Name = "toolStripIncrFind";
            // 
            // toolStripSearchLabel
            // 
            this.toolStripSearchLabel.Name = "toolStripSearchLabel";
            resources.ApplyResources(this.toolStripSearchLabel, "toolStripSearchLabel");
            // 
            // toolStripIncrFindText
            // 
            resources.ApplyResources(this.toolStripIncrFindText, "toolStripIncrFindText");
            this.toolStripIncrFindText.Name = "toolStripIncrFindText";
            this.toolStripIncrFindText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripIncrFindText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripIncrFindText_KeyDown);
            this.toolStripIncrFindText.TextChanged += new System.EventHandler(this.toolStripIncrFindText_TextChanged);
            // 
            // toolStripIncrFindTypeFilter
            // 
            this.toolStripIncrFindTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripIncrFindTypeFilter.Items.AddRange(new object[] {
            resources.GetString("toolStripIncrFindTypeFilter.Items"),
            resources.GetString("toolStripIncrFindTypeFilter.Items1")});
            this.toolStripIncrFindTypeFilter.Name = "toolStripIncrFindTypeFilter";
            this.toolStripIncrFindTypeFilter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            resources.ApplyResources(this.toolStripIncrFindTypeFilter, "toolStripIncrFindTypeFilter");
            this.toolStripIncrFindTypeFilter.SelectedIndexChanged += new System.EventHandler(this.toolStripIncrFindTypeFilter_SelectedIndexChanged);
            // 
            // toolStripIncrFindGo
            // 
            this.toolStripIncrFindGo.Image = global::TESVSnip.Properties.Resources.find;
            resources.ApplyResources(this.toolStripIncrFindGo, "toolStripIncrFindGo");
            this.toolStripIncrFindGo.Name = "toolStripIncrFindGo";
            this.toolStripIncrFindGo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripIncrFindGo.Click += new System.EventHandler(this.toolStripIncrFindGo_Click);
            // 
            // toolStripSynchronize
            // 
            this.toolStripSynchronize.AutoToolTip = false;
            this.toolStripSynchronize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSynchronize.Image = global::TESVSnip.Properties.Resources.reload_all_tabs;
            resources.ApplyResources(this.toolStripSynchronize, "toolStripSynchronize");
            this.toolStripSynchronize.Name = "toolStripSynchronize";
            this.toolStripSynchronize.Click += new System.EventHandler(this.toolStripSynchronize_Click);
            // 
            // toolStripIncrFindCancel
            // 
            this.toolStripIncrFindCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripIncrFindCancel.Image = global::TESVSnip.Properties.Resources.agt_stop;
            resources.ApplyResources(this.toolStripIncrFindCancel, "toolStripIncrFindCancel");
            this.toolStripIncrFindCancel.Name = "toolStripIncrFindCancel";
            this.toolStripIncrFindCancel.Click += new System.EventHandler(this.toolStripIncrFindCancel_Click);
            // 
            // toolStripIncrFindType
            // 
            this.toolStripIncrFindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripIncrFindType.Items.AddRange(new object[] {
            resources.GetString("toolStripIncrFindType.Items"),
            resources.GetString("toolStripIncrFindType.Items1")});
            this.toolStripIncrFindType.Name = "toolStripIncrFindType";
            resources.ApplyResources(this.toolStripIncrFindType, "toolStripIncrFindType");
            this.toolStripIncrFindType.SelectedIndexChanged += new System.EventHandler(this.toolStripIncrFindType_SelectedIndexChanged);
            // 
            // toolStripIncrFindMatch
            // 
            this.toolStripIncrFindMatch.CheckOnClick = true;
            this.toolStripIncrFindMatch.Image = global::TESVSnip.Properties.Resources.emptybox;
            resources.ApplyResources(this.toolStripIncrFindMatch, "toolStripIncrFindMatch");
            this.toolStripIncrFindMatch.Name = "toolStripIncrFindMatch";
            this.toolStripIncrFindMatch.CheckStateChanged += new System.EventHandler(this.toolStripCheck_CheckStateChanged);
            // 
            // toolStripIncrFindExact
            // 
            this.toolStripIncrFindExact.CheckOnClick = true;
            this.toolStripIncrFindExact.Image = global::TESVSnip.Properties.Resources.emptybox;
            resources.ApplyResources(this.toolStripIncrFindExact, "toolStripIncrFindExact");
            this.toolStripIncrFindExact.Name = "toolStripIncrFindExact";
            this.toolStripIncrFindExact.CheckStateChanged += new System.EventHandler(this.toolStripCheck_CheckStateChanged);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // toolStripIncrFindStatus
            // 
            this.toolStripIncrFindStatus.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripIncrFindStatus.Name = "toolStripIncrFindStatus";
            this.toolStripIncrFindStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            resources.ApplyResources(this.toolStripIncrFindStatus, "toolStripIncrFindStatus");
            // 
            // contextMenuStripList
            // 
            this.contextMenuStripList.Name = "contextMenuStripList";
            resources.ApplyResources(this.contextMenuStripList, "contextMenuStripList");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // listSearchView
            // 
            this.listSearchView.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.listSearchView.ContextMenuStrip = this.contextMenuStripList;
            resources.ApplyResources(this.listSearchView, "listSearchView");
            this.listSearchView.EmptyListMsgFont = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSearchView.EnableSearchByKeyboard = true;
            this.listSearchView.FullRowSelect = true;
            this.listSearchView.GridLines = true;
            this.listSearchView.HideSelection = false;
            this.listSearchView.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.listSearchView.HighlightForegroundColor = System.Drawing.SystemColors.HighlightText;
            this.listSearchView.Name = "listSearchView";
            this.listSearchView.OwnerDraw = true;
            this.listSearchView.UnfocusedHighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.listSearchView.UnfocusedHighlightForegroundColor = System.Drawing.SystemColors.HighlightText;
            this.listSearchView.UseAlternatingBackColors = true;
            this.listSearchView.UseCompatibleStateImageBehavior = false;
            this.listSearchView.View = System.Windows.Forms.View.Details;
            this.listSearchView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listSearchView_CellClick);
            // 
            // RecordSearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listSearchView);
            this.Controls.Add(this.toolStripIncrFind);
            this.Name = "RecordSearch";
            this.Load += new System.EventHandler(this.RecordSearch_Load);
            this.toolStripIncrFind.ResumeLayout(false);
            this.toolStripIncrFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSearchView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripIncrFind;
        private System.Windows.Forms.ToolStripButton toolStripIncrFindCancel;
        private System.Windows.Forms.ToolStripComboBox toolStripIncrFindTypeFilter;
        private System.Windows.Forms.ToolStripButton toolStripIncrFindGo;
        private System.Windows.Forms.ToolStripComboBox toolStripIncrFindType;
        private System.Windows.Forms.ToolStripButton toolStripIncrFindMatch;
        private System.Windows.Forms.ToolStripButton toolStripIncrFindExact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripIncrFindStatus;
        private ObjectListView listSearchView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripList;
        private System.Windows.Forms.ToolStripComboBox toolStripIncrFindText;
        private System.Windows.Forms.ToolStripLabel toolStripSearchLabel;
        private System.Windows.Forms.ToolStripButton toolStripSynchronize;
    }
}