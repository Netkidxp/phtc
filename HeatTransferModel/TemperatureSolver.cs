using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    
    public delegate void InitalizedTemperatureEndEventHandler(TemperatureSolverC1 solver);
    public delegate void UpdateTemperatureEndEventHandler(TemperatureSolverC1 solver);
    public delegate void SolveEndEventHandler(TemperatureSolverC1 solver);
    public delegate void SolveStartEventHandler(TemperatureSolverC1 solver);

    public class TemperatureSolverC1
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

        private TemperatureSolverC1() { }
        public TemperatureSolverC1(TemperatureCalculate _model)
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
    public class TemperatureSolverC3:TemperatureSolverC1
    {
        public TemperatureSolverC3(TemperatureCalculate _model) : base(_model)
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
                //boundary.Area = TemperatureCalculate.OutsideArea(CurrentCalculate.LayerList);
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
    public class TemperatureSolverC2:TemperatureSolverC1
    {
        public TemperatureSolverC2(TemperatureCalculate _model):base(_model)
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
    public static class TemperatureSolverFactory
    {
        public static TemperatureSolverC1 CreateSolver(TemperatureCalculate calculate)
        {
            if (calculate.Boundary is Class3Boundary)
                return new TemperatureSolverC3(calculate);
            else if (calculate.Boundary is Class2Boundary)
                return new TemperatureSolverC2(calculate);
            else
                return new TemperatureSolverC1(calculate);
        }
    }
    
}
