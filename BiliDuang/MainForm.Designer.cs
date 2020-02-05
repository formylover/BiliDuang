﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiliDuang
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.SearchResult = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.QualityBox = new MaterialSkin.Controls.MaterialComboBox();
            this.DownloadSelected = new MaterialSkin.Controls.MaterialFlatButton();
            this.SelectAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.videoList1 = new BiliDuang.UI.VideoList();
            this.DownloadView = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.StartAllButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PauseAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.downloadList1 = new BiliDuang.UI.Download.DownloadList();
            this.Setttings = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.LoginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.totalspeed = new MaterialSkin.Controls.MaterialLabel();
            this.Tabs.SuspendLayout();
            this.SearchResult.SuspendLayout();
            this.DownloadView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Setttings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.Tabs;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("微软雅黑", 5F);
            this.TabSelector.Location = new System.Drawing.Point(-1, 77);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1103, 54);
            this.TabSelector.TabIndex = 0;
            this.TabSelector.Text = "选择标签";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.MainTab);
            this.Tabs.Controls.Add(this.SearchResult);
            this.Tabs.Controls.Add(this.DownloadView);
            this.Tabs.Controls.Add(this.Setttings);
            this.Tabs.Depth = 0;
            this.Tabs.Font = new System.Drawing.Font("微软雅黑", 5F);
            this.Tabs.Location = new System.Drawing.Point(1, 137);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1101, 542);
            this.Tabs.TabIndex = 1;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // MainTab
            // 
            this.MainTab.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainTab.Location = new System.Drawing.Point(4, 18);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1093, 520);
            this.MainTab.TabIndex = 1;
            this.MainTab.Text = "主页";
            // 
            // SearchResult
            // 
            this.SearchResult.Controls.Add(this.materialSingleLineTextField1);
            this.SearchResult.Controls.Add(this.materialFlatButton3);
            this.SearchResult.Controls.Add(this.materialFlatButton2);
            this.SearchResult.Controls.Add(this.materialLabel3);
            this.SearchResult.Controls.Add(this.QualityBox);
            this.SearchResult.Controls.Add(this.DownloadSelected);
            this.SearchResult.Controls.Add(this.SelectAll);
            this.SearchResult.Controls.Add(this.videoList1);
            this.SearchResult.Location = new System.Drawing.Point(4, 18);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(1093, 520);
            this.SearchResult.TabIndex = 2;
            this.SearchResult.Text = "搜索结果";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(7, 59);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(487, 25);
            this.materialSingleLineTextField1.TabIndex = 18;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.materialSingleLineTextField1_KeyUp);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.IconTxt = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(496, 56);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(92, 36);
            this.materialFlatButton3.TabIndex = 17;
            this.materialFlatButton3.Text = "<-下载路径";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.IconTxt = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(938, 49);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(48, 36);
            this.materialFlatButton2.TabIndex = 15;
            this.materialFlatButton2.Text = "反选";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(583, 60);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(114, 20);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "一键设置清晰度";
            // 
            // QualityBox
            // 
            this.QualityBox.Depth = 0;
            this.QualityBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.QualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.QualityBox.FormattingEnabled = true;
            this.QualityBox.Items.AddRange(new object[] {
            "1080P60",
            "1080P+",
            "1080P",
            "720P60",
            "720P",
            "480P",
            "360P"});
            this.QualityBox.Location = new System.Drawing.Point(705, 56);
            this.QualityBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.QualityBox.Name = "QualityBox";
            this.QualityBox.Size = new System.Drawing.Size(140, 26);
            this.QualityBox.TabIndex = 13;
            this.QualityBox.SelectedIndexChanged += new System.EventHandler(this.QualityBox_SelectedIndexChanged);
            // 
            // DownloadSelected
            // 
            this.DownloadSelected.AutoSize = true;
            this.DownloadSelected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownloadSelected.Depth = 0;
            this.DownloadSelected.Icon = null;
            this.DownloadSelected.IconTxt = null;
            this.DownloadSelected.Location = new System.Drawing.Point(852, 48);
            this.DownloadSelected.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DownloadSelected.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownloadSelected.Name = "DownloadSelected";
            this.DownloadSelected.Primary = false;
            this.DownloadSelected.Size = new System.Drawing.Size(76, 36);
            this.DownloadSelected.TabIndex = 5;
            this.DownloadSelected.Text = "下载选中";
            this.DownloadSelected.UseVisualStyleBackColor = true;
            this.DownloadSelected.Click += new System.EventHandler(this.DownloadSelected_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectAll.Depth = 0;
            this.SelectAll.Icon = null;
            this.SelectAll.IconTxt = null;
            this.SelectAll.Location = new System.Drawing.Point(1004, 48);
            this.SelectAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Primary = false;
            this.SelectAll.Size = new System.Drawing.Size(76, 36);
            this.SelectAll.TabIndex = 1;
            this.SelectAll.Text = "选中全部";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // videoList1
            // 
            this.videoList1.Location = new System.Drawing.Point(-6, 93);
            this.videoList1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.videoList1.Name = "videoList1";
            this.videoList1.Size = new System.Drawing.Size(1103, 427);
            this.videoList1.TabIndex = 0;
            // 
            // DownloadView
            // 
            this.DownloadView.Controls.Add(this.panel2);
            this.DownloadView.Controls.Add(this.downloadList1);
            this.DownloadView.Location = new System.Drawing.Point(4, 18);
            this.DownloadView.Name = "DownloadView";
            this.DownloadView.Size = new System.Drawing.Size(1093, 520);
            this.DownloadView.TabIndex = 3;
            this.DownloadView.Text = "下载管理";
            this.DownloadView.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalspeed);
            this.panel2.Controls.Add(this.DeleteAll);
            this.panel2.Controls.Add(this.StartAllButton);
            this.panel2.Controls.Add(this.PauseAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 31);
            this.panel2.TabIndex = 7;
            // 
            // DeleteAll
            // 
            this.DeleteAll.AutoSize = true;
            this.DeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAll.Depth = 0;
            this.DeleteAll.Icon = null;
            this.DeleteAll.IconTxt = null;
            this.DeleteAll.Location = new System.Drawing.Point(816, 0);
            this.DeleteAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Primary = false;
            this.DeleteAll.Size = new System.Drawing.Size(76, 36);
            this.DeleteAll.TabIndex = 5;
            this.DeleteAll.Text = "删除全部";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // StartAllButton
            // 
            this.StartAllButton.AutoSize = true;
            this.StartAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartAllButton.Depth = 0;
            this.StartAllButton.Icon = null;
            this.StartAllButton.IconTxt = null;
            this.StartAllButton.Location = new System.Drawing.Point(1013, 0);
            this.StartAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartAllButton.Name = "StartAllButton";
            this.StartAllButton.Primary = false;
            this.StartAllButton.Size = new System.Drawing.Size(76, 36);
            this.StartAllButton.TabIndex = 3;
            this.StartAllButton.Text = "开始下载";
            this.StartAllButton.UseVisualStyleBackColor = true;
            this.StartAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // PauseAll
            // 
            this.PauseAll.AutoSize = true;
            this.PauseAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PauseAll.Depth = 0;
            this.PauseAll.Icon = null;
            this.PauseAll.IconTxt = null;
            this.PauseAll.Location = new System.Drawing.Point(918, -5);
            this.PauseAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PauseAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.PauseAll.Name = "PauseAll";
            this.PauseAll.Primary = false;
            this.PauseAll.Size = new System.Drawing.Size(76, 36);
            this.PauseAll.TabIndex = 4;
            this.PauseAll.Text = "暂停全部";
            this.PauseAll.UseVisualStyleBackColor = true;
            this.PauseAll.Click += new System.EventHandler(this.PauseAll_Click);
            // 
            // downloadList1
            // 
            this.downloadList1.AutoScroll = true;
            this.downloadList1.Location = new System.Drawing.Point(118, 51);
            this.downloadList1.Name = "downloadList1";
            this.downloadList1.Size = new System.Drawing.Size(965, 469);
            this.downloadList1.TabIndex = 0;
            // 
            // Setttings
            // 
            this.Setttings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Setttings.Controls.Add(this.materialSingleLineTextField2);
            this.Setttings.Controls.Add(this.materialLabel4);
            this.Setttings.Controls.Add(this.materialFlatButton4);
            this.Setttings.Location = new System.Drawing.Point(4, 18);
            this.Setttings.Name = "Setttings";
            this.Setttings.Size = new System.Drawing.Size(1093, 520);
            this.Setttings.TabIndex = 4;
            this.Setttings.Text = "设置";
            this.Setttings.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(167, 102);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(186, 25);
            this.materialSingleLineTextField2.TabIndex = 2;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "1";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            this.materialSingleLineTextField2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.materialSingleLineTextField2_KeyUp);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(68, 102);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 20);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "同时下载数";
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.IconTxt = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(72, 46);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(103, 36);
            this.materialFlatButton4.TabIndex = 0;
            this.materialFlatButton4.Text = "测试FFmpeg";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(51, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 50);
            this.panel1.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Depth = 0;
            this.SearchBox.Hint = "输入AV号,md号,ss号,ep号,链接,输入完成按回车";
            this.SearchBox.Location = new System.Drawing.Point(133, 23);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.Size = new System.Drawing.Size(743, 25);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            this.SearchBox.UseSystemPasswordChar = false;
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.IconTxt = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(887, 15);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(103, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Link Start!";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 28);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "勇者大人请传令->";
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(411, 86);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(691, 33);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Icon = null;
            this.LoginButton.IconTxt = null;
            this.LoginButton.Location = new System.Drawing.Point(857, 30);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = false;
            this.LoginButton.Size = new System.Drawing.Size(168, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "登录bilibili,开启新世界";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // totalspeed
            // 
            this.totalspeed.AutoSize = true;
            this.totalspeed.Depth = 0;
            this.totalspeed.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.totalspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalspeed.Location = new System.Drawing.Point(649, 5);
            this.totalspeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalspeed.Name = "totalspeed";
            this.totalspeed.Size = new System.Drawing.Size(93, 20);
            this.totalspeed.TabIndex = 6;
            this.totalspeed.Text = "TotalSpeed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.TabSelector);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "BiliDuang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Tabs.ResumeLayout(false);
            this.SearchResult.ResumeLayout(false);
            this.SearchResult.PerformLayout();
            this.DownloadView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Setttings.ResumeLayout(false);
            this.Setttings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void materialListView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage MainTab;
        private MaterialSkin.Controls.MaterialFlatButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        public MaterialSkin.Controls.MaterialSingleLineTextField SearchBox;
        private Panel panel1;
        private TabPage SearchResult;
        private UI.VideoList videoList1;
        private TabPage DownloadView;
        public UI.Download.DownloadList downloadList1;
        private MaterialSkin.Controls.MaterialFlatButton SelectAll;
        private MaterialSkin.Controls.MaterialFlatButton DownloadSelected;
        private MaterialSkin.Controls.MaterialComboBox QualityBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton DeleteAll;
        private MaterialSkin.Controls.MaterialFlatButton StartAllButton;
        private MaterialSkin.Controls.MaterialFlatButton PauseAll;
        private TabPage Setttings;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        public MaterialSkin.Controls.MaterialLabel totalspeed;
    }
}

