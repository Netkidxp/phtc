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
    public enum CalculationMode
    {
        Temperature,
        Thickness
    }
    public enum GeometrySchema
    {
        Plate,
        Tubbiness
    }
    public class Project
    {
        
        string                  name;
        List<Material>          materialList;
        CalculationMode         mode;
        GeometrySchema          schema;
        double                  hotfaceTemperature;
        List<Layer>             layerList;
        Class1Boundary          coldfaceBoundary;
        SolverControlParameter  subSolverControlParameter;
        SolverControlParameter  mainSolverControlParameter;
        int                     layerDifferentialCount;
        int                     targetLayerIndex;
        
        public static  Project Default()
        {
            Project p = new Project();
            p.Name = "新建计算";
            p.Mode = CalculationMode.Temperature;
            p.Schema = GeometrySchema.Plate;
            return p;
        }
        public Project()
        {
            materialList = new List<Material>();
            layerList = new List<Layer>();
        }
        public string Name { get => name; set => name = value; }
        public CalculationMode Mode { get => mode; set => mode = value; }
        public GeometrySchema Schema { get => schema; set => schema = value; }
        public List<Material> MaterialList { get => materialList; set => materialList = value; }
        public double HotfaceTemperature { get => hotfaceTemperature; set => hotfaceTemperature = value; }
        public List<Layer> LayerList { get => layerList; set => layerList = value; }
        public Class1Boundary ColdfaceBoundary { get => coldfaceBoundary; set => coldfaceBoundary = value; }
        public SolverControlParameter SubSolverControlParameter { get => subSolverControlParameter; set => subSolverControlParameter = value; }
        public SolverControlParameter MainSolverControlParameter { get => mainSolverControlParameter; set => mainSolverControlParameter = value; }
        public int LayerDifferentialCount { get => layerDifferentialCount; set => layerDifferentialCount = value; }
        public int TargetLayerIndex { get => targetLayerIndex; set => targetLayerIndex = value; }
}
    }

}
