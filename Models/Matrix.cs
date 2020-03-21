using System.Collections.Generic;
using System.Collections;
using System;
namespace Matrices.Models
{
   public class Matrix: IEnumerable
   {
        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsMatOk { get; set; } = true;
        public List<List<double>> Data { get; set; }
        public Matrix(){
            Row = 0;
            Col = 0;
            Data = new List<List<double>>();
        }
        public Matrix(int r, int c){
            Row = r;
            Col = c;
            Data = new List<List<double>>();
            for (int i = 0; i < Row; i++)
            {
                var tempRow = new List<double>();
                for (int j = 0; j < Col; j++)
                {
                    double val = 0.0;
                    tempRow.Add(val);
                }
                Data.Add(tempRow);
            }
        }
        public List<double> this[int index]
        {
            get => Data[index];
            set => Data[index] = new List<double>(value);
        }
        public IEnumerator GetEnumerator()
        {
            return Data.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public static Matrix operator +(Matrix A, Matrix B){
            Matrix C = new Matrix(A.Row,B.Col);
            for (int i = 0; i < C.Row; i++)
            {
                for (int j = 0; j < C.Col; j++)
                {
                    C[i][j] = A[i][j] + B[i][j];
                }
            }
            return C;
        }
        public static Matrix operator -(Matrix A, Matrix B){
            Matrix C = new Matrix(A.Row,B.Col);
            for (int i = 0; i < C.Row; i++)
            {
                for (int j = 0; j < C.Col; j++)
                {
                    C[i][j] = A[i][j] - B[i][j];
                }
            }
            return C;
        }
        public static Matrix operator *(Matrix A, Matrix B){
            Matrix C = new Matrix(A.Row,B.Col);
            Matrix BT = ~B;
            for (int i = 0; i < C.Row; i++)
            {
                List<double> v1 = A[i];
                for (int j = 0; j < C.Col; j++)
                {
                    List<double> v2 = BT[j];
                    for (int y = 0; y < v1.Count; y++)
                    {
                       C[i][j]+= v1[y]*v2[y];
                    }
                }
            }
            return C;
        }
        public static Matrix operator *(double val, Matrix mx){
            Matrix res = new Matrix(mx.Row,mx.Col);
            for (int i=0;i<res.Row;++i)
            {
                for (int j = 0; j < res.Col; j++)
                {
                    res[i][j] = mx[i][j]*val;
                }
            }
            return res;
        }
        public static Matrix operator *(Matrix mx,double val){
            Matrix res = new Matrix(mx.Row,mx.Col);
            for (int i=0;i<res.Row;++i)
            {
                for (int j = 0; j < res.Col; j++)
                {
                    res[i][j] = mx[i][j]*val;
                }
            }
            return res;
        }
        public static Matrix operator ~(Matrix A){ // ~A := A^T
            Matrix B = new Matrix(A.Col,A.Row);
            for (int i = 0; i < B.Row; i++)
            {
                    for (int j = 0; j < B.Col; j++)
                    {
                        B[i][j] = A[j][i];
                    }
            }
            return B;
        }
        public static Matrix operator !(Matrix A){ // !A := A^-1
            Matrix AI = new Matrix(A.Row,A.Col*2);
            Matrix inv = new Matrix(A.Row,A.Col);
            for (int i = 0; i < AI.Row; ++i)
            {
                for (int c = 0; c < AI.Col; c++)
                {
                    if(c<A.Col)
                        AI[i][c] = A[i][c];
                    else if(c==(A.Col+i))
                        AI[i][c] = 1.0;
                }
            }
            for (int r = 0; r < A.Row; r++)
            {
                //pivot
                // IsZero, MultEsc, SumVecEq are Extension methods
                if(AI[r][r].IsZero()){    
                    bool state = false;
                    for(int i=r+1;i<A.Row;++i){
                        if(!AI[i][r].IsZero()){
                            var temp = new List<double>(AI[r]);
                            AI[r] = new List<double>(AI[i]);
                            AI[i] = new List<double>(temp);
                            state = true;
                            break;
                        }
                    }
                    inv.IsMatOk = state;
                }
                AI[r] = AI[r].MultEsc(1.0/AI[r][r]);
                for (int c = 0; c < A.Col; c++)
                {
                    if(r!=c){
                        AI[c] = AI[r].MultEsc(-1.0*AI[c][r]).SumVecEq(AI[c]);
                    }
                }
            }
            for(int r=0;r<A.Row;r++){
                for(int c=A.Row;c<A.Row*2;c++){
                    inv[r][c-A.Row] = AI[r][c];
                }
            }
            return inv;
        }
   }
}