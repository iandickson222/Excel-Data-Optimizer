namespace Excel_Optimizer_2._0
{
    partial class Excel_Data_Optimizer_Form
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
            this.Status_Strip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress_Bar = new System.Windows.Forms.ToolStripProgressBar();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.File_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_Excel_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Excel_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Excel_File_As = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Split_Container = new System.Windows.Forms.SplitContainer();
            this.Optimization_Value = new System.Windows.Forms.GroupBox();
            this.Run_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Output_Row_Label = new System.Windows.Forms.Label();
            this.Output_Column_Label = new System.Windows.Forms.Label();
            this.M_Row = new System.Windows.Forms.TextBox();
            this.M_Column = new System.Windows.Forms.TextBox();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Category = new System.Windows.Forms.Label();
            this.Componet_Container = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Constraint_Container = new System.Windows.Forms.ComboBox();
            this.Values = new System.Windows.Forms.GroupBox();
            this.Label_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Row_Label = new System.Windows.Forms.Label();
            this.Column_Label = new System.Windows.Forms.Label();
            this.Minimum_Label = new System.Windows.Forms.Label();
            this.Maximum_Label = new System.Windows.Forms.Label();
            this.Precision_Label = new System.Windows.Forms.Label();
            this.Optimal_Label = new System.Windows.Forms.Label();
            this.Open_File = new System.Windows.Forms.OpenFileDialog();
            this.Save_File_As = new System.Windows.Forms.SaveFileDialog();
            this.Background_Worker = new System.ComponentModel.BackgroundWorker();
            this.Status_Strip.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split_Container)).BeginInit();
            this.Split_Container.Panel1.SuspendLayout();
            this.Split_Container.Panel2.SuspendLayout();
            this.Split_Container.SuspendLayout();
            this.Optimization_Value.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Parameters.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Values.SuspendLayout();
            this.Label_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_Strip
            // 
            this.Status_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.Progress_Bar});
            this.Status_Strip.Location = new System.Drawing.Point(0, 424);
            this.Status_Strip.Name = "Status_Strip";
            this.Status_Strip.Size = new System.Drawing.Size(800, 26);
            this.Status_Strip.TabIndex = 1;
            this.Status_Strip.Text = "Status Strip";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 20);
            this.Status.Text = "Ready";
            // 
            // Progress_Bar
            // 
            this.Progress_Bar.Name = "Progress_Bar";
            this.Progress_Bar.Size = new System.Drawing.Size(100, 19);
            this.Progress_Bar.Visible = false;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Button});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 28);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // File_Button
            // 
            this.File_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load_Excel_File,
            this.Save_Excel_File,
            this.Save_Excel_File_As,
            this.toolStripSeparator1,
            this.Exit_Button});
            this.File_Button.Name = "File_Button";
            this.File_Button.Size = new System.Drawing.Size(46, 24);
            this.File_Button.Text = "File";
            // 
            // Load_Excel_File
            // 
            this.Load_Excel_File.Name = "Load_Excel_File";
            this.Load_Excel_File.Size = new System.Drawing.Size(143, 26);
            this.Load_Excel_File.Text = "Load";
            this.Load_Excel_File.Click += new System.EventHandler(this.Load_Excel_File_Click);
            // 
            // Save_Excel_File
            // 
            this.Save_Excel_File.Name = "Save_Excel_File";
            this.Save_Excel_File.Size = new System.Drawing.Size(143, 26);
            this.Save_Excel_File.Text = "Save";
            this.Save_Excel_File.Click += new System.EventHandler(this.Save_Excel_File_Click);
            // 
            // Save_Excel_File_As
            // 
            this.Save_Excel_File_As.Name = "Save_Excel_File_As";
            this.Save_Excel_File_As.Size = new System.Drawing.Size(143, 26);
            this.Save_Excel_File_As.Text = "Save As";
            this.Save_Excel_File_As.Click += new System.EventHandler(this.Save_Excel_File_As_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(143, 26);
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Split_Container
            // 
            this.Split_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Split_Container.Location = new System.Drawing.Point(0, 28);
            this.Split_Container.Name = "Split_Container";
            // 
            // Split_Container.Panel1
            // 
            this.Split_Container.Panel1.Controls.Add(this.Optimization_Value);
            this.Split_Container.Panel1.Controls.Add(this.Parameters);
            // 
            // Split_Container.Panel2
            // 
            this.Split_Container.Panel2.Controls.Add(this.Values);
            this.Split_Container.Size = new System.Drawing.Size(800, 397);
            this.Split_Container.SplitterDistance = 266;
            this.Split_Container.TabIndex = 3;
            // 
            // Optimization_Value
            // 
            this.Optimization_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Optimization_Value.Controls.Add(this.Run_Button);
            this.Optimization_Value.Controls.Add(this.tableLayoutPanel2);
            this.Optimization_Value.Location = new System.Drawing.Point(3, 164);
            this.Optimization_Value.Name = "Optimization_Value";
            this.Optimization_Value.Size = new System.Drawing.Size(260, 230);
            this.Optimization_Value.TabIndex = 1;
            this.Optimization_Value.TabStop = false;
            this.Optimization_Value.Text = "Maxmize/Minimize";
            // 
            // Run_Button
            // 
            this.Run_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Run_Button.Location = new System.Drawing.Point(6, 88);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(248, 40);
            this.Run_Button.TabIndex = 1;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Output_Row_Label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Output_Column_Label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.M_Row, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.M_Column, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Output_Row_Label
            // 
            this.Output_Row_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Output_Row_Label.AutoSize = true;
            this.Output_Row_Label.Location = new System.Drawing.Point(3, 6);
            this.Output_Row_Label.Name = "Output_Row_Label";
            this.Output_Row_Label.Size = new System.Drawing.Size(35, 17);
            this.Output_Row_Label.TabIndex = 1;
            this.Output_Row_Label.Text = "Row";
            // 
            // Output_Column_Label
            // 
            this.Output_Column_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Output_Column_Label.AutoSize = true;
            this.Output_Column_Label.Location = new System.Drawing.Point(130, 6);
            this.Output_Column_Label.Name = "Output_Column_Label";
            this.Output_Column_Label.Size = new System.Drawing.Size(55, 17);
            this.Output_Column_Label.TabIndex = 2;
            this.Output_Column_Label.Text = "Column";
            // 
            // M_Row
            // 
            this.M_Row.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.M_Row.Location = new System.Drawing.Point(3, 33);
            this.M_Row.Name = "M_Row";
            this.M_Row.Size = new System.Drawing.Size(121, 22);
            this.M_Row.TabIndex = 3;
            // 
            // M_Column
            // 
            this.M_Column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.M_Column.Location = new System.Drawing.Point(130, 33);
            this.M_Column.Name = "M_Column";
            this.M_Column.Size = new System.Drawing.Size(121, 22);
            this.M_Column.TabIndex = 4;
            // 
            // Parameters
            // 
            this.Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameters.Controls.Add(this.tableLayoutPanel3);
            this.Parameters.Location = new System.Drawing.Point(3, 3);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(260, 155);
            this.Parameters.TabIndex = 0;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Parameters";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Category, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Componet_Container, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Constraint_Container, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 81);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // Category
            // 
            this.Category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(3, 52);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(76, 17);
            this.Category.TabIndex = 2;
            this.Category.Text = "Constraint:";
            // 
            // Componet_Container
            // 
            this.Componet_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Componet_Container.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Componet_Container.FormattingEnabled = true;
            this.Componet_Container.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.Componet_Container.Location = new System.Drawing.Point(130, 7);
            this.Componet_Container.Name = "Componet_Container";
            this.Componet_Container.Size = new System.Drawing.Size(121, 24);
            this.Componet_Container.TabIndex = 0;
            this.Componet_Container.SelectedIndexChanged += new System.EventHandler(this.Componet_Container_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Components:";
            // 
            // Constraint_Container
            // 
            this.Constraint_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Constraint_Container.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Constraint_Container.FormattingEnabled = true;
            this.Constraint_Container.Items.AddRange(new object[] {
            "Minimize",
            "Maximize"});
            this.Constraint_Container.Location = new System.Drawing.Point(130, 48);
            this.Constraint_Container.Name = "Constraint_Container";
            this.Constraint_Container.Size = new System.Drawing.Size(121, 24);
            this.Constraint_Container.TabIndex = 3;
            this.Constraint_Container.SelectedIndexChanged += new System.EventHandler(this.Constraint_Container_SelectedIndexChanged);
            // 
            // Values
            // 
            this.Values.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Values.Controls.Add(this.Label_Layout);
            this.Values.Location = new System.Drawing.Point(3, 3);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(524, 391);
            this.Values.TabIndex = 0;
            this.Values.TabStop = false;
            this.Values.Text = "Values";
            // 
            // Label_Layout
            // 
            this.Label_Layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Layout.ColumnCount = 6;
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Label_Layout.Controls.Add(this.Row_Label, 0, 0);
            this.Label_Layout.Controls.Add(this.Column_Label, 1, 0);
            this.Label_Layout.Controls.Add(this.Minimum_Label, 2, 0);
            this.Label_Layout.Controls.Add(this.Maximum_Label, 3, 0);
            this.Label_Layout.Controls.Add(this.Precision_Label, 4, 0);
            this.Label_Layout.Controls.Add(this.Optimal_Label, 5, 0);
            this.Label_Layout.Location = new System.Drawing.Point(6, 21);
            this.Label_Layout.Name = "Label_Layout";
            this.Label_Layout.RowCount = 12;
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Label_Layout.Size = new System.Drawing.Size(509, 364);
            this.Label_Layout.TabIndex = 0;
            // 
            // Row_Label
            // 
            this.Row_Label.AutoSize = true;
            this.Row_Label.Location = new System.Drawing.Point(3, 0);
            this.Row_Label.Name = "Row_Label";
            this.Row_Label.Size = new System.Drawing.Size(35, 17);
            this.Row_Label.TabIndex = 0;
            this.Row_Label.Text = "Row";
            // 
            // Column_Label
            // 
            this.Column_Label.AutoSize = true;
            this.Column_Label.Location = new System.Drawing.Point(87, 0);
            this.Column_Label.Name = "Column_Label";
            this.Column_Label.Size = new System.Drawing.Size(55, 17);
            this.Column_Label.TabIndex = 1;
            this.Column_Label.Text = "Column";
            this.Column_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Minimum_Label
            // 
            this.Minimum_Label.AutoSize = true;
            this.Minimum_Label.Location = new System.Drawing.Point(171, 0);
            this.Minimum_Label.Name = "Minimum_Label";
            this.Minimum_Label.Size = new System.Drawing.Size(67, 30);
            this.Minimum_Label.TabIndex = 2;
            this.Minimum_Label.Text = "Minimum Value";
            // 
            // Maximum_Label
            // 
            this.Maximum_Label.AutoSize = true;
            this.Maximum_Label.Location = new System.Drawing.Point(255, 0);
            this.Maximum_Label.Name = "Maximum_Label";
            this.Maximum_Label.Size = new System.Drawing.Size(70, 30);
            this.Maximum_Label.TabIndex = 3;
            this.Maximum_Label.Text = "Maximum Value";
            // 
            // Precision_Label
            // 
            this.Precision_Label.AutoSize = true;
            this.Precision_Label.Location = new System.Drawing.Point(339, 0);
            this.Precision_Label.Name = "Precision_Label";
            this.Precision_Label.Size = new System.Drawing.Size(66, 17);
            this.Precision_Label.TabIndex = 4;
            this.Precision_Label.Text = "Precision";
            // 
            // Optimal_Label
            // 
            this.Optimal_Label.AutoSize = true;
            this.Optimal_Label.Location = new System.Drawing.Point(423, 0);
            this.Optimal_Label.Name = "Optimal_Label";
            this.Optimal_Label.Size = new System.Drawing.Size(60, 30);
            this.Optimal_Label.TabIndex = 5;
            this.Optimal_Label.Text = "Optimal Value";
            // 
            // Background_Worker
            // 
            this.Background_Worker.WorkerReportsProgress = true;
            this.Background_Worker.WorkerSupportsCancellation = true;
            this.Background_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Do_Background_Work);
            this.Background_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Background_Work_Progress);
            this.Background_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Completed_Background_Work);
            // 
            // Excel_Data_Optimizer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Split_Container);
            this.Controls.Add(this.Status_Strip);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Excel_Data_Optimizer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Data Optimizer";
            this.Status_Strip.ResumeLayout(false);
            this.Status_Strip.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Split_Container.Panel1.ResumeLayout(false);
            this.Split_Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split_Container)).EndInit();
            this.Split_Container.ResumeLayout(false);
            this.Optimization_Value.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Values.ResumeLayout(false);
            this.Label_Layout.ResumeLayout(false);
            this.Label_Layout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip Status_Strip;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem File_Button;
        private System.Windows.Forms.ToolStripMenuItem Load_Excel_File;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit_Button;
        private System.Windows.Forms.SplitContainer Split_Container;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.GroupBox Values;
        private System.Windows.Forms.OpenFileDialog Open_File;
        private System.Windows.Forms.ToolStripMenuItem Save_Excel_File_As;
        private System.Windows.Forms.SaveFileDialog Save_File_As;
        private System.Windows.Forms.TableLayoutPanel Label_Layout;
        private System.Windows.Forms.Label Row_Label;
        private System.Windows.Forms.Label Column_Label;
        private System.Windows.Forms.Label Minimum_Label;
        private System.Windows.Forms.Label Maximum_Label;
        private System.Windows.Forms.Label Precision_Label;
        private System.Windows.Forms.Label Optimal_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox Componet_Container;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Optimization_Value;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox Constraint_Container;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Output_Row_Label;
        private System.Windows.Forms.TextBox M_Row;
        private System.Windows.Forms.ToolStripMenuItem Save_Excel_File;
        private System.Windows.Forms.ToolStripProgressBar Progress_Bar;
        private System.ComponentModel.BackgroundWorker Background_Worker;
        private System.Windows.Forms.Label Output_Column_Label;
        private System.Windows.Forms.TextBox M_Column;
        private System.Windows.Forms.ToolStripStatusLabel Status;
    }
}

