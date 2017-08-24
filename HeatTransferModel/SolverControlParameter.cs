using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    [Serializable]
    public class SolverControlParameter
    {
        public enum ConvergenceCriterionType
        {
            RESIDUAL = 0,
            MAXSTEP = 1,
            RESIDUAL_OR_MAXSTEP = 2
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
        public SolverControlParameter(ConvergenceCriterionType _ccType, double _residual, int _maxStep, int _intergrateCount)
        {
            ccType = _ccType;
            residual = _residual;
            maxStep = _maxStep;
            integrateCount = _intergrateCount;
        }
        public static SolverControlParameter Default
        {
            get
            {
                return new SolverControlParameter(ConvergenceCriterionType.RESIDUAL, 0.001, 100, 0);
            }
        }

    }
}
