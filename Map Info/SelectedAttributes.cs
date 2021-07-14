using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geometry;

namespace Map_Info
{
    public partial class SelectedAttributes : Form
    {
        IFeatureSelection FeatureSel;
        public SelectedAttributes()
        {
            InitializeComponent();
            FeatureSel = Form1.FeatureSel;
            ISelectionSet set =  FeatureSel.SelectionSet;
            ICursor FeatureCursor;
            set.Search(null, true,out FeatureCursor);

            IRow Row = FeatureCursor.NextRow();
            for (int i = 0; i < FeatureCursor.Fields.FieldCount; i++)
            {
                if (FeatureCursor.Fields.get_Field(i).Name == "Shape")
                    continue;
                Attributes_grid.Columns.Add(FeatureCursor.Fields.get_Field(i).Name, FeatureCursor.Fields.get_Field(i).Name);
            }

            int count = 0;
            int colCount = 0;
            while (Row != null)
            {
                Attributes_grid.Rows.Add(1);
                for (int i = 0; i < FeatureCursor.Fields.FieldCount; i++)
                {
                    if (FeatureCursor.Fields.get_Field(i).Name == "Shape")
                        continue;
                        
                    Attributes_grid.Rows[count].Cells[colCount].Value = Row.get_Value(i);
                    colCount++;
                }
                Row = FeatureCursor.NextRow();
                count++;
                colCount = 0;
            }
        }
    }
}
