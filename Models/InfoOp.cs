using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Matrices.Models
{
    public class InfoOp:IValidatableObject
    {
        [Range(1, 10)]
        public int RowA {get;set;}

        [Range(1, 10)]
        public int ColA { get; set; }

        [Range(1, 10)]
        public int RowB { get; set; }

        [Range(1, 10)]
        public int ColB { get; set; }

        public int RowR { get; set; }
        public int ColR { get; set; }

        public OpType Operation { get; set; }
        public Matrix MatrixA { get; set; }
        public Matrix MatrixB { get; set; }
        public Matrix Result { get; set; }
        public IEnumerable<string> ErrorMsg { get; set; }
        public double[] Data { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            switch(Operation){
                case OpType.Solution:{
                    bool rowColProp = ColA == RowB;
                    bool invProp = ColA == RowA ;
                    bool bProp = ColB == 1 ;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Multiplication are not achieved");
                        yield return new ValidationResult(
                            $"Column A must be equal to Row B");
                    }
                    if(!invProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix invertion are not achieved. Matrix A must be a squared Matrix.");
                    }
                    if(!bProp){
                        yield return new ValidationResult(
                            $"Column of vector b must be equal to 1");
                    }
                    break;
                }
                case OpType.Addition:
                case OpType.Substraction:{
                    bool rowProp = RowA == RowB;
                    bool colProp = ColA == ColB;
                    if(!rowProp || !colProp)
                        yield return new ValidationResult(
                            $"Properties for Matrix addition are not achieved");
                    if(!rowProp){
                        yield return new ValidationResult(
                            $"Row A must be equal to Row B");
                    }
                    if(!colProp){
                        yield return new ValidationResult(
                            $"Column A must be equal to Column B");
                    }
                    break;
                }
                case OpType.Multiplication:{
                    bool rowColProp = ColA == RowB;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Multiplication are not achieved");
                        yield return new ValidationResult(
                            $"Column A must be equal to Row B");
                    }
                    break;
                }
                case OpType.InverseA:{
                    bool rowColProp = ColA == RowA;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Inversion are not achieved");
                        yield return new ValidationResult(
                            $"Column A must be equal to Row A");
                    }
                    break;
                }
                case OpType.InverseB:{
                    bool rowColProp = ColB == RowB;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Inversion are not achieved");
                        yield return new ValidationResult(
                            $"Column B must be equal to Row B");
                    }
                    break;
                }
                case OpType.TransposeA:
                    break;
                case OpType.TransposeB:
                    break;
                default:
                    break;
            }
        }

    }
}