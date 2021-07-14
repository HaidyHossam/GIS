using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geometry;

namespace Map_Info
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public static IEnumLayer MapLayers;
        public static IMapDocument MapDocument;
        public static IFeatureSelection FeatureSel;
        public static string WhereClause;
        public static IFeatureClass FeatureClass;
        public static IFeatureLayer FeatureLayer;

        public Form1()
        {
            InitializeComponent();
            _instance = this;
        }
        
        private void LoadFile_btn_Click(object sender, EventArgs e)
        {
            MapsList_cmb.Items.Clear();
            Layers_List.Items.Clear();
            string Path = MapName_txt.Text.ToString();
            MapDocument = new MapDocumentClass();
            MapDocument.Open(Path);
            IMap Map = MapDocument.get_Map(0);
            axMapControl1.Map = Map;
            IActiveView ActView = Map as IActiveView;
            axMapControl1.ActiveView.Extent = ActView.Extent;
            axMapControl1.Refresh();

            for (int i = 0; i < MapDocument.MapCount; i++)
            {
                MapsList_cmb.Items.Add(MapDocument.get_Map(i).Name);
            }
            MapsList_cmb.Text = MapsList_cmb.Items[0].ToString();

            ActiveDataFrame_lbl.Text = MapDocument.ActiveView.FocusMap.Name;

            Load_Layers();
        }

        private void Load_Layers() 
        {
            int Counter = 0;
            ILayer Layer;
            IEnumLayer AllLayers;
            Layers_List.Items.Clear();
            AllLayers = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            
            Layer = AllLayers.Next();
            while(Layer != null)
            {
                Layers_List.Items.Add(Layer.Name);

                if (Layer.Visible == true)
                {
                    Layers_List.SetItemChecked(Counter, true);
                }

                Layer = AllLayers.Next();
                Counter++;
            }
            axMapControl1.Refresh();
            MapLayers = AllLayers;
        }

        private void MapsList_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMap MyMap = MapDocument.get_Map(MapsList_cmb.SelectedIndex);
            axMapControl1.Map = MyMap;
            IActiveView ActView = MyMap as IActiveView;
            axMapControl1.ActiveView.Extent = ActView.Extent;
            axMapControl1.Refresh();

            Load_Layers();
        }

        private void Layers_List_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                ILayer Layer = axMapControl1.ActiveView.FocusMap.get_Layer(e.Index);
                Layer.Visible = true;
                axMapControl1.Refresh();
            }
            else
            {
                ILayer Layer = axMapControl1.ActiveView.FocusMap.get_Layer(e.Index);
                Layer.Visible = false;
                axMapControl1.Refresh();
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string Path = DatabasePath_txt.Text.ToString();
            string FeatureClassStr = FeatureClass_txt.Text.ToString();
            string LayerName = LayerName_txt.Text.ToString();
            int LayerIndex = Int32.Parse(LayerIndex_txt.Text.ToString());

            IMap FocusMap = axMapControl1.ActiveView.FocusMap;
            IWorkspaceFactory WorkspaceFactory = new AccessWorkspaceFactoryClass();
            IWorkspace Workspace;
            Workspace = WorkspaceFactory.OpenFromFile(Path, 0);
            IFeatureWorkspace FeatureWorkspace = Workspace as IFeatureWorkspace;
            IFeatureClass FeatureClass;
            FeatureClass = FeatureWorkspace.OpenFeatureClass(FeatureClassStr);
            IFeatureLayer FeatureLayer = new FeatureLayer();
            FeatureLayer.FeatureClass = FeatureClass;
            FeatureLayer.Name = LayerName;
            FeatureLayer.ShowTips = true;
            FocusMap.AddLayer(FeatureLayer);
            FocusMap.MoveLayer(FeatureLayer, LayerIndex);
            Load_Layers();
        }
        public static void AttributeQuery(string whereClause, ILayer Layer,int Method)
        {
            IQueryFilter QueryFilter = new QueryFilterClass();
            QueryFilter.WhereClause = whereClause;
            IFeatureSelection FeatSelection = Layer as IFeatureSelection;
            FeatureSel = FeatSelection;
            if (Method == 0)
                FeatSelection.SelectFeatures(QueryFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
            else if(Method == 1)
                FeatSelection.SelectFeatures(QueryFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            else
                FeatSelection.SelectFeatures(QueryFilter, esriSelectionResultEnum.esriSelectionResultSubtract, false);

            _instance.axMapControl1.Refresh();
        }

        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            Location_txt.Text = e.mapX + " , " + e.mapY + " Meters";
        }

        private void ZoomIn_btn_Click(object sender, EventArgs e)
        {
            IMap Map = MapDocument.get_Map(MapsList_cmb.SelectedIndex);
            IActiveView ActView = Map as IActiveView;
            IEnvelope Envelope = ActView.Extent;
            Envelope.Expand(0.75, 0.75, true);
            ActView.Extent = Envelope;
            ActView.Refresh();
        }

        private void ZoomOut_btn_Click(object sender, EventArgs e)
        {
            IMap Map = MapDocument.get_Map(MapsList_cmb.SelectedIndex);
            IActiveView ActView = Map as IActiveView;
            IEnvelope Envelope = ActView.Extent;
            Envelope.Expand(1.75, 1.75, true);
            ActView.Extent = Envelope;
            ActView.Refresh();
        }

        private void FullExtent_btn_Click(object sender, EventArgs e)
        {
            IMap Map = MapDocument.get_Map(MapsList_cmb.SelectedIndex);
            IActiveView ActView = Map as IActiveView;
            axMapControl1.ActiveView.Extent = ActView.FullExtent;
        }

        private void ExecuteQuery_btn_Click(object sender, EventArgs e)
        {
            string Exp = QueryExp_txt.Text.ToString();
            string[] SplitArray = Exp.Split(' ');
            string LayerName = SplitArray[3];
            int index = 0;
            WhereClause = "";
            for (int i = 0; i < Layers_List.Items.Count; i++) 
            {
                if (Layers_List.Items[i].ToString() == LayerName)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 5; i < SplitArray.Length; i++)
            {
                WhereClause += SplitArray[i];
            }

            ILayer Layer = axMapControl1.ActiveView.FocusMap.get_Layer(index);
            FeatureLayer = Layer as IFeatureLayer;
            FeatureClass = FeatureLayer.FeatureClass;
            IQueryFilter QueryFilter = new QueryFilterClass();
            QueryFilter.WhereClause = WhereClause;
            IFeatureCursor FeatureCursor = FeatureClass.Search(QueryFilter, true);
            IFeature Feature = FeatureCursor.NextFeature();
            IMap Map = MapDocument.get_Map(MapsList_cmb.SelectedIndex);

            Map.SelectFeature(FeatureLayer, Feature);
            IEnvelope Envelope = Feature.Extent;
            MapDocument.ActiveView.Extent = Envelope;
            MapDocument.ActiveView.Refresh();
        }

        private void QueryBuilder_btn_Click(object sender, EventArgs e)
        {
            QueryBuilderForm form = new QueryBuilderForm();

            form.ShowDialog();
        }

        private void DisplayAttr_btn_Click(object sender, EventArgs e)
        {
            SelectedAttributes form = new SelectedAttributes();
            form.ShowDialog();
        }

        private void SpatialQuery_btn_Click(object sender, EventArgs e)
        {
            SpatialQuery form = new SpatialQuery();
            form.ShowDialog();
        }

        private void ClearSelection_btn_Click_1(object sender, EventArgs e)
        {
            IMap Map = MapDocument.get_Map(MapsList_cmb.SelectedIndex);
            Map.ClearSelection();
            MapDocument.ActiveView.Refresh();
        }
    }
}