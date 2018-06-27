using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using System.IO;
using Aspose.Words;
using System.Drawing;
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
        protected const string MS_ProLayersPictureEnglish = "MkProjectLayerPicture(English)";
        protected const string MS_ProColdfaceTemperature = "MkProjectColdfaceTemperature";
        protected const string MS_ProColdfaceType = "MkProjectColdfaceType";
        protected const string MS_ProColdfaceHeatflow = "MkProjectColdfaceHeatflow";
        protected const string MS_ProColdfaceAmbientTemperature = "MkProjectColdfaceAmbientTemperature";
        protected const string MS_ProColdfaceFilmCoefficient = "MkProjectFilmCoefficient";
        protected const string MS_ProColdfaceEmissivity = "MkProjectEmissivity";
        protected const string MS_ProTargetLayer = "MkProjectTargetLayer";
        protected const string MS_ProTargetLayerThickness = "MkProjectTargetLayerThickness";
        protected const string MS_Englist = "MkEnglish";
        private bool English;
        public WordReporter(Project _pro,string templet,string reppath,string[] layimgpath):base(_pro)
        {
            TempletFilePath = templet;
            ReportFilePath = reppath;
            LayerPicturePath = layimgpath;
            English = false;
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
            Document doc = null;
            try
            {
                doc = new Document(TempletFilePath);
                if (doc == null)
                    return false;
                DocumentBuilder db = new DocumentBuilder(doc);
                English = db.MoveToBookmark(MS_Englist);
                WriteBookmarkText(doc, MS_ProId, Pro.Id.ToString());
                WriteBookmarkText(doc, MS_ProName, Pro.Name);
                WriteBookmarkText(doc, MS_ProTime, Pro.LastSolveTime.ToString());
                WriteBookmarkText(doc, MS_ProOwner, Pro.OwnerId.ToString());
                WriteBookmarkText(doc, MS_ProHeatflow, Pro.ColdfaceBoundary.Heatflow.ToString());
                WriteBookmarkText(doc, MS_ProjectRemark, Pro.Remark);
                if(English)
                {
                    WriteBookmarkText(doc, MS_ProMode, (Pro.Mode == CalculationMode.Temperature) ? "Temperature" : "Thickness");
                    WriteBookmarkText(doc, MS_ProType, (Pro.Schema == GeometrySchema.Plate) ? "Plane" : "Ring");
                }
                else
                {
                    WriteBookmarkText(doc, MS_ProMode, (Pro.Mode == CalculationMode.Temperature) ? "温度" : "厚度");
                    WriteBookmarkText(doc, MS_ProType, (Pro.Schema == GeometrySchema.Plate) ? "平板" : "圆筒");
                }
                
                WriteBookmarkText(doc, MS_RepTime, DateTime.Now.ToShortDateString());
                WriteBookmarkText(doc, MS_ProHotfaceTemperature, GlobalTool.K2C(Pro.HotfaceTemperature).ToString("F1"));
                if(Pro.Mode==CalculationMode.Thickness)
                {
                    if (English)
                        WriteBookmarkText(doc, MS_ProTargetLayer, Pro.LayerList[Pro.TargetLayerIndex].Name + "(ID" + Pro.TargetLayerIndex.ToString() + ")");
                    else
                        WriteBookmarkText(doc, MS_ProTargetLayer, Pro.LayerList[Pro.TargetLayerIndex].Name + "(编号" + Pro.TargetLayerIndex.ToString() + ")");
                    WriteBookmarkText(doc, MS_ProTargetLayerThickness, Pro.LayerList[Pro.TargetLayerIndex].Thickness.ToString());
                }
                if(Pro.ColdfaceBoundary is Class3Boundary)
                {
                    Class3Boundary b = Pro.ColdfaceBoundary as Class3Boundary;
                    if (English)
                        WriteBookmarkText(doc, MS_ProColdfaceType, "Class3 Boundary");
                    else
                        WriteBookmarkText(doc, MS_ProColdfaceType, "第三类边界");
                    WriteBookmarkText(doc, MS_ProColdfaceAmbientTemperature, GlobalTool.K2C(b.AmbientTemperature).ToString("F3"));
                    WriteBookmarkText(doc, MS_ProColdfaceEmissivity, b.Emissivity.ToString());
                    WriteBookmarkText(doc, MS_ProColdfaceFilmCoefficient, b.FilmCoefficient.ToString());
                }
                else if(Pro.ColdfaceBoundary is Class2Boundary)
                {
                    if (English)
                        WriteBookmarkText(doc, MS_ProColdfaceType, "Class2 Boundary");
                    else
                        WriteBookmarkText(doc, MS_ProColdfaceType, "第二类边界");
                }
                else
                {
                    if (English)
                        WriteBookmarkText(doc, MS_ProColdfaceType, "Class1 Boundary");
                    else
                        WriteBookmarkText(doc, MS_ProColdfaceType, "第一类边界");
                }
                WriteBookmarkText(doc, MS_ProColdfaceTemperature, GlobalTool.K2C(Pro.ColdfaceBoundary.Temperature).ToString("F3"));
                WriteBookmarkText(doc, MS_ProColdfaceHeatflow, Pro.ColdfaceBoundary.Heatflow.ToString());
                string img= null;
                if (LayerPicturePath.Length == 0)
                    img = null;
                if (LayerPicturePath.Length == 1)
                    img = LayerPicturePath[0];
                else
                    img = LayerPicturePath[English ? 0 : 1];
                WriteImage(doc, img, MS_ProLayersPicture);
                WriteLayersTable(doc, Pro.LayerList, MS_ProLayers);
                doc.Save(ReportFilePath, SaveFormat.Docx);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        private void WriteImage(Document doc, string picture, string bookmark)
        {
            DocumentBuilder db = new DocumentBuilder(doc);
            Bitmap bmp = new Bitmap(picture);
            Size size = bmp.Size;
            PageSetup ps = doc.Sections[0].PageSetup;
            double width = ps.PageWidth - ps.LeftMargin - ps.RightMargin;
            double height = size.Height * width / size.Width;
            bmp.Dispose();
            if(db.MoveToBookmark(bookmark))
            {
                db.InsertImage(picture,width,height);
            }
            
        }
        private void WriteMaterialsTable(Document doc,List<Material> materials, string bookmark)
        {
            
        }
        private void WriteLayersTable(Document doc,List<Layer> layers,string bookmark)
        {
            DocumentBuilder db = new DocumentBuilder(doc);
            if (db.MoveToBookmark(bookmark))
            {
                
                if(English)
                {
                    db.StartTable();
                    db.InsertCell();
                    db.Write("ID");
                    db.InsertCell();
                    db.Write("Name");
                    db.InsertCell();
                    db.Write("Type");
                    db.InsertCell();
                    db.Write("Material");
                    db.InsertCell();
                    db.Write("Thickness[mm]");
                    db.InsertCell();
                    db.Write("Heat Resistance[KW^-1]");
                    db.InsertCell();
                    db.Write("Temperature Range[℃]");
                    db.EndRow();
                }
                else
                {
                    db.StartTable();
                    db.InsertCell();
                    db.Write("编号");
                    db.InsertCell();
                    db.Write("名称");
                    db.InsertCell();
                    db.Write("类型");
                    db.InsertCell();
                    db.Write("材质");
                    db.InsertCell();
                    db.Write("厚度[mm]");
                    db.InsertCell();
                    db.Write("热阻[KW^-1]");
                    db.InsertCell();
                    db.Write("温度范围[℃]");
                    db.EndRow();
                }

                for (int i = 0; i < layers.Count; i++)
                {
                    Layer l = layers[i];
                    db.InsertCell();
                    db.Write(i.ToString());
                    db.InsertCell();
                    db.Write(l.Name);
                    db.InsertCell();
                    if (English)
                        db.Write((l is ResistanceLayer) ? "HeatResistanceLayer" : "GeometryLayer");
                    else
                        db.Write((l is ResistanceLayer) ? "热阻层" : "普通层");

                    if (l is ResistanceLayer)
                    {
                        db.InsertCell();
                        db.Write("-");
                        db.InsertCell();
                        db.Write("-");
                        db.InsertCell();
                        db.Write(l.HeatResistance.ToString("F3"));
                    }
                    else
                    {
                        db.InsertCell();
                        db.Write(l.Material.Name);
                        db.InsertCell();
                        db.Write((l.Thickness * 1000.0).ToString("F0"));
                        db.InsertCell();
                        db.Write(l.HeatResistance.ToString("F3"));
                    }
                    db.InsertCell();
                    db.Write(GlobalTool.K2C(l.LowTemperature).ToString("F3") + "-" + GlobalTool.K2C(l.HighTemperature).ToString("F3"));
                    db.EndRow();
                }

                db.EndTable();
            }  
        }
        private void WriteBookmarkText(Document doc, string bookmark,string value)
        {
            DocumentBuilder db = new DocumentBuilder(doc);
            if (db.MoveToBookmark(bookmark))
            {
                db.Write(value);
            }
        }

    }
}
