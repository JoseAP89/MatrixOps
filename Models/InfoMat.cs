using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Matrices.Models
{
    public class InfoMat:IValidatableObject
    {
        
        public int RowA { get; set; }

        public int ColA { get; set; }

        public int RowB { get; set; }

        public int ColB { get; set; }
        public OpType Type { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            switch(Type){
                case OpType.Solution:{
                    bool rowColProp = ColA == RowB;
                    bool invProp = ColA == RowA ;
                    bool bProp = ColB == 1 ;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Multiplication are not achieved");
                        yield return new ValidationResult(
                            $"Col A must be equal to Row B");
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
                            $"Col A must be equal to Col B");
                    }
                    break;
                }
                case OpType.Multiplication:{
                    bool rowColProp = ColA == RowB;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Multiplication are not achieved");
                        yield return new ValidationResult(
                            $"Col A must be equal to Row B");
                    }
                    break;
                }
                case OpType.Inverse:{
                    bool rowColProp = ColA == RowA;
                    if(!rowColProp){
                        yield return new ValidationResult(
                            $"Properties for Matrix Inversion are not achieved");
                        yield return new ValidationResult(
                            $"Col A must be equal to Row A");
                    }
                    break;
                }
                case OpType.Transpose:{
                    break;
                }
            }
        }

    }
}