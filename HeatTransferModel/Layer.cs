using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class Layer
    {
        private string name;
        protected double heatResistance;
        protected double thickness;
        protected double lowTemperature, highTemperature;
        protected Material material;
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

        private Layer() { } 
        protected Layer(double heat_resistance,double low_t,double high_t)
        {
            heatResistance = heat_resistance;
            lowTemperature = low_t;
            highTemperature = high_t;
            thickness = 0;
        }
        public Layer(Material mat,double thi)
        {
            material = mat;
            thickness = thi;
        }
        public virtual void UpdateHeatResistance(int stepCount)
        {
            if(stepCount<=0)
            {
                double midTemperature = (LowTemperature + HighTemperature) / 2.0;
                double midTC = material.lookupThermalConductivity(midTemperature);
                heatResistance = thickness / midTC;
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
                    double midThermConductivity = material.lookupThermalConductivity(midTemperature);
                    heatResistance += stepThickness / midThermConductivity;
                    startTemperature = endTemperature;
                }
            }
        }
    }
    public class ResistanceLayer:Layer
    {
        public ResistanceLayer(double heat_resistance, double low_t, double high_t):base(heat_resistance,low_t,high_t)
        {

        }
        public override double HeatResistance
        {
            get => base.HeatResistance;
            set => heatResistance = value;
        }
        public override void UpdateHeatResistance(int stepCount){}
    }
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
        public TubbinessLayer(Material mat, double thi, double r1) : base(mat, thi)
        {
            insideRadius = r1;
        }
        public override void UpdateHeatResistance(int stepCount)
        {
            if (stepCount <= 0)
            {
                double midTemperature = (LowTemperature + HighTemperature) / 2.0;
                double midTC = material.lookupThermalConductivity(midTemperature);
                heatResistance = Math.Log(OutsideRadius / InsideRadius) / (2.0 * Math.PI * midTC);
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
                    double midThermConductivity = material.lookupThermalConductivity(midTemperature);
                    double endRadius = startRadius + stepThickness;
                    heatResistance += Math.Log(endRadius / startRadius) / (2.0 * Math.PI * midThermConductivity);
                    startTemperature = endTemperature;
                    startRadius = endRadius;
                }
            }
        }
    }
}
