using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFeelGreat
{
    public class  Solution
    {
        public double maleRatio;
        public double femaleRatio;
        public double maleYes;
        public double maleNo;
        public double femaleYes;
        public double femaleNo;

        public Solution(double _maleRatio,double _maleYes,double _femaleYes)
        {

            maleRatio = _maleRatio;
            maleYes = _maleYes;
            femaleYes = _femaleYes;
           
            femaleRatio = 1- maleRatio;
            maleNo = 1 - maleYes;
            femaleNo = 1 - femaleYes;
            

        }
        public List<double> probabilityNo()
        {   //                           
            double probabilityMaleNo = (maleRatio * maleNo) / ((maleRatio * maleNo) + (femaleRatio * femaleNo));
            double probabilityFemaleNo = (femaleRatio * femaleNo) / ((maleRatio * maleNo) + (femaleRatio * femaleNo));
            var result = new List<double> { probabilityMaleNo, probabilityFemaleNo };
            return result;
        }

        public List<double> probabilityYes()
        {
            double probabilityMaleYes = (maleRatio * maleYes) / ((maleRatio * maleYes) + (femaleRatio * femaleYes));
            double probabilityFemaleYes = (femaleRatio * femaleYes) / ((maleRatio * maleYes) + (femaleRatio * femaleYes));
            var result = new List<double> { probabilityMaleYes, probabilityFemaleYes };
            return result;
        }


    }
}
