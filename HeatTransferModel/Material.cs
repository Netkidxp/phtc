using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class Material
    {
        //public double thermalConductivity;
        //public double specificHeat;
        
        private int index;
        private String name;
        private int ownerId;
        private String code;
        private String use_for;
        private DateTime create_time;
        private DateTime modify_time;
        private double density;
        private List<RefValue> tCs;
        private List<RefValue> sHs;
        private Boolean tcIsFun = false;
        private Boolean shIsFun = false;
        private String remark;
        private bool share;
        private User owner;

        public int Index { get => index; set => index = value; }
        public string Name { get => name; set => name = value; }
        public int OwnerId { get => ownerId; set => ownerId = value; }
        public string Code { get => code; set => code = value; }
        public string Use_for { get => use_for; set => use_for = value; }
        public DateTime Create_time { get => create_time; set => create_time = value; }
        public DateTime Modify_time { get => modify_time; set => modify_time = value; }
        public double Density { get => density; set => density = value; }
        public List<RefValue> TCs { get => tCs; set => tCs = value; }
        public List<RefValue> SHs { get => sHs; set => sHs = value; }
        public bool TcIsFun { get => tcIsFun; set => tcIsFun = value; }
        public bool ShIsFun { get => shIsFun; set => shIsFun = value; }
        public string Remark { get => remark; set => remark = value; }
        public bool Share { get => share; set => share = value; }
        public User Owner { get => owner; set => owner = value; }

        private  Material() { }
        public Material(int _index,String _name,User _owner,int _ownerId,String _code,String _use_for,DateTime _create_time,DateTime _modify_time,double _density,String _remark,List<RefValue> _tCs,List<RefValue> _sHs,Boolean _tcIsFun,Boolean _shIsFun,bool _share)
        {
            Index = _index;
            Name = _name;
            owner = _owner;
            OwnerId = _ownerId;
            Code = _code;
            Use_for = _use_for;
            Create_time = _create_time;
            Modify_time = _modify_time;
            Density = _density;
            Remark = _remark;
            TCs = _tCs;
            SHs = _sHs;
            TcIsFun = _tcIsFun;
            ShIsFun = _shIsFun;
            share = _share;
        }
        
        public double lookupThermalConductivity(double temperature)
        {
            double result = 0.0;
            if (TcIsFun)
                result = lookupValueFromFun(temperature, TCs);
            else
                result = lookupValueFromList(temperature, TCs);
            return result;
        }
        public double lookupSpecificHeat(double temperature)
        {
            double result = 0.0;
            if (ShIsFun)
                result = lookupValueFromFun(temperature, SHs);
            else
                result = lookupValueFromList(temperature, SHs);
            return result;
        }
        private double lookupValueFromFun(double temperature,List<RefValue> values)
        {
            double result = 0.0;
            //double i = 0.0;
            foreach (RefValue rv in values)
            {
                result += rv.v * Math.Pow(temperature, rv.r);
                //i += 1.0;
            }
            return result;
        }
        private double lookupValueFromList(double temperature, List<RefValue> values)
        {
            double result = 0.0;
            if (values.Count == 1)
                result = values[0].v;
            else if (temperature < values[0].r)
                result = values[0].v;
            else if (temperature > values[values.Count - 1].r)
                result = values[values.Count - 1].v;
            else
            {
                int ri = 0;
                for (int i=0;i<values.Count;i++)
                {
                    if (temperature == values[i].r)
                    {
                        result = values[i].v;
                        return result;
                    }
                }
                for (int i = 0; i < values.Count-1; i++)
                {
                    if((temperature-values[i].r)*(temperature-values[i+1].r)<0)
                    {
                        ri = i;
                        break;
                    }
                }
                result = values[ri].v + (values[ri + 1].v - values[ri].v) / (values[ri + 1].r - values[ri].r) * (temperature - values[ri].r);
            }
            return result;
        }
        
    }
    
    public class RefValue
    {
        public double v;
        public double r;
        public RefValue(double _r,double _v)
        {
            v = _v;
            r = _r;
        }
    }
}
