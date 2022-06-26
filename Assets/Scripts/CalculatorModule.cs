using UnityEngine;

public class CalculatorModule : MonoBehaviour
{
    public CalculatorScripts CalculatorScripts;
    
    public double FirstNumber;
    public double SecondNumber;
    public double FractionalNumber1;
    public double FractionalNumber2;
    public bool Dot;

    public FourOperations _FourOperations;
    public OtherOperations _OtherOperations;
    public double d = 1;
    
    public void _FourOperationsButtonClick(ButtonFourOperation buttonFourOperation)
    {
        _FourOperations = buttonFourOperation.FourOperations;
        Dot = false;
        CalculatorScripts.OnOffDotColor(false);
        d = 1;
    }
    public void _OtherOperationsButtonClick(ButtonOtherOperation buttonOtherOperation)
    {
        _OtherOperations = buttonOtherOperation.OtherOperations;
        if (_OtherOperations != OtherOperations.Tochka && _FourOperations != FourOperations.None)
        {
            Dot = false;
            CalculatorScripts.OnOffDotColor(false);
            d = 1;
        }
       
    }

    public void NumberButtonClick(ButtonNumber buttonNumber)
    {
        
        if (Dot)
        {
            d = d * 10;
            
            if (_FourOperations == FourOperations.None)
            {
                if(FirstNumber>=0)
                    FractionalNumber1 += buttonNumber.Number / d;
                else
                    FractionalNumber1 -= buttonNumber.Number / d;
            }
            else
            {
                if(SecondNumber>=0)
                    FractionalNumber2 += buttonNumber.Number / d;
                else
                   FractionalNumber2 -= buttonNumber.Number / d;
                
            }
        }
        else
        {
            if (_FourOperations == FourOperations.None)
            {
                AddNumberToFirstNumber(buttonNumber.Number);
            }
            else
            {
                AddNumberToSecondNumber(buttonNumber.Number);
            }   
        }
    }
    
    private void AddNumberToFirstNumber(int number)
    {
        FirstNumber *= 10;
        
        if(FirstNumber >=0)
            FirstNumber += number;
        else
            FirstNumber -= number;
    }
    
    private void AddNumberToSecondNumber(int number)
    {
        SecondNumber *= 10;
        if(SecondNumber >=0)
            SecondNumber += number;
        else
            SecondNumber -= number;
    }
}