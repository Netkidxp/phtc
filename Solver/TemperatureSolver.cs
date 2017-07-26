using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class SolverControlParameter
    {
        public enum ConvergenceCriterionType
        {
            RESIDUAL = 0,
            MAXSTEP = 1,
            RESIDUAL_OR_MAXSTEP=2
        }
        private double residual;
        private int maxStep;
        private ConvergenceCriterionType ccType;
        private int integrateCount;
        public double Residual { get => residual; set => residual = value; }
        public int MaxStep { get => maxStep; set => maxStep = value; }
        public ConvergenceCriterionType CcType { get => ccType; set => ccType = value; }
        public int IntegrateCount { get => integrateCount; set => integrateCount = value; }
        private SolverControlParameter() { }
        public SolverControlParameter(ConvergenceCriterionType _ccType,double _residual,int _maxStep,int _intergrateCount)
        {
            ccType = _ccType;
            residual = _residual;
            maxStep = _maxStep;
            integrateCount = _intergrateCount;
        }
    }
    public delegate void InitalizedTemperatureEndEventHandler(Class1Solver solver);
    public delegate void UpdateTemperatureEndEventHandler(Class1Solver solver);
    public delegate void SolveEndEventHandler(Class1Solver solver);
    public delegate void SolveStartEventHandler(Class1Solver solver);
    public class Class1Solver
    {
        
        protected TemperatureCalculate calculate;
        protected int currentStep;
        protected double currentResidual;

        public int CurrentStep { get => currentStep; }
        public double CurrentResidual { get => currentResidual; }
        public TemperatureCalculate CurrentCalculate
        {
            get => calculate;
        }
     

        public event InitalizedTemperatureEndEventHandler InitalizedTemperatureEndEvent;
        public event UpdateTemperatureEndEventHandler UpdateTemperatureEndEvent;
        public event SolveEndEventHandler SolveEndEvent;
        public event SolveStartEventHandler SolveStartEvent;

        private Class1Solver() { }
        public Class1Solver(TemperatureCalculate _model)
        {
            calculate = _model;
        }
        public virtual void InitalizeTemperature()
        {
            double dt = (calculate.Temperature - calculate.Boundary.Temperature) / calculate.LayerList.Count;
            double ht = calculate.Temperature;
            for (int i = 0; i < calculate.LayerList.Count; i++)
            {
                calculate.LayerList[i].HighTemperature = ht;
                ht = ht - dt;
                calculate.LayerList[i].LowTemperature = ht;
            }
            OnInitlizedTemperatureEnd();
        }
        protected virtual void UpdateTemperature()
        {
            double ht = calculate.Temperature;
            double[] newValue = new double[calculate.LayerList.Count];
            currentResidual = 0;
            for (int i = 0; i < calculate.LayerList.Count; i++)
            {
                ht = ht - calculate.LayerList[i].HeatResistance * calculate.Boundary.Heatflow;
                newValue[i] = ht;
            }
            ht = calculate.Temperature;
            for (int i = 0; i < calculate.LayerList.Count; i++)
            {
                calculate.LayerList[i].HighTemperature = ht;
                ht = newValue[i];
                currentResidual += Math.Abs(calculate.LayerList[i].LowTemperature - newValue[i]);
                calculate.LayerList[i].LowTemperature = ht;
            }
            OnUpdateTemperatureEnd();
            
        }
        public virtual void Solve(SolverControlParameter parameter)
        {
            //InitalizeTemperature();
            OnSolveStart();
            double totalHeatResistance = 0;
            currentStep = 0;
            currentResidual = 100000000000000;
            while(true)
            {
                if (IsConvergenced(parameter))
                    break;
                currentStep++;
                totalHeatResistance = 0;
                foreach (Layer layer in calculate.LayerList)
                {
                    if(!(layer is ResistanceLayer))
                        layer.UpdateHeatResistance(parameter.IntegrateCount);
                    totalHeatResistance += layer.HeatResistance;
                }    
                calculate.Boundary.Heatflow = (calculate.Temperature - calculate.Boundary.Temperature) / totalHeatResistance;
                UpdateTemperature();
                

            }
            OnSolveEnd();
        }
        protected virtual void OnInitlizedTemperatureEnd()
        {
            if (InitalizedTemperatureEndEvent != null)
                InitalizedTemperatureEndEvent(this);
        }
        protected virtual void OnUpdateTemperatureEnd()
        {
            if (UpdateTemperatureEndEvent != null)
                UpdateTemperatureEndEvent(this);
        }
        protected virtual void OnSolveEnd()
        {
            if (SolveEndEvent != null)
                SolveEndEvent(this);
        }
        protected virtual void OnSolveStart()
        {
            if (SolveStartEvent != null)
                SolveStartEvent(this);
        }
        protected bool IsConvergenced(SolverControlParameter parameter)
        {
            if (parameter.CcType == SolverControlParameter.ConvergenceCriterionType.RESIDUAL)
            {
                if (currentResidual < parameter.Residual)
                    return true;
            }
            else if (parameter.CcType == SolverControlParameter.ConvergenceCriterionType.MAXSTEP)
            {
                if (currentStep > parameter.MaxStep)
                    return true;
            }
            else if (parameter.CcType == SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP)
            {
                if (currentResidual < parameter.Residual || currentStep > parameter.MaxStep)
                    return true;
            }
            return false;
        }
    }
    public class Class3Solver:Class1Solver
    {
        public Class3Solver(TemperatureCalculate _model) : base(_model)
        {
        }
        public override void InitalizeTemperature()
        {
            double dt = (calculate.Temperature - ((Class3Boundary)(calculate.Boundary)).AmbientTemperature) / (calculate.LayerList.Count+1);
            double ht = calculate.Temperature;
            for (int i = 0; i < calculate.LayerList.Count; i++)
            {
                calculate.LayerList[i].HighTemperature = ht;
                ht = ht - dt;
                calculate.LayerList[i].LowTemperature = ht;
            }
            calculate.Boundary.Temperature = ht;
            OnInitlizedTemperatureEnd();
        }
        protected override void UpdateTemperature()
        {
            base.UpdateTemperature();
            calculate.Boundary.Temperature = calculate.LayerList[calculate.LayerList.Count - 1].LowTemperature;
            
        }
        public override void Solve(SolverControlParameter parameter)
        {
            //InitalizeTemperature();
            OnSolveStart();
            Class3Boundary boundary = (Class3Boundary)calculate.Boundary;
            double totalHeatResistance = 0;
            currentStep = 0;
            currentResidual = 100000000000000;
            while (true)
            {
               
                if (IsConvergenced(parameter))
                    break;
                currentStep++;
                boundary.Area = TemperatureCalculate.OutsideArea(CurrentCalculate.LayerList);
                totalHeatResistance = boundary.CombinedHeatResistance;
                foreach (Layer layer in calculate.LayerList)
                {
                    if (!(layer is ResistanceLayer))
                        layer.UpdateHeatResistance(parameter.IntegrateCount);
                    totalHeatResistance += layer.HeatResistance;
                }
                boundary.Heatflow = (calculate.Temperature - boundary.AmbientTemperature) / totalHeatResistance;
                UpdateTemperature();
                
            }
            OnSolveEnd();
        }
    }
    public class Class2Solver:Class1Solver
    {
        public Class2Solver(TemperatureCalculate _model):base(_model)
        {
        }
        public override void InitalizeTemperature()
        {
            calculate.Boundary.Temperature = calculate.Temperature;
            base.InitalizeTemperature();
        }
        protected override void UpdateTemperature()
        {
            base.UpdateTemperature();
            calculate.Boundary.Temperature = calculate.LayerList[calculate.LayerList.Count - 1].LowTemperature;
            
        }
        public override void Solve(SolverControlParameter parameter)
        {
            //InitalizeTemperature();
            OnSolveStart();
            currentStep = 0;
            currentResidual = 100000000000000;
            while (true)
            {
                if (IsConvergenced(parameter))
                    break;
                currentStep++;
               
                foreach (Layer layer in calculate.LayerList)
                {
                    if (!(layer is ResistanceLayer))
                        layer.UpdateHeatResistance(parameter.IntegrateCount);
                   
                }
                UpdateTemperature();
                

            }
            base.OnSolveEnd();
        }
    }
    public static class SolverFactory
    {
        public static Class1Solver CreateSolver(TemperatureCalculate calculate)
        {
            if (calculate.Boundary is Class3Boundary)
                return new Class3Solver(calculate);
            else if (calculate.Boundary is Class2Boundary)
                return new Class2Solver(calculate);
            else
                return new Class1Solver(calculate);
        }
    }
    
}
