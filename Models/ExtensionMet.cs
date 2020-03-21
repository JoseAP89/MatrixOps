using System.Collections.Generic;
using System.Linq;
using System;
namespace Matrices.Models
{
    public static class MyExtensions
    {
        public static List<double> MultEsc(this List<double> vec,double val){
            List<double> res = new List<double>();
            for (int i=0;i<vec.Count;++i)
            {
               res.Add(vec[i]*val);
            }
            return res;
        }
        public static List<double> SumVecEq(this List<double> A,List<double> B){
            List<double> res = new List<double>();
            for (int i = 0; i < A.Count; i++)
            {
                res.Add(A[i] + B[i]);
            }
            return res;
        }
        public static bool IsZero(this double num){
            return Math.Abs(num) < 0.000000001;
        }
        public static Matrix FillMat(this double[] vec,int row, int col, int init){
            Matrix C = new Matrix(row,col);
            int count = init;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    C[i][j] = vec[count++];
                }
            }
            return C;
        }

    }
}