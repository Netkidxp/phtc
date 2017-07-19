using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using PHTC.Model;


namespace PHTC
{
    enum CalculationMode
    {
        Temperature,
        Thickness
    }
    enum GeometrySchema
    {
        Plate,
        Tubbiness
    }
    class ProjectProperty
    {
        
        string              name;
        CalculationMode     mode;
        GeometrySchema      schema;
        public static  ProjectProperty Default()
        {
            ProjectProperty p = new ProjectProperty();
            p.Name = "新建计算";
            p.Mode = CalculationMode.Temperature;
            p.Schema = GeometrySchema.Plate;
            
            return p;
        }
        [CategoryAttribute("文档属性")]
        [DisplayName("工程名称")]
        public string Name { get => name; set => name = value; }

        [CategoryAttribute("模式详情")]
        [DisplayName("计算模式")]
        public CalculationMode Mode { get => mode; set => mode = value; }

        [CategoryAttribute("模式详情")]
        [DisplayName("几何类型")]
        public GeometrySchema Schema { get => schema; set => schema = value; }
        
    }
    class MaterialProperty
    {
        string name;
        //System.Windows.Forms.Design.Collect
        //System.ComponentModel.Design.

    }
    class CalculationModelProperty
    {

    }
    class LayerCollectionProperty
    {
        List<Layer> layers;
        public static LayerCollectionProperty Default()
        {
            LayerCollectionProperty l = new LayerCollectionProperty();
            l.layers = new List<Layer>();
            return l;
        }
        [DisplayName("层集合"), ReadOnlyAttribute(true)]
        public List<Layer> Layers { get => layers;  }
    }
}
