using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class Class1Boundary
    {
        private double temperature;
        private double heatflow;
        public virtual double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
       
        public virtual double Heatflow
        {
            get => heatflow;
            set => heatflow = value;
        }

        public Class1Boundary(double _temperature)
        {
            temperature = _temperature;
        }
    }
    public class Class2Boundary:Class1Boundary
    {
        public Class2Boundary(double _heatflow):base(0.0)
        {
            Heatflow = _heatflow;
        }
    }
    public class Class3Boundary:Class1Boundary
    {
        private double filmCoefficient;
        private double ambientTemperature;
        private double emissivity;
        private double area;
        private double convectiveHeatflow;
        private double radiantHeatflow;
        public static double STEFAN_BOLTZMANN = 5.67e-8;
        public static double ZERO_CELSIUS_TO_KELVIEN = 273.15;
        public double FilmCoefficient
        {
            get { return filmCoefficient; }
            set
            {
                filmCoefficient = value;
            }
        }
        public double AmbientTemperature
        {
            get { return ambientTemperature; }
            set
            {
                ambientTemperature = value;
            }
        }
        public double Area { get => area; set => area = value; }
        public double Emissivity { get => emissivity; set => emissivity = value; }
        public double ConvectiveHeatflow
        {
            get
            {
                convectiveHeatflow=NewtonLaw(Temperature, AmbientTemperature, Area, FilmCoefficient);
                return convectiveHeatflow;
            }
            set => convectiveHeatflow = value;
        }
        public double RadiantHeatflow
        {
            get
            {
                radiantHeatflow = StefanBoltzmannLaw(Temperature, AmbientTemperature, Area, Emissivity);
                return radiantHeatflow;
            }
            set => radiantHeatflow = value;
        }
        public double CombinedHeatResistance
        {
            get { return (Temperature - AmbientTemperature) / (ConvectiveHeatflow + RadiantHeatflow); }
        }
        public Class3Boundary(double _fileCoefficient,double _emissivity,double _ambientTemperature,double _area):base(0.0)
        {
            filmCoefficient = _fileCoefficient;
            ambientTemperature = _ambientTemperature;
            area = _area;
            emissivity = _emissivity;
        }
        public static double StefanBoltzmannLaw(double _t1,double _t2,double _area,double _emissivity)
        {
            return _emissivity * _area * STEFAN_BOLTZMANN * (Math.Pow(_t1,4.0)-Math.Pow(_t2, 4.0));
        }
        public static double NewtonLaw(double _t1, double _t2, double _area, double _cht)
        {
            return _cht * _area * (_t1 - _t2);
        }
    }
}
