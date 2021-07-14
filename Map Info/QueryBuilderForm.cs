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
    public partial class QueryBuilderForm : Form
    {
        public IEnumLayer AllLayers;
        public static string QueryTxt;
        public ILayer SelectedLayer;
        int count = 0;

        public QueryBuilderForm()
        {
            InitializeComponent();

            AllLayers = Form1.MapLayers;
            ILayer Layer;
            Layers_cmb.Items.Clear();

            AllLayers.Reset();
            Layer = AllLayers.Next();
            while (Layer != null)
            {
                Layers_cmb.Items.Add(Layer.Name);
                Layer = AllLayers.Next();
                count++;
            }
            Layers_cmb.SelectedItem = Layers_cmb.Items[0];
            Method_cmb.SelectedItem = Method_cmb.Items[0];
            LayerName_lbl.Text = Layers_cmb.Items[0].ToString() + ":";
        }
        private void Apply_btn_Click(object sender, EventArgs e)
        {
            QueryTxt = Query_txt.Text;
            IFeatureLayer FeatureLayer = SelectedLayer as IFeatureLayer;
            Form1.FeatureLayer = FeatureLayer;
            Form1.FeatureClass = FeatureLayer.FeatureClass;
            Form1.WhereClause = Query_txt.Text;
            Form1.AttributeQuery(Query_txt.Text, SelectedLayer, Method_cmb.SelectedIndex);
            this.Hide();
        }

        private void Layers_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attribute_lst.Items.Clear();
            AllLayers.Reset();
            ILayer Layer = null;
            for (int i = 0; i < Layers_cmb.SelectedIndex + 1; i++)
            {
                Layer = AllLayers.Next();
            }

            IFeatureLayer FeatureLayer = Layer as IFeatureLayer;
            SelectedLayer = Layer;
            IFeatureClass FeatureClass = FeatureLayer.FeatureClass;

            for (int i = 0; i < FeatureClass.Fields.FieldCount; i++)
            {
                if (FeatureClass.Fields.get_Field(i).Name == "Shape")
                    continue;
                Attribute_lst.Items.Add(FeatureClass.Fields.get_Field(i).Name);
            }
            LayerName_lbl.Text = Layers_cmb.Items[Layers_cmb.SelectedIndex].ToString() + ":";
        }

        private void Equal_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "=";
        }

        private void MoreThan_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += ">";
        }

        private void LessThanOrEqual_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "<=";
        }

        private void LessThan_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "<";
        }

        private void MoreThanOraequal_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += ">=";
        }

        private void NotEqual_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "<>";
        }

        private void Like_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "Like";
        }

        private void And_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "And";
        }

        private void Or_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "Or";
        }

        private void Not_btn_Click(object sender, EventArgs e)
        {
            Query_txt.Text += "Not";
        }

        private void GetUniqueVal_btn_Click(object sender, EventArgs e)
        {
            UniqueValues_lst.Items.Clear();
            IFeatureLayer FeatureLayer = SelectedLayer as IFeatureLayer;
            IFeatureClass FeatureClass = FeatureLayer.FeatureClass;

            IQueryFilter QueryFilter = new QueryFilterClass();
            IFeatureCursor FeatureCursor = FeatureClass.Search(null,true);
            IFeature Feature = FeatureCursor.NextFeature();

            int index = 0;
            for (int i = 0; i < Attribute_lst.Items.Count + 1; i++)
            {
                if (Feature.Fields.get_Field(i).Name == Attribute_lst.SelectedItem.ToString())
                {
                    index = i;
                    break;
                }
            }

            while (Feature != null)
            {
                UniqueValues_lst.Items.Add("'" + Feature.get_Value(index) + "'");
                Feature = FeatureCursor.NextFeature();
            }
        }

        private void Attribute_lst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.Attribute_lst.IndexFromPoint(e.Location);
            Query_txt.Text += Attribute_lst.Items[index].ToString();
        }

        private void UniqueValues_lst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.UniqueValues_lst.IndexFromPoint(e.Location);
            Query_txt.Text += UniqueValues_lst.Items[index].ToString();
        }
    }
}
