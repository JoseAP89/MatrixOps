using Matrices.Models;
namespace Matrices.ViewModels
{
    public class MatrixViewModel
    {
        private readonly string[] accions =  {"OpAdd","OpSub","OpMul"
            ,"OpTran","OpInv","OpSol"};
        public string Accion { 
            get => accions[(int)Operation];
        }
        public Matrix Result {get;set;}
        public OpType Operation { get; set; }
        public int RowA { get; set; }
        public int ColA { get; set; }
        public int RowB { get; set; }
        public int ColB { get; set; }
    }
}