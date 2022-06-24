
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class Colors : MonoBehaviour
{
    public CalculatorModule CalculatorModule;

    public Color ColorForFourOperationsActive;
    public Color ColorForFourOperationsNOTActive;
    
    public Color ColorForDotActive;
    public Color ColorForDotNOTActive;

    public Image MinusButton;
    public Image PlusButton;
    public Image DivisionButton;
    public Image MultiButton;
    public Image DotButton;
    
    public TMP_Text MinusText;
    public TMP_Text PlusText;
    public TMP_Text DivisionText;
    public TMP_Text MultiText;
    public TMP_Text DotText;

    public void ChangeColor()
    {
        WhatOperation(ColorForFourOperationsActive);
        WhatColorText(ColorForFourOperationsActive);
        
    }

    public void ChangeDotColor()
    {
        if (CalculatorModule.Dot)
        {
            DotButton.color = ColorForDotActive;
        }
        else
        {
            DotButton.color = ColorForDotNOTActive;
        }
    }
    

    public void WhatOperation(Color colors)
    {
        if (CalculatorModule._FourOperations == FourOperations.Division)
        {
            ToDefaultButtonColor(colors);
            DivisionButton.color = ColorForFourOperationsNOTActive;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Multiplication)
        {
            ToDefaultButtonColor(colors);
            MultiButton.color =ColorForFourOperationsNOTActive;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Plus)
        {
            ToDefaultButtonColor(colors);
            PlusButton.color = ColorForFourOperationsNOTActive;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Minus)
        {
            ToDefaultButtonColor(colors);
            MinusButton.color = ColorForFourOperationsNOTActive;
        }
        else if (CalculatorModule._FourOperations == FourOperations.None)
        {
            ToDefaultButtonColor(colors);
        }
    }

    public void ToDefaultButtonColor(Color colors)
    {
        DivisionButton.color = colors;
        MultiButton.color = colors;
        PlusButton.color = colors;
        MinusButton.color = colors;
    }

    public void WhatColorText(Color colors)
    {
        if (CalculatorModule._FourOperations == FourOperations.Plus)
        {
            ToDefaultTextColor();
            PlusText.color = colors;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Minus)
        {
            ToDefaultTextColor();
            MinusText.color = colors;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Division)
        {
            ToDefaultTextColor();
            DivisionText.color = colors;
        }
        else if (CalculatorModule._FourOperations == FourOperations.Multiplication)
        {
            ToDefaultTextColor();
            MultiText.color = colors;
        }
        else if(CalculatorModule._FourOperations == FourOperations.None)
        {
            ToDefaultTextColor();
        }
    }

    private void ToDefaultTextColor()
    {
        PlusText.color = ColorForFourOperationsNOTActive;
        MinusText.color = ColorForFourOperationsNOTActive;
        DivisionText.color = ColorForFourOperationsNOTActive;
        MultiText.color = ColorForFourOperationsNOTActive;
    }
}
