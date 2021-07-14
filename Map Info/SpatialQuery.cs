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
    public partial class SpatialQuery : Form
    {
        public IEnumLayer TargetLayer;
        public IFeatureLayer Target;
        public string WhereClause;
        public IFeatureClass FeatureClass;
        public IFeatureLayer FeatureLayer;
        public IMapDocument MapDoc;

        public SpatialQuery()
        {
            InitializeComponent();
            TargetLayer = Form1.MapLayers;
            ILayer Layer;
            TargetLayer_lst.Items.Clear();

            TargetLayer.Reset();
            Layer = TargetLayer.Next();
            while (Layer != null)
            {
                TargetLayer_lst.Items.Add(Layer.Name);
                Layer = TargetLayer.Next();
            }
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            WhereClause = Form1.WhereClause;
            FeatureClass = Form1.FeatureClass;
            FeatureLayer = Form1.FeatureLayer;
            MapDoc = Form1.MapDocument;
            IFeatureCursor FeatureCursor;
            IQueryFilter QueryFilter = new QueryFilterClass();
            QueryFilter.WhereClause = WhereClause;
            FeatureCursor = FeatureLayer.FeatureClass.Search(QueryFilter, true);

            IFeatureSelection FeatureSelection;
            IFeature Feature = FeatureCursor.NextFeature();

            ISpatialFilter SpatialFilter = new SpatialFilterClass();

            if (Methods_cmb.Text == "Contains")
            {
                SpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
            }
            else if (Methods_cmb.Text == "Intersect")
            {
                SpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
            }
            else if (Methods_cmb.Text == "Touches")
            {
                SpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelTouches;
            }
            else if (Methods_cmb.Text == "Within")
            {
                SpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelWithin;
            }

            SpatialFilter.Geometry = Feature.Shape;
            FeatureSelection = Target as IFeatureSelection;
            FeatureSelection.SelectFeatures(SpatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            Feature = FeatureCursor.NextFeature();
            while (Feature != null)
            {
                SpatialFilter.Geometry = Feature.Shape;
                FeatureSelection.SelectFeatures(SpatialFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                Feature = FeatureCursor.NextFeature();
            }

            MapDoc.ActiveView.Refresh();
            this.Hide();
        }
        private void TargetLayer_lst_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string Text = TargetLayer_lst.Items[e.Index].ToString();
                ILayer Layer;

                TargetLayer.Reset();
                Layer = TargetLayer.Next();
                while (Layer != null)
                {
                    if (Layer.Name == Text)
                    {
                        Target = Layer as IFeatureLayer;
                    }
                    Layer = TargetLayer.Next();
                }
            }
        }
    }
}
