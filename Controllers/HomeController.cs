using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Matrices.Models;
using Matrices.ViewModels;

namespace Matrices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Addition() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addition(InfoMat mat)
        {
            if(ModelState.IsValid){
                return View("Gen2Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Addition
                });
            }
            return View(mat);
        }

        [HttpPost]
        public IActionResult OpAdd(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                Matrix B = op.Data.FillMat(op.RowA,op.ColA, op.RowA*op.ColA);
                var C = new MatrixViewModel(){Result = A+B};
                return View("Result",C);
            }
            return View("Gen2Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                RowB = op.RowB, ColB = op.ColB, Operation = OpType.Addition});  
        }

        [HttpGet]
        public IActionResult Substraction()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Substraction(InfoMat mat)
        {
            if(ModelState.IsValid){
                return View("Gen2Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Substraction
                });
            }
            return View(mat);
        }

        [HttpPost]
        public IActionResult OpSub(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                Matrix B = op.Data.FillMat(op.RowA,op.ColA, op.RowA*op.ColA);
                var C = new MatrixViewModel(){Result = A-B};
                return View("Result",C);
            }
            return View("Gen2Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                RowB = op.RowB, ColB = op.ColB, Operation = OpType.Substraction});  
        }

        [HttpGet]
        public IActionResult Transpose()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Transpose(InfoMat mat)
        {
            if(ModelState.IsValid){
                return View("Gen1Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Transpose
                });
            }
            return View(mat);
        }

        [HttpPost]
        public IActionResult OpTran(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                var C = new MatrixViewModel(){Result = ~A};
                return View("Result",C);
            }
            return View("Gen1Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                RowB = 0, ColB = 0,Operation = OpType.Transpose});
            
        }

        [HttpGet]
        public IActionResult Multiplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplication(InfoMat mat)
        {
            if(ModelState.IsValid){
                return View("Gen2Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Multiplication
                });
            }
            return View(mat);
        }

        [HttpPost]
        public IActionResult OpMul(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                Matrix B = op.Data.FillMat(op.RowB,op.ColB, op.RowA*op.ColA);
                var C = new MatrixViewModel(){Result = A*B};
                return View("Result",C);
            }
            return View("Gen2Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                RowB = op.RowB, ColB = op.ColB, Operation = OpType.Multiplication});
        }

        [HttpGet]
        public IActionResult Inverse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inverse(InfoMat mat)
        {
            if(ModelState.IsValid){
                return View("Gen1Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Inverse
                });
            }
            return View(mat);
        }

        [HttpPost]
        public IActionResult OpInv(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                Matrix res = !A;
                if(!res.IsMatOk){
                    string[] error = {
                        "Inverse matrix is not possible to obtain.",
                        "Matrix have dependent rows and is no linearly independent.",
                    };
                    return View("Error",error);
                }
                var C = new MatrixViewModel(){Result = res};
                return View("Result",C);
            }
            return View("Gen1Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                Operation = OpType.Inverse});
        }

        [HttpGet]
        public IActionResult Solution()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Solution(InfoMat mat) 
        {
            if(ModelState.IsValid){
                return View("Gen2Mat", new MatrixViewModel(){RowA = mat.RowA, ColA= mat.ColA,
                    RowB =mat.RowB, ColB = mat.ColB, Operation = OpType.Solution
                });
            }
            return View(mat);
        }
        
        [HttpPost]
        public IActionResult OpSol(InfoOp op)
        {
            if(ModelState.IsValid){
                Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                Matrix b = op.Data.FillMat(op.RowB,op.ColB, op.RowA*op.ColA);
                Matrix inv = !A;
                if(!inv.IsMatOk){
                    string[] error = {
                        "Inverse matrix is not possible to obtain.",
                        "System have dependent rows and is no linearly independent.",
                        "Thus, system has many or no solution whatsoever."
                    };
                    return View("Error",error);
                }
                var C = new MatrixViewModel(){Result = inv*b};
                return View("Result",C);
            }
            return View("Gen2Mat", new MatrixViewModel{RowA = op.RowA, ColA = op.ColA,
                RowB = op.RowB, ColB = op.ColB, Operation = OpType.Solution});
        }
        
        public IActionResult OpAns(InfoOp op /* InfoAns ans */){
            switch (op.Operation)
            {
                case OpType.Addition:{
                    var M = new MatrixViewModel{}; //create ToArray()
                    break;
                    //Create class InfoAns which will substitute MatrixViewModel in this one
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
