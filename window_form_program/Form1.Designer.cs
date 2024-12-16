namespace hw2
{
    partial class MyDrawing_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDrawing_Form));
            this.shape_info_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_buttom = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IG_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shape_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_shape_buttom = new System.Windows.Forms.Button();
            this.shape_type_comboBox = new System.Windows.Forms.ComboBox();
            this.shape_text_textBox = new System.Windows.Forms.TextBox();
            this.shape_x_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Height_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.X_label = new System.Windows.Forms.Label();
            this.shape_width_textBox = new System.Windows.Forms.TextBox();
            this.shape_height_textBox = new System.Windows.Forms.TextBox();
            this.shape_y_textBox = new System.Windows.Forms.TextBox();
            this.Text_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartToolButton = new System.Windows.Forms.ToolStripButton();
            this.TerminatorToolButton = new System.Windows.Forms.ToolStripButton();
            this.ProcessToolButton = new System.Windows.Forms.ToolStripButton();
            this.DecisionToolButton = new System.Windows.Forms.ToolStripButton();
            this.LineToolButton = new System.Windows.Forms.ToolStripButton();
            this.GeneralStateBottom = new System.Windows.Forms.ToolStripButton();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.shape_info_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shape_info_dataGridView
            // 
            this.shape_info_dataGridView.AllowUserToAddRows = false;
            this.shape_info_dataGridView.AllowUserToDeleteRows = false;
            this.shape_info_dataGridView.AllowUserToOrderColumns = true;
            this.shape_info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shape_info_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete_buttom,
            this.IG_Column,
            this.shape_Column,
            this.text_Column,
            this.X_Column,
            this.Y_Column,
            this.height_Column,
            this.width_Column});
            this.shape_info_dataGridView.Location = new System.Drawing.Point(5, 57);
            this.shape_info_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shape_info_dataGridView.Name = "shape_info_dataGridView";
            this.shape_info_dataGridView.ReadOnly = true;
            this.shape_info_dataGridView.RowHeadersVisible = false;
            this.shape_info_dataGridView.RowHeadersWidth = 51;
            this.shape_info_dataGridView.Size = new System.Drawing.Size(293, 488);
            this.shape_info_dataGridView.TabIndex = 0;
            this.shape_info_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shape_info_dataGridView_CellContentClick);
            // 
            // delete_buttom
            // 
            this.delete_buttom.HeaderText = "刪除";
            this.delete_buttom.MinimumWidth = 6;
            this.delete_buttom.Name = "delete_buttom";
            this.delete_buttom.ReadOnly = true;
            this.delete_buttom.Text = "刪除";
            this.delete_buttom.UseColumnTextForButtonValue = true;
            this.delete_buttom.Width = 50;
            // 
            // IG_Column
            // 
            this.IG_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IG_Column.HeaderText = "ID";
            this.IG_Column.MinimumWidth = 6;
            this.IG_Column.Name = "IG_Column";
            this.IG_Column.ReadOnly = true;
            this.IG_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IG_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IG_Column.Width = 23;
            // 
            // shape_Column
            // 
            this.shape_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shape_Column.HeaderText = "形狀";
            this.shape_Column.MinimumWidth = 6;
            this.shape_Column.Name = "shape_Column";
            this.shape_Column.ReadOnly = true;
            this.shape_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shape_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shape_Column.Width = 35;
            // 
            // text_Column
            // 
            this.text_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.text_Column.HeaderText = "文字";
            this.text_Column.MinimumWidth = 6;
            this.text_Column.Name = "text_Column";
            this.text_Column.ReadOnly = true;
            this.text_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.text_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.text_Column.Width = 35;
            // 
            // X_Column
            // 
            this.X_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.X_Column.HeaderText = "X";
            this.X_Column.MinimumWidth = 6;
            this.X_Column.Name = "X_Column";
            this.X_Column.ReadOnly = true;
            this.X_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.X_Column.Width = 19;
            // 
            // Y_Column
            // 
            this.Y_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Y_Column.HeaderText = "Y";
            this.Y_Column.MinimumWidth = 6;
            this.Y_Column.Name = "Y_Column";
            this.Y_Column.ReadOnly = true;
            this.Y_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Y_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y_Column.Width = 19;
            // 
            // height_Column
            // 
            this.height_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.height_Column.HeaderText = "H";
            this.height_Column.MinimumWidth = 6;
            this.height_Column.Name = "height_Column";
            this.height_Column.ReadOnly = true;
            this.height_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.height_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.height_Column.Width = 19;
            // 
            // width_Column
            // 
            this.width_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.width_Column.HeaderText = "W";
            this.width_Column.MinimumWidth = 6;
            this.width_Column.Name = "width_Column";
            this.width_Column.ReadOnly = true;
            this.width_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.width_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.width_Column.Width = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 73);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 76);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // add_shape_buttom
            // 
            this.add_shape_buttom.Location = new System.Drawing.Point(5, 21);
            this.add_shape_buttom.Name = "add_shape_buttom";
            this.add_shape_buttom.Size = new System.Drawing.Size(48, 34);
            this.add_shape_buttom.TabIndex = 4;
            this.add_shape_buttom.Text = "新增";
            this.add_shape_buttom.UseVisualStyleBackColor = true;
            this.add_shape_buttom.Click += new System.EventHandler(this.add_shape_buttom_Click);
            // 
            // shape_type_comboBox
            // 
            this.shape_type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shape_type_comboBox.ForeColor = System.Drawing.Color.Red;
            this.shape_type_comboBox.FormattingEnabled = true;
            this.shape_type_comboBox.Items.AddRange(new object[] {
            "Start",
            "Terminator",
            "Process",
            "Decision"});
            this.shape_type_comboBox.Location = new System.Drawing.Point(59, 32);
            this.shape_type_comboBox.Name = "shape_type_comboBox";
            this.shape_type_comboBox.Size = new System.Drawing.Size(49, 20);
            this.shape_type_comboBox.TabIndex = 5;
            this.shape_type_comboBox.SelectedIndexChanged += new System.EventHandler(this.shape_type_comboBox_SelectedIndexChanged);
            // 
            // shape_text_textBox
            // 
            this.shape_text_textBox.Location = new System.Drawing.Point(114, 30);
            this.shape_text_textBox.Name = "shape_text_textBox";
            this.shape_text_textBox.Size = new System.Drawing.Size(67, 22);
            this.shape_text_textBox.TabIndex = 6;
            this.shape_text_textBox.TextChanged += new System.EventHandler(this.shape_text_textBox_TextChanged);
            // 
            // shape_x_textBox
            // 
            this.shape_x_textBox.Location = new System.Drawing.Point(187, 30);
            this.shape_x_textBox.Name = "shape_x_textBox";
            this.shape_x_textBox.Size = new System.Drawing.Size(23, 22);
            this.shape_x_textBox.TabIndex = 7;
            this.shape_x_textBox.TextChanged += new System.EventHandler(this.shape_x_textBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Height_label);
            this.groupBox1.Controls.Add(this.Width_label);
            this.groupBox1.Controls.Add(this.Y_label);
            this.groupBox1.Controls.Add(this.X_label);
            this.groupBox1.Controls.Add(this.shape_width_textBox);
            this.groupBox1.Controls.Add(this.shape_height_textBox);
            this.groupBox1.Controls.Add(this.shape_y_textBox);
            this.groupBox1.Controls.Add(this.Text_label);
            this.groupBox1.Controls.Add(this.shape_info_dataGridView);
            this.groupBox1.Controls.Add(this.add_shape_buttom);
            this.groupBox1.Controls.Add(this.shape_type_comboBox);
            this.groupBox1.Controls.Add(this.shape_x_textBox);
            this.groupBox1.Controls.Add(this.shape_text_textBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(710, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 530);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料顯示";
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.ForeColor = System.Drawing.Color.Red;
            this.Height_label.Location = new System.Drawing.Point(250, 14);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(13, 12);
            this.Height_label.TabIndex = 17;
            this.Height_label.Text = "H";
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.ForeColor = System.Drawing.Color.Red;
            this.Width_label.Location = new System.Drawing.Point(278, 14);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(16, 12);
            this.Width_label.TabIndex = 16;
            this.Width_label.Text = "W";
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.ForeColor = System.Drawing.Color.Red;
            this.Y_label.Location = new System.Drawing.Point(220, 14);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(13, 12);
            this.Y_label.TabIndex = 15;
            this.Y_label.Text = "Y";
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.ForeColor = System.Drawing.Color.Red;
            this.X_label.Location = new System.Drawing.Point(192, 15);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(13, 12);
            this.X_label.TabIndex = 14;
            this.X_label.Text = "X";
            // 
            // shape_width_textBox
            // 
            this.shape_width_textBox.Location = new System.Drawing.Point(274, 29);
            this.shape_width_textBox.Name = "shape_width_textBox";
            this.shape_width_textBox.Size = new System.Drawing.Size(23, 22);
            this.shape_width_textBox.TabIndex = 13;
            this.shape_width_textBox.TextChanged += new System.EventHandler(this.shape_width_textBox_TextChanged);
            // 
            // shape_height_textBox
            // 
            this.shape_height_textBox.Location = new System.Drawing.Point(245, 29);
            this.shape_height_textBox.Name = "shape_height_textBox";
            this.shape_height_textBox.Size = new System.Drawing.Size(23, 22);
            this.shape_height_textBox.TabIndex = 12;
            this.shape_height_textBox.TextChanged += new System.EventHandler(this.shape_height_textBox_TextChanged);
            // 
            // shape_y_textBox
            // 
            this.shape_y_textBox.Location = new System.Drawing.Point(216, 29);
            this.shape_y_textBox.Name = "shape_y_textBox";
            this.shape_y_textBox.Size = new System.Drawing.Size(23, 22);
            this.shape_y_textBox.TabIndex = 11;
            this.shape_y_textBox.TextChanged += new System.EventHandler(this.shape_y_textBox_TextChanged);
            // 
            // Text_label
            // 
            this.Text_label.AutoSize = true;
            this.Text_label.ForeColor = System.Drawing.Color.Red;
            this.Text_label.Location = new System.Drawing.Point(131, 15);
            this.Text_label.Name = "Text_label";
            this.Text_label.Size = new System.Drawing.Size(29, 12);
            this.Text_label.TabIndex = 10;
            this.Text_label.Text = "文字";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(173, 530);
            this.dataGridView2.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolButton,
            this.TerminatorToolButton,
            this.ProcessToolButton,
            this.DecisionToolButton,
            this.LineToolButton,
            this.GeneralStateBottom,
            this.UndoButton,
            this.RedoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // StartToolButton
            // 
            this.StartToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartToolButton.Image = ((System.Drawing.Image)(resources.GetObject("StartToolButton.Image")));
            this.StartToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartToolButton.Name = "StartToolButton";
            this.StartToolButton.Size = new System.Drawing.Size(24, 24);
            this.StartToolButton.Text = "toolStripButton1";
            this.StartToolButton.Click += new System.EventHandler(this.StartToolButton_Click);
            // 
            // TerminatorToolButton
            // 
            this.TerminatorToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TerminatorToolButton.Image = ((System.Drawing.Image)(resources.GetObject("TerminatorToolButton.Image")));
            this.TerminatorToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TerminatorToolButton.Name = "TerminatorToolButton";
            this.TerminatorToolButton.Size = new System.Drawing.Size(24, 24);
            this.TerminatorToolButton.Text = "toolStripButton2";
            this.TerminatorToolButton.Click += new System.EventHandler(this.TerminatorToolButton_Click);
            // 
            // ProcessToolButton
            // 
            this.ProcessToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProcessToolButton.Image = ((System.Drawing.Image)(resources.GetObject("ProcessToolButton.Image")));
            this.ProcessToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProcessToolButton.Name = "ProcessToolButton";
            this.ProcessToolButton.Size = new System.Drawing.Size(24, 24);
            this.ProcessToolButton.Text = "toolStripButton3";
            this.ProcessToolButton.Click += new System.EventHandler(this.ProcessToolButton_Click);
            // 
            // DecisionToolButton
            // 
            this.DecisionToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DecisionToolButton.Image = ((System.Drawing.Image)(resources.GetObject("DecisionToolButton.Image")));
            this.DecisionToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecisionToolButton.Name = "DecisionToolButton";
            this.DecisionToolButton.Size = new System.Drawing.Size(24, 24);
            this.DecisionToolButton.Text = "toolStripButton4";
            this.DecisionToolButton.Click += new System.EventHandler(this.DecisionToolButton_Click);
            // 
            // LineToolButton
            // 
            this.LineToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineToolButton.Image = ((System.Drawing.Image)(resources.GetObject("LineToolButton.Image")));
            this.LineToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineToolButton.Name = "LineToolButton";
            this.LineToolButton.Size = new System.Drawing.Size(24, 24);
            this.LineToolButton.Text = "toolStripButton1";
            this.LineToolButton.Click += new System.EventHandler(this.LineToolButton_Click);
            // 
            // GeneralStateBottom
            // 
            this.GeneralStateBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GeneralStateBottom.Image = ((System.Drawing.Image)(resources.GetObject("GeneralStateBottom.Image")));
            this.GeneralStateBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GeneralStateBottom.Name = "GeneralStateBottom";
            this.GeneralStateBottom.Size = new System.Drawing.Size(24, 24);
            this.GeneralStateBottom.Text = "toolStripButton1";
            this.GeneralStateBottom.Click += new System.EventHandler(this.GeneralStateBottom_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(24, 24);
            this.UndoButton.Text = "toolStripButton1";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(24, 24);
            this.RedoButton.Text = "toolStripButton2";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // MyDrawing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyDrawing_Form";
            this.Text = "MyDrawing";
            ((System.ComponentModel.ISupportInitialize)(this.shape_info_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shape_info_dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.Button add_shape_buttom;
        private System.Windows.Forms.ComboBox shape_type_comboBox;
        private System.Windows.Forms.TextBox shape_text_textBox;
        private System.Windows.Forms.TextBox shape_x_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Text_label;
        private System.Windows.Forms.TextBox shape_width_textBox;
        private System.Windows.Forms.TextBox shape_height_textBox;
        private System.Windows.Forms.TextBox shape_y_textBox;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewButtonColumn delete_buttom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IG_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn shape_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn text_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn width_Column;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartToolButton;
        private System.Windows.Forms.ToolStripButton TerminatorToolButton;
        private System.Windows.Forms.ToolStripButton ProcessToolButton;
        private System.Windows.Forms.ToolStripButton DecisionToolButton;
        private System.Windows.Forms.ToolStripButton GeneralStateBottom;
        private System.Windows.Forms.ToolStripButton LineToolButton;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton RedoButton;
    }
}

