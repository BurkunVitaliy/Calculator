using System;
using TMPro;
using UnityEngine;

public class Matematics : MonoBehaviour
{
    public TMP_Text Text;
    public CalculatorModule СalculatorModule;
    
    public void Ravno()
    {
        if (СalculatorModule._FourOperations == FourOperations.Plus)
        {
            double sumrez = Sum(СalculatorModule) ;
            MakeResultat(sumrez);
            Text.text = sumrez + "";
        }
        else if (СalculatorModule._FourOperations == FourOperations.Minus)
        {
           double minusrez = Minus(СalculatorModule);
           MakeResultat(minusrez);
           Text.text = minusrez + "";
        }
        else if (СalculatorModule._FourOperations == FourOperations.Multiplication)
        {
           double multirez =  Multiplication(СalculatorModule);
           MakeResultat(multirez);
           Text.text = multirez + "";
        }
        else if (СalculatorModule._FourOperations == FourOperations.Division)
        {
          double divirez =  Division(СalculatorModule);
          MakeResultat(divirez);
          Text.text = divirez + "";
        }
        
        if (СalculatorModule._FourOperations != FourOperations.None)
        {
            СalculatorModule.SecondNumber = 0;
            СalculatorModule.FractionalNumber2 = 0;
            СalculatorModule._FourOperations = FourOperations.None;
            СalculatorModule.Dot = false;
            СalculatorModule.CalculatorScripts.OnOffDotColor(false);
            СalculatorModule.CalculatorScripts.Colors.ChangeColor();
            
            // Что бы оно считало сколько цифвр в дробной первого числ.
            // д = 10 в степент этого колличестваа циферс
            СalculatorModule.d = 1;
        }
    }

    private void MakeResultat(double sumrez)
    {
        double celaya = Math.Truncate(sumrez);
        double drobnaya = sumrez - Math.Truncate(sumrez);
        СalculatorModule.FirstNumber = celaya;
        СalculatorModule.FractionalNumber1 = drobnaya;
    }

    private double Sum(CalculatorModule Numbers)
    {
        double sumrez = (Numbers.FirstNumber + Numbers.FractionalNumber1) +  (Numbers.SecondNumber  + Numbers.FractionalNumber2 );
        return sumrez;
    }

    private double Minus(CalculatorModule Numbers)
    {
        double minusrez = (Numbers.FirstNumber + Numbers.FractionalNumber1) - (Numbers.SecondNumber  + Numbers.FractionalNumber2 );
        return minusrez;
    }

    private double Multiplication(CalculatorModule Numbers)
    {
        double multirez = (Numbers.FirstNumber + Numbers.FractionalNumber1) * (Numbers.SecondNumber  + Numbers.FractionalNumber2 );
        return multirez;
    }

    private double Division(CalculatorModule Numbers)
    {
        double divirez = (Numbers.FirstNumber + Numbers.FractionalNumber1) / (Numbers.SecondNumber  + Numbers.FractionalNumber2 );
        return divirez;
    }
}
