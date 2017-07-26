using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    
    public class TemperatureCalculate
    {
        double temperature;
        Class1Boundary boundary;
        List<Layer> layerList;

        private TemperatureCalculate() { }
        public TemperatureCalculate(double _hotfaceTemperature, Class1Boundary _codefaceBoundary, List<Layer> _layers)
        {
            temperature = _hotfaceTemperature;
            boundary = _codefaceBoundary;
            layerList = _layers; 
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
            set { boundary = value; }

        }
        public List<Layer> LayerList
        {
            get { return layerList; }
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
    }
}

