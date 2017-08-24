using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PHTC.Model
{
    [Serializable]
    public enum CalculationMode
    {
        Temperature,
        Thickness
    }
    [Serializable]
    public enum GeometrySchema
    {
        Plate,
        Tubbiness
    }

    [Serializable]
    public class Project
    {
        int                     id;
        string                  name;
        int                     ownerId;
        List<Material>          materialList;
        CalculationMode         mode;
        GeometrySchema          schema;
        double                  hotfaceTemperature;
        List<Layer>             layerList;
        Class1Boundary          coldfaceBoundary;
        SolverControlParameter  thicknessSolverControlParameter;
        SolverControlParameter  temperatureSolverControlParameter;
        int                     layerDifferentialCount;
        int                     targetLayerIndex;
        double                  targetValue;
        double sizeRorW;
        double sizeLorH;
        string remark;
        bool share;
        public static  Project Default()
        {
            Project p = new Project();
            p.Id = 0;
            p.Name = "新建计算";
            p.Mode = CalculationMode.Temperature;
            p.Schema = GeometrySchema.Plate;
            p.HotfaceTemperature = 1600.0+273.15;
            p.ColdfaceBoundary = new Class1Boundary(373.15);
            p.SizeLorH = 1.0;
            p.SizeRorW = 1.0;  
            p.TemperatureSolverControlParameter = SolverControlParameter.Default;
            p.Remark = "新建计算";
            p.Share = true;
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
        public SolverControlParameter ThicknessSolverControlParameter { get => thicknessSolverControlParameter; set => thicknessSolverControlParameter = value; }
        public SolverControlParameter TemperatureSolverControlParameter { get => temperatureSolverControlParameter; set => temperatureSolverControlParameter = value; }
        public int LayerDifferentialCount { get => layerDifferentialCount; set => layerDifferentialCount = value; }
        public int TargetLayerIndex { get => targetLayerIndex; set => targetLayerIndex = value; }
        public double TargetValue { get => targetValue; set => targetValue = value; }
        public double SizeRorW { get => sizeRorW; set => sizeRorW = value; }
        public double SizeLorH { get => sizeLorH; set => sizeLorH = value; }
        public int Id { get => id; set => id = value; }
        public int OwnerId { get => ownerId; set => ownerId = value; }
        public string Remark { get => remark; set => remark = value; }
        public bool Share { get => share; set => share = value; }
        public TemperatureCalculate TemperatureCalculate
        {
            get
            {
                return new TemperatureCalculate(HotfaceTemperature, SizeRorW, SizeRorW, SizeLorH, ColdfaceBoundary, LayerList);
            }
        }
        public ThicknessCalculate ThicknessCalculate
        {
            get
            {
                return new ThicknessCalculate(TemperatureCalculate, TargetLayerIndex,TargetValue, TemperatureSolverControlParameter, ThicknessSolverControlParameter);
            }
        }
        public string CheckProjectInput()
        {
            string res = string.Empty;
            res += TemperatureCalculate.CheckInput();
            if (TargetValue > ThicknessCalculate.CalculateMaxTargetValue())
                res += "ThicknessCalculate:目标参数超出范围，会使目标层厚度计算结果为负";
            return res;
        }
        public byte[] Serialize()
        {
            Stream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, this);
            byte[] data = new byte[stream.Length];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(data, 0, (int)stream.Length);
            stream.Close();
            return data;
        }
        public static Project Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            object o=bf.Deserialize(stream);
            return (Project)o;
        }
    }

}
