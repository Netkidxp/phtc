using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model

{
    public delegate void ThicknessSolverStartEventHandler(ThicknessSolver solver);
    public delegate void ThicknessSolverUpdateEventHandler(ThicknessSolver solver);
    public delegate void ThicknessSolverStopEventHandler(ThicknessSolver solver);

    public class ThicknessCalculate
    {
        int layerIndex;
        Calculate calculate;
        double targetValue;
        SolverControlParameter temperatureSolveParameter;
        SolverControlParameter thicknessSolveParameter;
        public ThicknessCalculate(Calculate _calculate,int _layerIndex,double _targetValue,SolverControlParameter _temperatureSolveParameter,SolverControlParameter _thicknessSolveParameter)
        {
            Calculate = _calculate;
            LayerIndex = _layerIndex;
            TargetValue = _targetValue;
            TemperatureSolveParameter = _temperatureSolveParameter;
            ThicknessSolveParameter = _thicknessSolveParameter;
        }

        public int LayerIndex { get => layerIndex; set => layerIndex = value; }
        public Calculate Calculate { get => calculate; set => calculate = value; }
        public double TargetValue { get => targetValue; set => targetValue = value; }
        public SolverControlParameter TemperatureSolveParameter { get => temperatureSolveParameter; set => temperatureSolveParameter = value; }
        public SolverControlParameter ThicknessSolveParameter { get => thicknessSolveParameter; set => thicknessSolveParameter = value; }
    }

    public class ThicknessSolver
    {
        ThicknessCalculate calculate;
        Class1Solver temperatureSolver;
        protected int thicknessSolveStep;
        protected double thicknessSolverResidual;
        public event ThicknessSolverStartEventHandler SolveStartEvent;
        public event ThicknessSolverStopEventHandler SolveStopEvent;
        public event ThicknessSolverUpdateEventHandler SolveUpdateEvent;

        public ThicknessCalculate ThicknessCalculate { get => calculate; set => calculate = value; }
        public Class1Solver TemperatureSolver { get => temperatureSolver; }
        public int ThicknessSolveStep { get => thicknessSolveStep; }
        public double ThicknessSolverResidual { get => thicknessSolverResidual; }
        public double TargetLayerThickness { get => ThicknessCalculate.Calculate.LayerList[ThicknessCalculate.LayerIndex].Thickness; set => ThicknessCalculate.Calculate.LayerList[ThicknessCalculate.LayerIndex].Thickness = value; }
        protected bool IsConvergenced
        {
            get
            {
                if (ThicknessCalculate.ThicknessSolveParameter.CcType == SolverControlParameter.ConvergenceCriterionType.RESIDUAL)
                {
                    if (ThicknessSolverResidual < ThicknessCalculate.ThicknessSolveParameter.Residual)
                        return true;
                }
                else if (ThicknessCalculate.ThicknessSolveParameter.CcType == SolverControlParameter.ConvergenceCriterionType.MAXSTEP)
                {
                    if (ThicknessSolveStep > ThicknessCalculate.ThicknessSolveParameter.MaxStep)
                        return true;
                }
                else if (ThicknessCalculate.ThicknessSolveParameter.CcType == SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP)
                {
                    if (ThicknessSolverResidual < ThicknessCalculate.ThicknessSolveParameter.Residual || ThicknessSolveStep > ThicknessCalculate.ThicknessSolveParameter.MaxStep)
                        return true;
                }
                return false;
            }
        }
        private ThicknessSolver() { }
        public ThicknessSolver(ThicknessCalculate _calculate)
        {
            calculate = _calculate;
            temperatureSolver = SolverFactory.CreateSolver(calculate.Calculate);

        }
        
        protected void OnSolverStart()
        {
            if (SolveStartEvent != null)
                SolveStartEvent(this);
        }
        protected void OnSolverStop()
        {
            if (SolveStopEvent != null)
                SolveStopEvent(this);
        }
        protected void OnSolveUpdate()
        {
            if (SolveUpdateEvent != null)
                SolveUpdateEvent(this);
        }
        public virtual void Solve()
        {

        }
        public virtual double LimitValue()
        {
            return 0.0;
        }

    }
    public class ThicknessSolverC1 : ThicknessSolver
    {
        public ThicknessSolverC1(ThicknessCalculate _calculate) : base(_calculate) { }
        public override void Solve()
        {
            thicknessSolverResidual = 10000000;
            thicknessSolveStep = 0;
            OnSolverStart();
            double[] thickness = { 0.001, 0.005 };
            double[] target = { 0, 0 };
            TargetLayerThickness = thickness[0];
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[0] = ThicknessCalculate.Calculate.Boundary.Heatflow;
            TargetLayerThickness = thickness[1];
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[1] = ThicknessCalculate.Calculate.Boundary.Heatflow;
            while (true)
            {
                if (IsConvergenced)
                    break;
                double NewValue = (thickness[1] - thickness[0]) / (target[1] - target[0]) * (ThicknessCalculate.TargetValue - target[0]) + thickness[0];
                TargetLayerThickness = NewValue;
                TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
                thickness[0] = thickness[1];
                target[0] = target[1];
                thickness[1] = NewValue;
                target[1] = ThicknessCalculate.Calculate.Boundary.Heatflow;
                thicknessSolveStep++;
                thicknessSolverResidual = Math.Abs(ThicknessCalculate.Calculate.Boundary.Heatflow - ThicknessCalculate.TargetValue);
                OnSolveUpdate();
                
            }
            OnSolverStop();
        }
        public override double LimitValue()
        {
            TargetLayerThickness = 0;
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            return ThicknessCalculate.Calculate.Boundary.Heatflow;
        }

    }
    public class ThicknessSolverC2 : ThicknessSolver
    {
        public ThicknessSolverC2(ThicknessCalculate _calculate) : base(_calculate) { }
        public override void Solve()
        {
            thicknessSolverResidual = 10000000;
            thicknessSolveStep = 0;
            OnSolverStart();
            double[] thickness = { 0.001, 0.005 };
            double[] target = { 0, 0 };
            TargetLayerThickness = thickness[0];
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[0] = ThicknessCalculate.Calculate.Boundary.Temperature;
            TargetLayerThickness = thickness[1];
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[1] = ThicknessCalculate.Calculate.Boundary.Temperature;
            while (true)
            {
                if (IsConvergenced)
                    break;
                double NewValue = (thickness[1] - thickness[0]) / (target[1] - target[0]) * (ThicknessCalculate.TargetValue - target[0]) + thickness[0];
                TargetLayerThickness = NewValue;
                TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
                thickness[0] = thickness[1];
                target[0] = target[1];
                thickness[1] = NewValue;
                target[1] = ThicknessCalculate.Calculate.Boundary.Temperature;
                thicknessSolveStep++;
                thicknessSolverResidual = Math.Abs(ThicknessCalculate.Calculate.Boundary.Temperature - ThicknessCalculate.TargetValue);
                OnSolveUpdate();
                
            }
            OnSolverStop();
        }
        public override double LimitValue()
        {
            TargetLayerThickness = 0;
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            return ThicknessCalculate.Calculate.Boundary.Temperature;
        }
    }
    public class ThicknessSolverC3 : ThicknessSolver
    {
        public ThicknessSolverC3(ThicknessCalculate _calculate) : base(_calculate) { }
        public override void Solve()
        {
            thicknessSolverResidual = 10000000;
            thicknessSolveStep = 0;
            OnSolverStart();
            double[] thickness = { 0.001, 0.005 };
            double[] target = { 0, 0 };
            TargetLayerThickness = thickness[0];
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[0] = ThicknessCalculate.Calculate.Boundary.Temperature;
            TargetLayerThickness = thickness[1];
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            target[1] = ThicknessCalculate.Calculate.Boundary.Temperature;
            while (true)
            {

                if (IsConvergenced)
                    break;
                double NewValue = (thickness[1] - thickness[0]) / (target[1] - target[0]) * (ThicknessCalculate.TargetValue - target[0]) + thickness[0];
                TargetLayerThickness = NewValue;
                TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
                thickness[0] = thickness[1];
                target[0] = target[1];
                thickness[1] = NewValue;
                target[1] = ThicknessCalculate.Calculate.Boundary.Temperature;
                thicknessSolveStep++;
                thicknessSolverResidual = Math.Abs(ThicknessCalculate.Calculate.Boundary.Temperature - ThicknessCalculate.TargetValue);
                OnSolveUpdate();
                
            }
            OnSolverStop();
        }
        public override double LimitValue()
        {
            TargetLayerThickness = 0;
            TemperatureSolver.InitalizeTemperature();
            TemperatureSolver.Solve(ThicknessCalculate.TemperatureSolveParameter);
            return ThicknessCalculate.Calculate.Boundary.Temperature;
        }
    }
    public static class ThicknessSolverFactory
    {
        public static ThicknessSolver CreateSolver(ThicknessCalculate calculate)
        {
            if (calculate.Calculate.Boundary is Class3Boundary)
                return new ThicknessSolverC3(calculate);
            else if (calculate.Calculate.Boundary is Class2Boundary)
                return new ThicknessSolverC2(calculate);
            else
                return new ThicknessSolverC1(calculate);
        }
    }
}
