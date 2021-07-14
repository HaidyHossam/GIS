namespace Map_Info
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadFile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MapName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActiveDataFrame_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MapsList_cmb = new System.Windows.Forms.ComboBox();
            this.Layers_List = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FeatureClass_txt = new System.Windows.Forms.TextBox();
            this.LayerIndex_txt = new System.Windows.Forms.TextBox();
            this.LayerName_txt = new System.Windows.Forms.TextBox();
            this.DatabasePath_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ZoomIn_btn = new System.Windows.Forms.Button();
            this.ZoomOut_btn = new System.Windows.Forms.Button();
            this.FullExtent_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ExecuteQuery_btn = new System.Windows.Forms.Button();
            this.QueryExp_txt = new System.Windows.Forms.TextBox();
            this.ClearSelection_btn = new System.Windows.Forms.Button();
            this.QueryBuilder_btn = new System.Windows.Forms.Button();
            this.DisplayAttr_btn = new System.Windows.Forms.Button();
            this.SpatialQuery_btn = new System.Windows.Forms.Button();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFile_btn
            // 
            this.LoadFile_btn.Location = new System.Drawing.Point(126, 55);
            this.LoadFile_btn.Name = "LoadFile_btn";
            this.LoadFile_btn.Size = new System.Drawing.Size(75, 23);
            this.LoadFile_btn.TabIndex = 0;
            this.LoadFile_btn.Text = "Load MXD";
            this.LoadFile_btn.UseVisualStyleBackColor = true;
            this.LoadFile_btn.Click += new System.EventHandler(this.LoadFile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Document:";
            // 
            // MapName_txt
            // 
            this.MapName_txt.Location = new System.Drawing.Point(101, 19);
            this.MapName_txt.Name = "MapName_txt";
            this.MapName_txt.Size = new System.Drawing.Size(145, 20);
            this.MapName_txt.TabIndex = 2;
            this.MapName_txt.Text = "C:\\Data\\Maps\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Active Data Frame (On ArcMap) :";
            // 
            // ActiveDataFrame_lbl
            // 
            this.ActiveDataFrame_lbl.AutoSize = true;
            this.ActiveDataFrame_lbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.ActiveDataFrame_lbl.Location = new System.Drawing.Point(185, 107);
            this.ActiveDataFrame_lbl.Name = "ActiveDataFrame_lbl";
            this.ActiveDataFrame_lbl.Size = new System.Drawing.Size(141, 13);
            this.ActiveDataFrame_lbl.TabIndex = 4;
            this.ActiveDataFrame_lbl.Text = "Put Active Data Frame Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maps (Data Frame) : ";
            // 
            // MapsList_cmb
            // 
            this.MapsList_cmb.FormattingEnabled = true;
            this.MapsList_cmb.Location = new System.Drawing.Point(126, 137);
            this.MapsList_cmb.Name = "MapsList_cmb";
            this.MapsList_cmb.Size = new System.Drawing.Size(121, 21);
            this.MapsList_cmb.TabIndex = 6;
            this.MapsList_cmb.SelectedIndexChanged += new System.EventHandler(this.MapsList_cmb_SelectedIndexChanged);
            // 
            // Layers_List
            // 
            this.Layers_List.FormattingEnabled = true;
            this.Layers_List.Location = new System.Drawing.Point(126, 164);
            this.Layers_List.Name = "Layers_List";
            this.Layers_List.Size = new System.Drawing.Size(120, 94);
            this.Layers_List.TabIndex = 7;
            this.Layers_List.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Layers_List_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FeatureClass_txt);
            this.groupBox1.Controls.Add(this.LayerIndex_txt);
            this.groupBox1.Controls.Add(this.LayerName_txt);
            this.groupBox1.Controls.Add(this.DatabasePath_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Layer From GeoDatabase";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(86, 181);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 10;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(92, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Order of layer at table of contents";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(92, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Name to be displayed on the map";
            // 
            // FeatureClass_txt
            // 
            this.FeatureClass_txt.Location = new System.Drawing.Point(92, 58);
            this.FeatureClass_txt.Name = "FeatureClass_txt";
            this.FeatureClass_txt.Size = new System.Drawing.Size(139, 20);
            this.FeatureClass_txt.TabIndex = 7;
            // 
            // LayerIndex_txt
            // 
            this.LayerIndex_txt.Location = new System.Drawing.Point(92, 129);
            this.LayerIndex_txt.Name = "LayerIndex_txt";
            this.LayerIndex_txt.Size = new System.Drawing.Size(46, 20);
            this.LayerIndex_txt.TabIndex = 6;
            // 
            // LayerName_txt
            // 
            this.LayerName_txt.Location = new System.Drawing.Point(92, 87);
            this.LayerName_txt.Name = "LayerName_txt";
            this.LayerName_txt.Size = new System.Drawing.Size(139, 20);
            this.LayerName_txt.TabIndex = 5;
            // 
            // DatabasePath_txt
            // 
            this.DatabasePath_txt.Location = new System.Drawing.Point(92, 27);
            this.DatabasePath_txt.Name = "DatabasePath_txt";
            this.DatabasePath_txt.Size = new System.Drawing.Size(139, 20);
            this.DatabasePath_txt.TabIndex = 4;
            this.DatabasePath_txt.Text = "C:\\Data\\GIS Databases\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Layer Index :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Layer Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Feature Class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "GeoDatabase :";
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(440, 465);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(294, 20);
            this.Location_txt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Current Location";
            // 
            // ZoomIn_btn
            // 
            this.ZoomIn_btn.Location = new System.Drawing.Point(790, 463);
            this.ZoomIn_btn.Name = "ZoomIn_btn";
            this.ZoomIn_btn.Size = new System.Drawing.Size(75, 23);
            this.ZoomIn_btn.TabIndex = 12;
            this.ZoomIn_btn.Text = "Zoom In";
            this.ZoomIn_btn.UseVisualStyleBackColor = true;
            this.ZoomIn_btn.Click += new System.EventHandler(this.ZoomIn_btn_Click);
            // 
            // ZoomOut_btn
            // 
            this.ZoomOut_btn.Location = new System.Drawing.Point(871, 463);
            this.ZoomOut_btn.Name = "ZoomOut_btn";
            this.ZoomOut_btn.Size = new System.Drawing.Size(75, 23);
            this.ZoomOut_btn.TabIndex = 13;
            this.ZoomOut_btn.Text = "Zoom Out";
            this.ZoomOut_btn.UseVisualStyleBackColor = true;
            this.ZoomOut_btn.Click += new System.EventHandler(this.ZoomOut_btn_Click);
            // 
            // FullExtent_btn
            // 
            this.FullExtent_btn.Location = new System.Drawing.Point(952, 463);
            this.FullExtent_btn.Name = "FullExtent_btn";
            this.FullExtent_btn.Size = new System.Drawing.Size(75, 23);
            this.FullExtent_btn.TabIndex = 14;
            this.FullExtent_btn.Text = "Full Extent";
            this.FullExtent_btn.UseVisualStyleBackColor = true;
            this.FullExtent_btn.Click += new System.EventHandler(this.FullExtent_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1042, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Query Expression :";
            // 
            // ExecuteQuery_btn
            // 
            this.ExecuteQuery_btn.Location = new System.Drawing.Point(1100, 143);
            this.ExecuteQuery_btn.Name = "ExecuteQuery_btn";
            this.ExecuteQuery_btn.Size = new System.Drawing.Size(96, 23);
            this.ExecuteQuery_btn.TabIndex = 17;
            this.ExecuteQuery_btn.Text = "Execute Query";
            this.ExecuteQuery_btn.UseVisualStyleBackColor = true;
            this.ExecuteQuery_btn.Click += new System.EventHandler(this.ExecuteQuery_btn_Click);
            // 
            // QueryExp_txt
            // 
            this.QueryExp_txt.Location = new System.Drawing.Point(1045, 44);
            this.QueryExp_txt.Multiline = true;
            this.QueryExp_txt.Name = "QueryExp_txt";
            this.QueryExp_txt.Size = new System.Drawing.Size(191, 93);
            this.QueryExp_txt.TabIndex = 16;
            // 
            // ClearSelection_btn
            // 
            this.ClearSelection_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ClearSelection_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearSelection_btn.Location = new System.Drawing.Point(1100, 172);
            this.ClearSelection_btn.Name = "ClearSelection_btn";
            this.ClearSelection_btn.Size = new System.Drawing.Size(96, 27);
            this.ClearSelection_btn.TabIndex = 18;
            this.ClearSelection_btn.Text = "Clear Selection";
            this.ClearSelection_btn.UseVisualStyleBackColor = true;
            this.ClearSelection_btn.Click += new System.EventHandler(this.ClearSelection_btn_Click_1);
            // 
            // QueryBuilder_btn
            // 
            this.QueryBuilder_btn.Location = new System.Drawing.Point(1147, 461);
            this.QueryBuilder_btn.Name = "QueryBuilder_btn";
            this.QueryBuilder_btn.Size = new System.Drawing.Size(96, 24);
            this.QueryBuilder_btn.TabIndex = 19;
            this.QueryBuilder_btn.Text = "Query Builder";
            this.QueryBuilder_btn.UseVisualStyleBackColor = true;
            this.QueryBuilder_btn.Click += new System.EventHandler(this.QueryBuilder_btn_Click);
            // 
            // DisplayAttr_btn
            // 
            this.DisplayAttr_btn.Location = new System.Drawing.Point(1041, 431);
            this.DisplayAttr_btn.Name = "DisplayAttr_btn";
            this.DisplayAttr_btn.Size = new System.Drawing.Size(202, 25);
            this.DisplayAttr_btn.TabIndex = 20;
            this.DisplayAttr_btn.Text = "Display Selected  Feature Attributes";
            this.DisplayAttr_btn.UseVisualStyleBackColor = true;
            this.DisplayAttr_btn.Click += new System.EventHandler(this.DisplayAttr_btn_Click);
            // 
            // SpatialQuery_btn
            // 
            this.SpatialQuery_btn.Location = new System.Drawing.Point(1041, 461);
            this.SpatialQuery_btn.Name = "SpatialQuery_btn";
            this.SpatialQuery_btn.Size = new System.Drawing.Size(100, 25);
            this.SpatialQuery_btn.TabIndex = 21;
            this.SpatialQuery_btn.Text = "Spatial Query";
            this.SpatialQuery_btn.UseVisualStyleBackColor = true;
            this.SpatialQuery_btn.Click += new System.EventHandler(this.SpatialQuery_btn_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(347, 12);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(680, 442);
            this.axMapControl1.TabIndex = 9;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 493);
            this.Controls.Add(this.SpatialQuery_btn);
            this.Controls.Add(this.DisplayAttr_btn);
            this.Controls.Add(this.QueryBuilder_btn);
            this.Controls.Add(this.ClearSelection_btn);
            this.Controls.Add(this.ExecuteQuery_btn);
            this.Controls.Add(this.QueryExp_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FullExtent_btn);
            this.Controls.Add(this.ZoomOut_btn);
            this.Controls.Add(this.ZoomIn_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Layers_List);
            this.Controls.Add(this.MapsList_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveDataFrame_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapName_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadFile_btn);
            this.Name = "Form1";
            this.Text = "Map Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFile_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MapName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ActiveDataFrame_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MapsList_cmb;
        private System.Windows.Forms.CheckedListBox Layers_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FeatureClass_txt;
        private System.Windows.Forms.TextBox LayerIndex_txt;
        private System.Windows.Forms.TextBox LayerName_txt;
        private System.Windows.Forms.TextBox DatabasePath_txt;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ZoomIn_btn;
        private System.Windows.Forms.Button ZoomOut_btn;
        private System.Windows.Forms.Button FullExtent_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ExecuteQuery_btn;
        private System.Windows.Forms.TextBox QueryExp_txt;
        private System.Windows.Forms.Button ClearSelection_btn;
        private System.Windows.Forms.Button QueryBuilder_btn;
        private System.Windows.Forms.Button DisplayAttr_btn;
        private System.Windows.Forms.Button SpatialQuery_btn;
    }
}

