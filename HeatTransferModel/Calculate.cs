using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    [Serializable]
    public class TemperatureCalculate
    {
        double temperature;
        Class1Boundary boundary;
        List<Layer> layerList;
        double hotfaceRadius;
        double height;
        double width;
        private TemperatureCalculate() { }
        public TemperatureCalculate(double _hotfaceTemperature, Class1Boundary _codefaceBoundary, List<Layer> _layers)
        {
            temperature = _hotfaceTemperature;
            boundary = _codefaceBoundary;
            layerList = _layers;
            hotfaceRadius = 1.0;
            width = 1.0;
            height = 1.0;
            SetLayersSize();
            SetBoudaryArea();
        }
        public TemperatureCalculate(double _hotfaceTemperature,double _hotfaceRadius,double _width,double _height, Class1Boundary _codefaceBoundary, List<Layer> _layers)
        {
            temperature = _hotfaceTemperature;
            boundary = _codefaceBoundary;
            layerList = _layers;
            hotfaceRadius = _hotfaceRadius;
            width = _width;
            height = _height;
            SetLayersSize();
            SetBoudaryArea();
        }
        public void SetLayersSize()
        {
            double max = hotfaceRadius;
            foreach (Layer l in LayerList)
            {
                l.Width = Width;
                l.Height = Height;
                if (l is TubbinessLayer)
                {
                    TubbinessLayer tl = (TubbinessLayer)l;
                    tl.InsideRadius = max;
                    max = tl.OutsideRadius;
                }
            }
        }
        public void SetBoudaryArea()
        {
            Boundary.Area = OutsideArea(LayerList);
        }
        private bool isTubbinLayerList()
        {
            int i = 0;
            for (; i < LayerList.Count; i++)
            {
                if (LayerList[i] is TubbinessLayer)
                    break;
            }
            if (i == LayerList.Count)
                return false;
            else
                return true;
        }
        public double Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
            }
        }
        public Class1Boundary Boundary
        {
            get { return boundary; }
            set
            {
                boundary = value;
                SetBoudaryArea();
            }

        }
        public List<Layer> LayerList
        {
            get { return layerList; }
            set
            {
                layerList = value;
                SetLayersSize();
                SetBoudaryArea();
            }
        }

        public double HotfaceRadius
        {
            get => hotfaceRadius;
            set
            {
                hotfaceRadius = value;
                SetLayersSize();
                SetBoudaryArea();
            }
        }
        public double Height
        {
            get => height;
            set
            {
                height = value;
                SetLayersSize();
                SetBoudaryArea();
            }
        }
        public double Width
        {
            get => width;
            set
            {
                width = value;
                SetLayersSize();
                SetBoudaryArea();
            }
        }

        public static double OutsideArea(List<Layer> lays)
        {
            int i = 0;
            for (; i < lays.Count; i++)
            {
                if (lays[i] is TubbinessLayer)
                    break;
            }
            if (i == lays.Count)
                return 1.0;
            else
            {
                double thi = 0.0;
                foreach (Layer lay in lays)
                {
                    thi += lay.Thickness;
                }
                TubbinessLayer tlay = (TubbinessLayer)lays[i];
                return 2.0 * Math.PI * (tlay.InsideRadius + thi);
            }

        }
        public int GeomLayerCount
        {
            get
            {
                int c = 0;
                foreach(Layer l in LayerList)
                {
                    if (!(l is ResistanceLayer))
                        c += 1;
                }
                return c;
            }
        }
        public int FlowDirection
        {
            get
            {
                if(Boundary is Class3Boundary)
                {
                    Class3Boundary b = Boundary as Class3Boundary;
                    if (Temperature > b.AmbientTemperature)
                        return 1;
                    else if (Temperature == b.AmbientTemperature)
                        return 0;
                    else
                        return -1;
                }
                else if(Boundary is Class2Boundary)
                {
                    Class2Boundary b = Boundary as Class2Boundary;
                    if (b.Heatflow > 0)
                        return 1;
                    else if (b.Heatflow == 0)
                        return 0;
                    else
                        return -1;
                }
                else
                {
                    if (Temperature > Boundary.Temperature)
                        return 1;
                    else if (Temperature == Boundary.Temperature)
                        return 0;
                    else
                        return -1;
                }
            }
        }
        public string CheckInput()
        {
            string res = string.Empty;
            if (FlowDirection <= 0)
                res += "Temperature Calculate:热流方向为负/r/n";
            if(GeomLayerCount==0)
                res += "Temperature Calculate:实体层为0/r/n";
            return res;
        }
        public TemperatureCalculate Clone()
        {
            object obj = null;
            //将对象序列化成内存中的二进制流  
            BinaryFormatter inputFormatter = new BinaryFormatter();
            MemoryStream inputStream;
            using (inputStream = new MemoryStream())
            {
                inputFormatter.Serialize(inputStream, this);
            }
            //将二进制流反序列化为对象  
            using (MemoryStream outputStream = new MemoryStream(inputStream.ToArray()))
            {
                BinaryFormatter outputFormatter = new BinaryFormatter();
                obj = outputFormatter.Deserialize(outputStream);
            }
            return (TemperatureCalculate)obj;
        }
    }

    public class ThicknessCalculate
    {
        int targetLayerIndex;
        TemperatureCalculate calculate;
        double targetValue;
        SolverControlParameter temperatureSolveParameter;
        SolverControlParameter thicknessSolveParameter;
        public ThicknessCalculate(TemperatureCalculate _calculate, int _targetLayerIndex, double _targetValue, SolverControlParameter _temperatureSolveParameter, SolverControlParameter _thicknessSolveParameter)
        {
            Calculate = _calculate;
            TargetLayerIndex = _targetLayerIndex;
            TargetValue = _targetValue;
            TemperatureSolveParameter = _temperatureSolveParameter;
            ThicknessSolveParameter = _thicknessSolveParameter;
        }
        public int TargetLayerIndex { get => targetLayerIndex; set => targetLayerIndex = value; }
        public TemperatureCalculate Calculate { get => calculate; set => calculate = value; }
        public double TargetValue { get => targetValue; set => targetValue = value; }
        public SolverControlParameter TemperatureSolveParameter { get => temperatureSolveParameter; set => temperatureSolveParameter = value; }
        public SolverControlParameter ThicknessSolveParameter { get => thicknessSolveParameter; set => thicknessSolveParameter = value; }
        public double CalculateMaxTargetValue()
        {
            TemperatureCalculate tc = Calculate.Clone();
            tc.LayerList[TargetLayerIndex].Thickness = 0;
            TemperatureSolverC1 solver = TemperatureSolverFactory.CreateSolver(tc);
            solver.InitalizeTemperature();
            solver.Solve(TemperatureSolveParameter);
            if (tc.Boundary is Class2Boundary || tc.Boundary is Class3Boundary)
                return tc.Boundary.Temperature;
            else
                return tc.Boundary.Heatflow;
        }
    }
}

