namespace Map_Info
{
    partial class SelectedAttributes
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
            this.Attributes_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Attributes_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Attributes_grid
            // 
            this.Attributes_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attributes_grid.Location = new System.Drawing.Point(12, 12);
            this.Attributes_grid.Name = "Attributes_grid";
            this.Attributes_grid.Size = new System.Drawing.Size(659, 308);
            this.Attributes_grid.TabIndex = 0;
            // 
            // SelectedAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 332);
            this.Controls.Add(this.Attributes_grid);
            this.Name = "SelectedAttributes";
            this.Text = "Selected Features Attributes";
            ((System.ComponentModel.ISupportInitialize)(this.Attributes_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Attributes_grid;
    }
}