using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using System.IO;
using Microsoft.Office;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;

namespace PHTC.Reporter
{
    public class WordReporter:BaseReporter
    {
        protected const string MS_ProId = "MkProjectId";
        protected const string MS_ProName = "MkProjectName";
        protected const string MS_ProOwner = "MkProjectOwner";
        protected const string MS_ProTime = "MkProjectTime";
        protected const string MS_RepTime = "MkReportTime";
        protected const string MS_ProMode = "MkProjectMode";
        protected const string MS_ProType = "MkProjectType";
        protected const string MS_ProMaterials = "MkProjectMaterials";
        protected const string MS_ProHotfaceTemperature = "MkProjectHotfaceTemperature";
        protected const string MS_ProColdfaceBoundary = "MkProjectColdfaceBoundary";
        protected const string MS_ProHeatflow = "MkProjectHeatflow";
        protected const string MS_ProLayers = "MkProjectLayers";
        protected const string MS_ProjectRemark = "MkProjectProjectRemark";
        protected const string MS_ProLayersPicture = "MkProjectLayerPicture";
        protected const string MS_ProColdfaceTemperature = "MkProjectColdfaceTemperature";
        protected const string MS_ProColdfaceType = "MkProjectColdfaceType";
        protected const string MS_ProColdfaceHeatflow = "MkProjectColdfaceHeatflow";
        protected const string MS_ProColdfaceAmbientTemperature = "MkProjectColdfaceAmbientTemperature";
        protected const string MS_ProColdfaceFilmCoefficient = "MkProjectFilmCoefficient";
        protected const string MS_ProColdfaceEmissivity = "MkProjectEmissivity";
        protected const string MS_ProTargetLayer = "MkProjectTargetLayer";
        protected const string MS_ProTargetLayerThickness = "MkProjectTargetLayerThickness";
        Object missing = System.Reflection.Missing.Value;
        public WordReporter(Project _pro,string templet,string reppath,string layimgpath):base(_pro)
        {
            TempletFilePath = templet;
            ReportFilePath = reppath;
            LayerPicturePath = layimgpath;
        }
        public override string ReporterName
        {
            get { return "MicrosoftWord文档报告"; }
        }
        public override string RepDocExtName
        {
            get { return ".docx"; }
        }
        public override string ReporterInduction
        {
            get { return @"按照指定模板创建MicrosoftWord报告"; }
        }
        public override int ReporterId
        {
            get { return 1; }
        }
        public override bool Report()
        {
            ApplicationClass app = null;
            Document doc = null;
            try
            {
                app = new ApplicationClass();
                object filename = TempletFilePath;
                doc=app.Documents.Open(ref filename, ref missing, ref missing, ref missing,ref missing, ref missing, ref missing, ref missing);
                doc.Activate();
                WriteBookmarkText(doc, MS_ProId, Pro.Id.ToString());
                WriteBookmarkText(doc, MS_ProName, Pro.Name);
                WriteBookmarkText(doc, MS_ProTime, Pro.LastSolveTime.ToString());
                WriteBookmarkText(doc, MS_ProOwner, Pro.OwnerId.ToString());
                WriteBookmarkText(doc, MS_ProHeatflow, Pro.ColdfaceBoundary.Heatflow.ToString());
                WriteBookmarkText(doc, MS_ProjectRemark, Pro.Remark);
                WriteBookmarkText(doc, MS_ProMode, (Pro.Mode == CalculationMode.Temperature) ? "温度" : "厚度");
                WriteBookmarkText(doc, MS_ProType, (Pro.Schema == GeometrySchema.Plate) ? "平板" : "圆筒");
                WriteBookmarkText(doc, MS_RepTime, DateTime.Now.ToShortDateString());
                WriteBookmarkText(doc, MS_ProHotfaceTemperature, GlobalTool.K2C(Pro.HotfaceTemperature).ToString());
                if(Pro.Mode==CalculationMode.Thickness)
                {
                    WriteBookmarkText(doc, MS_ProTargetLayer, Pro.LayerList[Pro.TargetLayerIndex].Name + "(编号" + Pro.TargetLayerIndex.ToString() + ")");
                    WriteBookmarkText(doc, MS_ProTargetLayerThickness, Pro.LayerList[Pro.TargetLayerIndex].Thickness.ToString());
                }
                if(Pro.ColdfaceBoundary is Class3Boundary)
                {
                    Class3Boundary b = Pro.ColdfaceBoundary as Class3Boundary;
                    WriteBookmarkText(doc, MS_ProColdfaceType, "第三类边界");
                    WriteBookmarkText(doc, MS_ProColdfaceAmbientTemperature, GlobalTool.K2C(b.AmbientTemperature).ToString());
                    WriteBookmarkText(doc, MS_ProColdfaceEmissivity, b.Emissivity.ToString());
                    WriteBookmarkText(doc, MS_ProColdfaceFilmCoefficient, b.FilmCoefficient.ToString());
                }
                else if(Pro.ColdfaceBoundary is Class2Boundary)
                {
                    WriteBookmarkText(doc, MS_ProColdfaceType, "第二类边界");
                }
                else
                {
                    WriteBookmarkText(doc, MS_ProColdfaceType, "第一类边界");
                }
                WriteBookmarkText(doc, MS_ProColdfaceTemperature, Pro.ColdfaceBoundary.Temperature.ToString());
                WriteBookmarkText(doc, MS_ProColdfaceHeatflow, Pro.ColdfaceBoundary.Heatflow.ToString());
                if(LayerPicturePath!=string.Empty&&LayerPicturePath!=null)
                {
                    WriteImage(doc, LayerPicturePath, MS_ProLayersPicture);
                }
                WriteLayersTable(doc, Pro.LayerList, MS_ProLayers);
                object savechanges = app.Options.BackgroundSave;
                object savepath = ReportFilePath;
                doc.SaveAs2(ref savepath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                if (doc != null)
                    doc.Close();
                if (app != null)
                    app.Quit();
            }
        }
        private void WriteImage(Document doc, string picture, string bookmark)
        {
            if (doc.Bookmarks.Exists(bookmark))
            {
                Bookmark bm = doc.Bookmarks[bookmark];
                bm.Range.InlineShapes.AddPicture(picture);
            }
        }
        private void WriteMaterialsTable(Document doc,List<Material> materials, string bookmark)
        {
            if(doc.Bookmarks.Exists(bookmark))
            {
               
            }
        }
        private void WriteLayersTable(Document doc,List<Layer> layers,string bookmark)
        {
            if (doc.Bookmarks.Exists(bookmark))
            {
                Bookmark bm = doc.Bookmarks[bookmark];
                object wdtb = WdDefaultTableBehavior.wdWord9TableBehavior;
                object wfb = WdAutoFitBehavior.wdAutoFitContent;
                Table tb = doc.Tables.Add(bm.Range, layers.Count + 1, 7, ref wdtb, ref wfb);
                Row rt=tb.Rows[1];
                rt.Cells[1].Range.Text = "编号";
                rt.Cells[2].Range.Text = "名称";
                rt.Cells[3].Range.Text = "类型";
                rt.Cells[4].Range.Text = "材质";
                rt.Cells[5].Range.Text = "厚度[mm]";
                rt.Cells[6].Range.Text = "热阻[KW^-1]";
                rt.Cells[7].Range.Text = "温度范围[℃]";
                for (int i=0;i<layers.Count; i++)
                {
                    Layer l = layers[i];
                    Row r = tb.Rows[2 + i];
                    r.Cells[1].Range.Text = i.ToString();
                    r.Cells[2].Range.Text = l.Name;
                    r.Cells[3].Range.Text = (l is ResistanceLayer)?"热阻层":"普通层";
                    if(l is ResistanceLayer)
                    {
                        r.Cells[4].Range.Text = "-";
                        r.Cells[5].Range.Text = "-";
                        r.Cells[6].Range.Text = l.HeatResistance.ToString("F3");
                    }
                    else
                    {
                        r.Cells[4].Range.Text = l.Material.Name+ "(编号" + l.Material.Index.ToString() + ")";
                        r.Cells[5].Range.Text = (l.Thickness*1000.0).ToString("F3");
                        r.Cells[6].Range.Text = l.HeatResistance.ToString("F3");
                    }
                    r.Cells[7].Range.Text = GlobalTool.K2C(l.LowTemperature).ToString("F3") + "-" + GlobalTool.K2C(l.HighTemperature).ToString("F3");
                }
            }
        }
        private void WriteBookmarkText(Document doc, string bookmark,string value)
        {
            if(doc.Bookmarks.Exists(bookmark))
            {
                Bookmark bm = doc.Bookmarks[bookmark];
                bm.Range.Text = value;
            }
        }

    }
}
