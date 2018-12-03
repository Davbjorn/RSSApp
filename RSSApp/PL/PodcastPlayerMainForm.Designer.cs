﻿namespace RSSApp.PL {
    partial class PodcastPlayerMainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gvFeeds = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumEpisodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFeedCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btFeedAdd = new System.Windows.Forms.Button();
            this.btFeedRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKategoryName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btCategoryAdd = new System.Windows.Forms.Button();
            this.btCategoryRemove = new System.Windows.Forms.Button();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.lbEpisodes = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriesControllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeds)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbEpisodes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 574);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gvFeeds, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 287);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gvFeeds
            // 
            this.gvFeeds.AllowUserToAddRows = false;
            this.gvFeeds.AllowUserToDeleteRows = false;
            this.gvFeeds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFeeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColTimer,
            this.ColNumEpisodes,
            this.ColCategory});
            this.gvFeeds.Location = new System.Drawing.Point(3, 33);
            this.gvFeeds.MultiSelect = false;
            this.gvFeeds.Name = "gvFeeds";
            this.gvFeeds.Size = new System.Drawing.Size(534, 211);
            this.gvFeeds.TabIndex = 0;
            this.gvFeeds.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvFeeds_CellBeginEdit);
            this.gvFeeds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFeeds_CellDoubleClick);
            this.gvFeeds.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFeeds_CellValueChanged);
            this.gvFeeds.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvFeeds_DataError);
            this.gvFeeds.SelectionChanged += new System.EventHandler(this.gvFeeds_SelectionChanged);
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Namn";
            this.ColName.Name = "ColName";
            // 
            // ColTimer
            // 
            this.ColTimer.HeaderText = "Timer";
            this.ColTimer.Name = "ColTimer";
            // 
            // ColNumEpisodes
            // 
            this.ColNumEpisodes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNumEpisodes.HeaderText = "Avsnitt";
            this.ColNumEpisodes.Name = "ColNumEpisodes";
            this.ColNumEpisodes.ReadOnly = true;
            this.ColNumEpisodes.ToolTipText = "Antal avsnitt";
            // 
            // ColCategory
            // 
            this.ColCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColCategory.HeaderText = "Kategori";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 247);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(540, 40);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbURL, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(125, 40);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbURL.Location = new System.Drawing.Point(3, 16);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(122, 20);
            this.tbURL.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cbFeedCategory, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(250, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(125, 40);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori";
            // 
            // cbFeedCategory
            // 
            this.cbFeedCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFeedCategory.FormattingEnabled = true;
            this.cbFeedCategory.Location = new System.Drawing.Point(3, 16);
            this.cbFeedCategory.Name = "cbFeedCategory";
            this.cbFeedCategory.Size = new System.Drawing.Size(119, 21);
            this.cbFeedCategory.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.btFeedAdd, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btFeedRemove, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(375, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(165, 40);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // btFeedAdd
            // 
            this.btFeedAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btFeedAdd.Location = new System.Drawing.Point(3, 3);
            this.btFeedAdd.Name = "btFeedAdd";
            this.btFeedAdd.Size = new System.Drawing.Size(76, 34);
            this.btFeedAdd.TabIndex = 0;
            this.btFeedAdd.Text = "Lägg till";
            this.btFeedAdd.UseVisualStyleBackColor = true;
            this.btFeedAdd.Click += new System.EventHandler(this.btFeedAdd_Click);
            // 
            // btFeedRemove
            // 
            this.btFeedRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btFeedRemove.Location = new System.Drawing.Point(85, 3);
            this.btFeedRemove.Name = "btFeedRemove";
            this.btFeedRemove.Size = new System.Drawing.Size(77, 34);
            this.btFeedRemove.TabIndex = 1;
            this.btFeedRemove.Text = "Ta bort";
            this.btFeedRemove.UseVisualStyleBackColor = true;
            this.btFeedRemove.Click += new System.EventHandler(this.btFeedRemove_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lvCategories, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(540, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(541, 287);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 247);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(541, 40);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tbKategoryName, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(341, 40);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorinamn";
            // 
            // tbKategoryName
            // 
            this.tbKategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKategoryName.Location = new System.Drawing.Point(3, 16);
            this.tbKategoryName.Name = "tbKategoryName";
            this.tbKategoryName.Size = new System.Drawing.Size(335, 20);
            this.tbKategoryName.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.btCategoryAdd, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btCategoryRemove, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(341, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // btCategoryAdd
            // 
            this.btCategoryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCategoryAdd.Location = new System.Drawing.Point(3, 3);
            this.btCategoryAdd.Name = "btCategoryAdd";
            this.btCategoryAdd.Size = new System.Drawing.Size(94, 34);
            this.btCategoryAdd.TabIndex = 0;
            this.btCategoryAdd.Text = "Lägg till";
            this.btCategoryAdd.UseVisualStyleBackColor = true;
            this.btCategoryAdd.Click += new System.EventHandler(this.btCategoryAdd_Click);
            // 
            // btCategoryRemove
            // 
            this.btCategoryRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCategoryRemove.Location = new System.Drawing.Point(103, 3);
            this.btCategoryRemove.Name = "btCategoryRemove";
            this.btCategoryRemove.Size = new System.Drawing.Size(94, 34);
            this.btCategoryRemove.TabIndex = 1;
            this.btCategoryRemove.Text = "Ta bort";
            this.btCategoryRemove.UseVisualStyleBackColor = true;
            this.btCategoryRemove.Click += new System.EventHandler(this.btCategoryRemove_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCategories.LabelEdit = true;
            this.lvCategories.Location = new System.Drawing.Point(3, 3);
            this.lvCategories.MultiSelect = false;
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(535, 241);
            this.lvCategories.TabIndex = 2;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.View = System.Windows.Forms.View.List;
            this.lvCategories.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvCategories_AfterLabelEdit);
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEpisodes.FormattingEnabled = true;
            this.lbEpisodes.Location = new System.Drawing.Point(3, 290);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(534, 281);
            this.lbEpisodes.TabIndex = 2;
            this.lbEpisodes.DoubleClick += new System.EventHandler(this.lbEpisodes_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(578, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.cbFilter, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(540, 30);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(273, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(264, 21);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Filter:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tbTimer, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(125, 0);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(125, 40);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // tbTimer
            // 
            this.tbTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimer.Location = new System.Drawing.Point(3, 16);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(119, 20);
            this.tbTimer.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Timer";
            // 
            // categoriesControllerBindingSource1
            // 
            this.categoriesControllerBindingSource1.DataSource = typeof(RSSApp.BLL.CategoriesController);
            // 
            // categoriesControllerBindingSource
            // 
            this.categoriesControllerBindingSource.DataSource = typeof(RSSApp.BLL.CategoriesController);
            // 
            // PodcastPlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(831, 440);
            this.Name = "PodcastPlayerMainForm";
            this.Text = "PodcastPlayerMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PodcastPlayerMainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFeeds)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gvFeeds;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox lbEpisodes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btFeedAdd;
        private System.Windows.Forms.Button btFeedRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKategoryName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btCategoryAdd;
        private System.Windows.Forms.Button btCategoryRemove;
        private System.Windows.Forms.ComboBox cbFeedCategory;
        private System.Windows.Forms.BindingSource categoriesControllerBindingSource;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.BindingSource categoriesControllerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumEpisodes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label label5;
    }
}