namespace Map_Info
{
    partial class QueryBuilderForm
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
            this.Layers_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Method_cmb = new System.Windows.Forms.ComboBox();
            this.Attribute_lst = new System.Windows.Forms.ListBox();
            this.UniqueValues_lst = new System.Windows.Forms.ListBox();
            this.GetUniqueVal_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LayerName_lbl = new System.Windows.Forms.Label();
            this.Query_txt = new System.Windows.Forms.TextBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Equal_btn = new System.Windows.Forms.Button();
            this.LessThanOrEqual_btn = new System.Windows.Forms.Button();
            this.MoreThanOraequal_btn = new System.Windows.Forms.Button();
            this.MoreThan_btn = new System.Windows.Forms.Button();
            this.LessThan_btn = new System.Windows.Forms.Button();
            this.NotEqual_btn = new System.Windows.Forms.Button();
            this.And_btn = new System.Windows.Forms.Button();
            this.Like = new System.Windows.Forms.Button();
            this.Or_btn = new System.Windows.Forms.Button();
            this.Not_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Layers_cmb
            // 
            this.Layers_cmb.FormattingEnabled = true;
            this.Layers_cmb.Location = new System.Drawing.Point(65, 10);
            this.Layers_cmb.Name = "Layers_cmb";
            this.Layers_cmb.Size = new System.Drawing.Size(337, 21);
            this.Layers_cmb.TabIndex = 0;
            this.Layers_cmb.SelectedIndexChanged += new System.EventHandler(this.Layers_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layers: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Method: ";
            // 
            // Method_cmb
            // 
            this.Method_cmb.FormattingEnabled = true;
            this.Method_cmb.Items.AddRange(new object[] {
            "Add to current selection",
            "Create new selection",
            "Remove from current selection"});
            this.Method_cmb.Location = new System.Drawing.Point(65, 39);
            this.Method_cmb.Name = "Method_cmb";
            this.Method_cmb.Size = new System.Drawing.Size(337, 21);
            this.Method_cmb.TabIndex = 3;
            // 
            // Attribute_lst
            // 
            this.Attribute_lst.FormattingEnabled = true;
            this.Attribute_lst.Location = new System.Drawing.Point(16, 75);
            this.Attribute_lst.Name = "Attribute_lst";
            this.Attribute_lst.Size = new System.Drawing.Size(386, 134);
            this.Attribute_lst.TabIndex = 4;
            this.Attribute_lst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Attribute_lst_MouseDoubleClick);
            // 
            // UniqueValues_lst
            // 
            this.UniqueValues_lst.FormattingEnabled = true;
            this.UniqueValues_lst.Location = new System.Drawing.Point(16, 215);
            this.UniqueValues_lst.Name = "UniqueValues_lst";
            this.UniqueValues_lst.Size = new System.Drawing.Size(249, 121);
            this.UniqueValues_lst.TabIndex = 5;
            this.UniqueValues_lst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UniqueValues_lst_MouseDoubleClick);
            // 
            // GetUniqueVal_btn
            // 
            this.GetUniqueVal_btn.Location = new System.Drawing.Point(271, 302);
            this.GetUniqueVal_btn.Name = "GetUniqueVal_btn";
            this.GetUniqueVal_btn.Size = new System.Drawing.Size(76, 34);
            this.GetUniqueVal_btn.TabIndex = 6;
            this.GetUniqueVal_btn.Text = "Get Unique Values";
            this.GetUniqueVal_btn.UseVisualStyleBackColor = true;
            this.GetUniqueVal_btn.Click += new System.EventHandler(this.GetUniqueVal_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SELECT * FROM ";
            // 
            // LayerName_lbl
            // 
            this.LayerName_lbl.AutoSize = true;
            this.LayerName_lbl.Location = new System.Drawing.Point(96, 339);
            this.LayerName_lbl.Name = "LayerName_lbl";
            this.LayerName_lbl.Size = new System.Drawing.Size(35, 13);
            this.LayerName_lbl.TabIndex = 8;
            this.LayerName_lbl.Text = "label4";
            // 
            // Query_txt
            // 
            this.Query_txt.Location = new System.Drawing.Point(16, 355);
            this.Query_txt.Multiline = true;
            this.Query_txt.Name = "Query_txt";
            this.Query_txt.Size = new System.Drawing.Size(305, 87);
            this.Query_txt.TabIndex = 9;
            // 
            // Apply_btn
            // 
            this.Apply_btn.Location = new System.Drawing.Point(327, 419);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(75, 23);
            this.Apply_btn.TabIndex = 10;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Equal_btn
            // 
            this.Equal_btn.Location = new System.Drawing.Point(271, 216);
            this.Equal_btn.Name = "Equal_btn";
            this.Equal_btn.Size = new System.Drawing.Size(34, 22);
            this.Equal_btn.TabIndex = 11;
            this.Equal_btn.Text = "=";
            this.Equal_btn.UseVisualStyleBackColor = true;
            this.Equal_btn.Click += new System.EventHandler(this.Equal_btn_Click);
            // 
            // LessThanOrEqual_btn
            // 
            this.LessThanOrEqual_btn.Location = new System.Drawing.Point(271, 244);
            this.LessThanOrEqual_btn.Name = "LessThanOrEqual_btn";
            this.LessThanOrEqual_btn.Size = new System.Drawing.Size(34, 22);
            this.LessThanOrEqual_btn.TabIndex = 12;
            this.LessThanOrEqual_btn.Text = "<=";
            this.LessThanOrEqual_btn.UseVisualStyleBackColor = true;
            this.LessThanOrEqual_btn.Click += new System.EventHandler(this.LessThanOrEqual_btn_Click);
            // 
            // MoreThanOraequal_btn
            // 
            this.MoreThanOraequal_btn.Location = new System.Drawing.Point(271, 272);
            this.MoreThanOraequal_btn.Name = "MoreThanOraequal_btn";
            this.MoreThanOraequal_btn.Size = new System.Drawing.Size(34, 22);
            this.MoreThanOraequal_btn.TabIndex = 13;
            this.MoreThanOraequal_btn.Text = ">=";
            this.MoreThanOraequal_btn.UseVisualStyleBackColor = true;
            this.MoreThanOraequal_btn.Click += new System.EventHandler(this.MoreThanOraequal_btn_Click);
            // 
            // MoreThan_btn
            // 
            this.MoreThan_btn.Location = new System.Drawing.Point(311, 216);
            this.MoreThan_btn.Name = "MoreThan_btn";
            this.MoreThan_btn.Size = new System.Drawing.Size(35, 22);
            this.MoreThan_btn.TabIndex = 14;
            this.MoreThan_btn.Text = ">";
            this.MoreThan_btn.UseVisualStyleBackColor = true;
            this.MoreThan_btn.Click += new System.EventHandler(this.MoreThan_btn_Click);
            // 
            // LessThan_btn
            // 
            this.LessThan_btn.Location = new System.Drawing.Point(311, 244);
            this.LessThan_btn.Name = "LessThan_btn";
            this.LessThan_btn.Size = new System.Drawing.Size(35, 22);
            this.LessThan_btn.TabIndex = 15;
            this.LessThan_btn.Text = "<";
            this.LessThan_btn.UseVisualStyleBackColor = true;
            this.LessThan_btn.Click += new System.EventHandler(this.LessThan_btn_Click);
            // 
            // NotEqual_btn
            // 
            this.NotEqual_btn.Location = new System.Drawing.Point(312, 272);
            this.NotEqual_btn.Name = "NotEqual_btn";
            this.NotEqual_btn.Size = new System.Drawing.Size(35, 22);
            this.NotEqual_btn.TabIndex = 16;
            this.NotEqual_btn.Text = "<>";
            this.NotEqual_btn.UseVisualStyleBackColor = true;
            this.NotEqual_btn.Click += new System.EventHandler(this.NotEqual_btn_Click);
            // 
            // And_btn
            // 
            this.And_btn.Location = new System.Drawing.Point(352, 244);
            this.And_btn.Name = "And_btn";
            this.And_btn.Size = new System.Drawing.Size(50, 22);
            this.And_btn.TabIndex = 17;
            this.And_btn.Text = "And";
            this.And_btn.UseVisualStyleBackColor = true;
            this.And_btn.Click += new System.EventHandler(this.And_btn_Click);
            // 
            // Like
            // 
            this.Like.Location = new System.Drawing.Point(352, 216);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(50, 22);
            this.Like.TabIndex = 18;
            this.Like.Text = "Like";
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.Like_Click);
            // 
            // Or_btn
            // 
            this.Or_btn.Location = new System.Drawing.Point(352, 272);
            this.Or_btn.Name = "Or_btn";
            this.Or_btn.Size = new System.Drawing.Size(50, 22);
            this.Or_btn.TabIndex = 19;
            this.Or_btn.Text = "Or";
            this.Or_btn.UseVisualStyleBackColor = true;
            this.Or_btn.Click += new System.EventHandler(this.Or_btn_Click);
            // 
            // Not_btn
            // 
            this.Not_btn.Location = new System.Drawing.Point(352, 302);
            this.Not_btn.Name = "Not_btn";
            this.Not_btn.Size = new System.Drawing.Size(50, 22);
            this.Not_btn.TabIndex = 20;
            this.Not_btn.Text = "Not";
            this.Not_btn.UseVisualStyleBackColor = true;
            this.Not_btn.Click += new System.EventHandler(this.Not_btn_Click);
            // 
            // QueryBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.Not_btn);
            this.Controls.Add(this.Or_btn);
            this.Controls.Add(this.Like);
            this.Controls.Add(this.And_btn);
            this.Controls.Add(this.NotEqual_btn);
            this.Controls.Add(this.LessThan_btn);
            this.Controls.Add(this.MoreThan_btn);
            this.Controls.Add(this.MoreThanOraequal_btn);
            this.Controls.Add(this.LessThanOrEqual_btn);
            this.Controls.Add(this.Equal_btn);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.Query_txt);
            this.Controls.Add(this.LayerName_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetUniqueVal_btn);
            this.Controls.Add(this.UniqueValues_lst);
            this.Controls.Add(this.Attribute_lst);
            this.Controls.Add(this.Method_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Layers_cmb);
            this.Name = "QueryBuilderForm";
            this.Text = "Query Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Layers_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Method_cmb;
        private System.Windows.Forms.ListBox Attribute_lst;
        private System.Windows.Forms.ListBox UniqueValues_lst;
        private System.Windows.Forms.Button GetUniqueVal_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LayerName_lbl;
        private System.Windows.Forms.TextBox Query_txt;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.Button Equal_btn;
        private System.Windows.Forms.Button LessThanOrEqual_btn;
        private System.Windows.Forms.Button MoreThanOraequal_btn;
        private System.Windows.Forms.Button MoreThan_btn;
        private System.Windows.Forms.Button LessThan_btn;
        private System.Windows.Forms.Button NotEqual_btn;
        private System.Windows.Forms.Button And_btn;
        private System.Windows.Forms.Button Like;
        private System.Windows.Forms.Button Or_btn;
        private System.Windows.Forms.Button Not_btn;
    }
}