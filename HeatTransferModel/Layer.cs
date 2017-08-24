using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    [Serializable]
    public class Layer
    {
        private string name;
        protected double heatResistance;
        protected double thickness;
        protected double lowTemperature, highTemperature;
        private Material material;
        private double width;
        private double height;
        public double LowTemperature
        {
            get { return lowTemperature; }
            set
            {
                lowTemperature = value;
            }
        }
        public double HighTemperature
        {
            get { return highTemperature; }
            set
            {
                highTemperature = value;
            }
        }
        public virtual double Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
            }
        }
        public virtual double HeatResistance
        {
            get
            {
                return heatResistance;
            }
            set
            {

            }
        }

        public string Name { get => name; set => name = value; }
        public Material Material { get => material; set => material = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        private Layer() { } 
        protected Layer(double heat_resistance)
        {
            heatResistance = heat_resistance;
            thickness = 0;
        }
        public Layer(Material _mat, double _thi)
        {
            Material = _mat;
            thickness = _thi;
            Width = 1;
            Height = 1;
        }
        public Layer(Material _mat,double _thi,double _width,double _height)
        {
            Material = _mat;
            thickness = _thi;
            Width = _width;
            Height = _height;

        }
        public virtual void UpdateHeatResistance(int stepCount)
        {
            if(stepCount<=0)
            {
                double midTemperature = (LowTemperature + HighTemperature) / 2.0;
                double midTC = Material.lookupThermalConductivity(midTemperature);
                heatResistance = thickness / midTC/(Width*Height);
            }
            else
            {
                heatResistance = 0;
                double startTemperature = HighTemperature;
                double stepTemperature = (HighTemperature - LowTemperature) / stepCount;
                double stepThickness = Thickness / stepCount;
                for (int step = 0; step < stepCount; step++)
                {
                    double endTemperature = startTemperature - stepTemperature;
                    double midTemperature = (startTemperature + endTemperature) / 2;
                    double midThermConductivity = Material.lookupThermalConductivity(midTemperature);
                    heatResistance += stepThickness / midThermConductivity/(Width*Height);
                    startTemperature = endTemperature;
                }
            }
        }
    }
    [Serializable]
    public class ResistanceLayer:Layer
    {
        public ResistanceLayer(double heat_resistance):base(heat_resistance)
        {

        }
        public override double HeatResistance
        {
            get => base.HeatResistance;
            set => heatResistance = value;
        }
        public override void UpdateHeatResistance(int stepCount){}
    }
    [Serializable]
    public class TubbinessLayer : Layer
    {
        double insideRadius;
        public double InsideRadius
        {
            get { return insideRadius; }
            set
            {
                insideRadius = value;
            }
        }
        public double OutsideRadius
        {
            get { return InsideRadius + Thickness; }
        }
        public TubbinessLayer(Material _mat, double _thi):base(_mat, _thi)
        {

        }
        public TubbinessLayer(Material _mat, double _thi,double _insideRadius,double _height) : base(_mat, _thi,1.0,_height)
        {
            insideRadius = _insideRadius;
        }
        public override void UpdateHeatResistance(int stepCount)
        {
            if (stepCount <= 0)
            {
                double midTemperature = (LowTemperature + HighTemperature) / 2.0;
                double midTC = Material.lookupThermalConductivity(midTemperature);
                heatResistance = Math.Log(OutsideRadius / InsideRadius) / (2.0 * Math.PI * midTC*Height);
            }
            else
            {
                heatResistance = 0;
                double startTemperature = HighTemperature;
                double startRadius = InsideRadius;
                double stepTemperature = (HighTemperature - LowTemperature) / stepCount;
                double stepThickness = Thickness / stepCount;
                for (int step = 0; step < stepCount; step++)
                {
                    double endTemperature = startTemperature - stepTemperature;
                    double midTemperature = (startTemperature + endTemperature) / 2;
                    double midThermConductivity = Material.lookupThermalConductivity(midTemperature);
                    double endRadius = startRadius + stepThickness;
                    heatResistance += Math.Log(endRadius / startRadius) / (2.0 * Math.PI * midThermConductivity*Height);
                    startTemperature = endTemperature;
                    startRadius = endRadius;
                }
            }
        }
    }
}
