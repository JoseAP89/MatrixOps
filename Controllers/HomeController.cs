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
        public IActionResult Operation(){
            return View(new InfoOp{RowA=2,ColA=2,RowB=2,ColB=2});
        }
        [HttpPost]
        public IActionResult Operation(InfoOp op){
            if(ModelState.IsValid){
                switch (op.Operation)
                {
                    case OpType.ResizeA:{
                        double[] data = new double[op.RowA*op.ColA+op.RowB*op.ColB];
                        for (int newd = data.Length-1, former=op.Data.Length-1; newd >= op.RowA*op.ColA ;
                            newd--, former--)
                        {
                            data[newd] = op.Data[former];
                        }
                        Matrix A = data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Operation = op.Operation   
                        });
                    }
                    case OpType.ResizeB:{
                        double[] data = new double[op.RowA*op.ColA+op.RowB*op.ColB];
                        for (int i = 0; i < op.RowA*op.ColA; i++)
                        {
                            data[i] = op.Data[i];
                        }
                        Matrix A = data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Operation = op.Operation   
                        });
                    }
                    case OpType.Swap:{
                        Matrix B = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix A = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Operation = op.Operation  
                        });
                    }
                    case OpType.Addition:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R =  A+B;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col  
                        });
                    }
                    case OpType.Substraction:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R =  A-B;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col  
                        });
                    }
                    case OpType.Multiplication:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R =  A*B;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col  
                        });
                    }
                    case OpType.TransposeA:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R =  ~A;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col   
                        });
                    }
                    case OpType.TransposeB:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R =  ~B;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col   
                        });
                    }
                    case OpType.InverseA:
                    case OpType.InverseB:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix R = op.Operation==OpType.InverseA?!A:!B;
                        if(!R.IsMatOk){
                            string[] error = {
                                "Inverse matrix is not possible to obtain.",
                                "Matrix have dependent rows and is no linearly independent.",
                            };
                            /*  */
                            return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                                MatrixA = A, MatrixB = B, ErrorMsg = error
                            });
                        }
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R , Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col  
                        });
                    }
                    case OpType.Solution:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA, 0);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        Matrix inv = !A;
                        if(!inv.IsMatOk){
                            string[] error = {
                                "Inverse matrix is not possible to obtain.",
                                "Matrix have dependent rows and is no linearly independent.",
                            };
                            return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                                MatrixA = A, MatrixB = B, ErrorMsg = error
                            });
                        }
                        Matrix R = inv*B;
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B , Result = R, Operation = op.Operation,
                            RowR = R.Row, ColR = R.Col   
                        });
                    }
                    case OpType.RtoA:{
                        Matrix A = op.Data.FillMat(op.RowR,op.ColR, 
                            op.RowA*op.ColA+op.RowB*op.ColB);
                        Matrix B = op.Data.FillMat(op.RowB,op.ColB,op.RowA*op.ColA);
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B
                        });
                    }
                    case OpType.RtoB:{
                        Matrix A = op.Data.FillMat(op.RowA,op.ColA,0);
                        Matrix B = op.Data.FillMat(op.RowR,op.ColR, 
                            op.RowA*op.ColA+op.RowB*op.ColB);
                        
                        return View(new InfoOp{RowA=A.Row,ColA=A.Col,RowB=B.Row,ColB=B.Col,
                            MatrixA = A, MatrixB = B
                        });
                    }
                }
                
            }
            return View(new InfoOp{RowA=2,ColA=2,RowB=2,ColB=2, Operation=OpType.ResizeA});
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
