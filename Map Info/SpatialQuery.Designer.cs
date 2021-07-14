namespace Map_Info
{
    partial class SpatialQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Methods_cmb = new System.Windows.Forms.ComboBox();
            this.TargetLayer_lst = new System.Windows.Forms.CheckedListBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Layer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spatial Selection Method for Target Layer Feature:";
            // 
            // Methods_cmb
            // 
            this.Methods_cmb.FormattingEnabled = true;
            this.Methods_cmb.Items.AddRange(new object[] {
            "Contains",
            "Intersect",
            "Touches",
            "Within"});
            this.Methods_cmb.Location = new System.Drawing.Point(15, 259);
            this.Methods_cmb.Name = "Methods_cmb";
            this.Methods_cmb.Size = new System.Drawing.Size(348, 21);
            this.Methods_cmb.TabIndex = 3;
            // 
            // TargetLayer_lst
            // 
            this.TargetLayer_lst.FormattingEnabled = true;
            this.TargetLayer_lst.Location = new System.Drawing.Point(15, 37);
            this.TargetLayer_lst.Name = "TargetLayer_lst";
            this.TargetLayer_lst.Size = new System.Drawing.Size(348, 184);
            this.TargetLayer_lst.TabIndex = 4;
            this.TargetLayer_lst.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TargetLayer_lst_ItemCheck_1);
            // 
            // Apply_btn
            // 
            this.Apply_btn.Location = new System.Drawing.Point(288, 300);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(75, 23);
            this.Apply_btn.TabIndex = 5;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // SpatialQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 341);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.TargetLayer_lst);
            this.Controls.Add(this.Methods_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpatialQuery";
            this.Text = "Spatial Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Methods_cmb;
        private System.Windows.Forms.CheckedListBox TargetLayer_lst;
        private System.Windows.Forms.Button Apply_btn;
    }
}