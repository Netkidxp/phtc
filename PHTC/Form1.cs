using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.DB;
using PHTC.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace PHTC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }
       
        void OutputDebugInformation(Class1Solver solver)
        {
            Console.WriteLine("----------------------------------第{0}次迭代------------------------------",solver.CurrentStep);
            Console.WriteLine("残差:{0:#.###}",solver.CurrentResidual);
            Console.WriteLine("热流:{0:####.###} ",solver.CurrentCalculate.Boundary.Heatflow);
            for (int j = 0; j < solver.CurrentCalculate.LayerList.Count; j++)
            {
                Console.WriteLine("第{0}层温度:{1:####}   {2:####}，热阻:{3:#.###}",j,solver.CurrentCalculate.LayerList[j].HighTemperature, solver.CurrentCalculate.LayerList[j].LowTemperature, solver.CurrentCalculate.LayerList[j].HeatResistance);
            }
            
        }
        void OnUpdate(Class1Solver solver)
        {
           
            chart1.Series[0].Points.AddXY(solver.CurrentStep, solver.CurrentResidual);
            for (int i = 0; i < solver.CurrentCalculate.LayerList.Count; i++)
            {
                chart2.Series[i].Points.AddXY(solver.CurrentStep,solver.CurrentCalculate.LayerList[i].LowTemperature); ;
            }
            string txt = "";
            txt += String.Format("\r\n---------------第{0}次迭代---------------\r\n", solver.CurrentStep);
            txt += String.Format("残差:{0:0.0000}\r\n", solver.CurrentResidual);
            txt += String.Format("热流:{0:0000.00}\r\n", solver.CurrentCalculate.Boundary.Heatflow);
            for (int j = 0; j < solver.CurrentCalculate.LayerList.Count; j++)
            {
                txt += String.Format("第{0}层温度:{1:0000.00}    {2:0000.00}，热阻:{3:0.000}\r\n", j, solver.CurrentCalculate.LayerList[j].HighTemperature, solver.CurrentCalculate.LayerList[j].LowTemperature, solver.CurrentCalculate.LayerList[j].HeatResistance);
            }
            textBox2.Text+= txt;
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
        }
        void OnEnd(Class1Solver solver)
        {
            textBox2.Text += "\r\n计算完毕！！！\r\n";
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
        }
        void OnInit(Class1Solver solver)
        {
            
            chart1.Series[0].Points.Clear();
            chart2.Series.Clear();
            for(int i=0;i<solver.CurrentCalculate.LayerList.Count;i++)
            {
                Series s = new Series("第"+i.ToString()+"层低温");
                s.ChartType = SeriesChartType.Line;
                s.BorderWidth = 3;
                chart2.Series.Add(s);
            }
            textBox2.Text = "初始化完毕！！！\r\n";

        }
        void OnStart(Class1Solver solver)
        {
            textBox2.Text += "开始计算！！！\r\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //DbMaterialAdapter.Delete(15);
            MaterialManageForm mmf = new MaterialManageForm();
            mmf.Show();
        }
        private List<Layer> CreateTestLayers()
        {
            Material mat = DbMaterialAdapter.LoadWithId(9);
            Layer layer = new Layer(mat, 0.3);
            List<Layer> layers = new List<Layer>();
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(10);
            layer = new Layer(mat, 0.4);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(11);
            layer = new Layer(mat, 0.5);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(12);
            layer = new Layer(mat, 0.15);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(13);
            layer = new Layer(mat, 0.1);
            layers.Add(layer);
            return layers;
        }
        private void CreateTestSolverAndRun(Calculate cal)
        {
            Class1Solver solver = SolverFactory.CreateSolver(cal);
            solver.InitalizedTemperatureEndEvent += new InitalizedTemperatureEndEventHandler(OnInit);
            solver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnUpdate);
            solver.SolveEndEvent += new SolveEndEventHandler(OnEnd);
            solver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OutputDebugInformation);
            solver.SolveStartEvent += new SolveStartEventHandler(OnStart);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.01, 50, 0);
            solver.InitalizeTemperature();
            solver.Solve(par);
        }
        private void Test(Class1Boundary boundary)
        {
            List<Layer> layers = CreateTestLayers();
            Model.Calculate cm = new Model.Calculate(1600+273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }
        private void PLATE_C1(object sender, EventArgs e)
        {

            
            Class1Boundary boundary = new Class1Boundary(100+273.15);
            Test(boundary);
        }

        private void PLATE_C2(object sender, EventArgs e)
        {

            Class2Boundary boundary = new Class2Boundary(1038.09);
           
            Test(boundary);

        }

        private void PLATE_C3_COV(object sender, EventArgs e)
        {

            
            
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.0, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void PLATE_C3_RAD(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(0.0, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void PLATE_C3_COM(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series res = new Series("  残       差  ");
            res.ChartType = SeriesChartType.Line;
            res.Color = Color.Red;
            res.BorderWidth = 3;
            chart1.Series.Add(res);
            //chart1.ChartAreas[0].AxisY.Minimum = -100;
        }

        private List<Layer> CreateTestTubbinessLayers()
        {
            Material mat = DbMaterialAdapter.LoadWithId(9);
            
            TubbinessLayer layer = new TubbinessLayer(mat, 0.2, 1.0);
            List<Layer> layers = new List<Layer>();
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(10);
            layer = new TubbinessLayer(mat, 0.3, layer.OutsideRadius);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(11);
            layer = new TubbinessLayer(mat, 0.15, layer.OutsideRadius);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(12);
            layer = new TubbinessLayer(mat, 0.1, layer.OutsideRadius);
            layers.Add(layer);
            mat = DbMaterialAdapter.LoadWithId(13);
            layer = new TubbinessLayer(mat, 0.05, layer.OutsideRadius);
            layers.Add(layer);
            return layers;
        }
        private void TUBBIN_C1(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class1Boundary boundary = new Class1Boundary(100+273.15);
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void TUBBIN_C2(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class2Boundary boundary = new Class2Boundary(14879.5);
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void TUBBIN_C3_COV(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.0, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void TUBBIN_C3_RAD(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(0.0, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        private void TUBBIN_C3_COM(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cm = new Model.Calculate(1600 + 273.15, boundary, layers);
            CreateTestSolverAndRun(cm);
        }

        void OnThicknessSolveStart(ThicknessSolver solver)
        {
            textBox2.Text = "厚度求解器开始计算";
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            Series s1 = new Series("温度求解器残差");
            Series s2 = new Series("厚度求解器残差");
            Series s3 = new Series("所求层厚度");
            s1.ChartType = SeriesChartType.Spline;
            s1.BorderWidth = 2;
            s2.ChartType = SeriesChartType.Spline;
            s2.BorderWidth = 2;
            s3.ChartType = SeriesChartType.Spline;
            s3.BorderWidth = 2;


            chart1.Series.Add(s1);
            chart2.Series.Add(s2);
            chart3.Series.Add(s3);
        }
        void OnThicknessSolveStop(ThicknessSolver solver)
        {
            string txt = "厚度求解器结束计算";
            
            textBox2.Text += txt;
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();

        }
        void OnThicknessSolveUpdate(ThicknessSolver solver)
        {
            chart2.Series[0].Points.AddY(solver.ThicknessSolverResidual);
            chart3.Series[0].Points.AddY(solver.ThicknessCalculate.Calculate.LayerList[solver.ThicknessCalculate.LayerIndex].Thickness);
            PrintThicknessSolveInformation(solver);
        }
        void OnTemperatureSolverUpdate(Class1Solver solver)
        {
            chart1.Series[0].Points.AddY(solver.CurrentResidual);
        }
        void PrintThicknessSolveInformation(ThicknessSolver solver)
        {
            string txt = "";
            txt += String.Format("\r\n---------------第{0}次迭代---------------\r\n", solver.ThicknessSolveStep);
            txt += String.Format("残差:{0:0.0000}\r\n", solver.ThicknessSolverResidual);
            txt += String.Format("热流:{0:0000.00}\r\n", solver.ThicknessCalculate.Calculate.Boundary.Heatflow);
            for (int j = 0; j < solver.ThicknessCalculate.Calculate.LayerList.Count; j++)
            {
                if(solver.ThicknessCalculate.LayerIndex==j)
                    txt += String.Format("**********************************\r\n第{0}层厚度:{1:0.000}，热阻:{2:0.000}\r\n**********************************\r\n", j,solver.ThicknessCalculate.Calculate.LayerList[j].Thickness, solver.ThicknessCalculate.Calculate.LayerList[j].HeatResistance);
                else
                    txt += String.Format("第{0}层厚度:{1:0.000}，热阻:{2:0.000}\r\n", j, solver.ThicknessCalculate.Calculate.LayerList[j].Thickness, solver.ThicknessCalculate.Calculate.LayerList[j].HeatResistance);
            }
            textBox2.Text += txt;
           

        }
        private void THICKNESS_PLATE_C1(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class1Boundary boundary = new Class1Boundary(100+273.15);
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 1038.09, par, par);
            //ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 2038.09, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_PLATE_C2(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class2Boundary boundary = new Class2Boundary(1038.09);
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 273.15+100, par, par);
            //ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 273.15 + 900, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_PLATE_C3_CON(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.0, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 400.07, par, par);
            //ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 600.07, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_PLATE_C3_RAD(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(0, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 416.58, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_PLATE_C3_COM(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 361.32, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_TUBBIN_C1(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class1Boundary boundary = new Class1Boundary(100 + 273.15);
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 19667.83, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_TUBBIN_C2(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class2Boundary boundary = new Class2Boundary(14879.50);
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 728.99, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_TUBBIN_C3_CON(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 461.49, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_TUBBIN_C3_RAD(object sender, EventArgs e)
        {
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(0, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 458.01, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }

        private void THICKNESS_TUBBIN_C3_COM(object sender, EventArgs e)
        {
            
            List<Layer> layers = CreateTestTubbinessLayers();
            Class3Boundary boundary = new Class3Boundary(10, 0.8, 25 + 273.15, Calculate.OutsideArea(layers));
            Model.Calculate cal = new Model.Calculate(1600 + 273.15, boundary, layers);
            SolverControlParameter par = new SolverControlParameter(SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP, 0.001, 50, 0);
            ThicknessCalculate tcal = new ThicknessCalculate(cal, 2, 394.94, par, par);
            ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(tcal);
            solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdate);
            solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolveStart);
            solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolveUpdate);
            solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolveStop);
            double lim = solver.LimitValue();
            solver.Solve();
        }
    }
}
