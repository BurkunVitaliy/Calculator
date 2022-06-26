using System;
using TMPro;
using UnityEngine;

public class CalculatorScripts : MonoBehaviour
{
   public CalculatorModule CalculatorModule;
   public Colors Colors;
   public TMP_Text Text;
   
   public void Click_ButtonNumber()
   {
      if (CalculatorModule._FourOperations == FourOperations.None)
      {
         Text.text = CalculatorModule.FirstNumber + CalculatorModule.FractionalNumber1 + "";
      }
      else
      { 
         Text.text = CalculatorModule.SecondNumber + CalculatorModule.FractionalNumber2  +"";
      }
   }
   
   public void Click_Button_AC()
   {
      CalculatorModule.FirstNumber = +0;
      CalculatorModule.SecondNumber = +0;
      CalculatorModule._FourOperations = FourOperations.None;
      Text.text = 0 + "";
      CalculatorModule.d = 1;
      CalculatorModule.FractionalNumber1 = 0;
      CalculatorModule.FractionalNumber2 = 0;
      CalculatorModule.Dot = false;
      Colors.ChangeDotColor();
      Colors.ChangeColor();
   }

   public void Percentage()
   {
      if (CalculatorModule._FourOperations == FourOperations.None)
      {
         double percentage = CalculatorModule.FirstNumber  / 100 ;
         //CalculatorModule.FirstNumber = percentage;
         double celaya = Math.Truncate(percentage);
         double drobnaya = percentage - Math.Truncate(percentage);
         CalculatorModule.FirstNumber = celaya;
         CalculatorModule.FractionalNumber1 = drobnaya;
         Text.text = (CalculatorModule.FirstNumber + CalculatorModule.FractionalNumber1) + "";
      }
      else
      {
         double percentage = CalculatorModule.SecondNumber  / 100 ;
         //CalculatorModule.SecondNumber = percentage;
         double celaya = Math.Truncate(percentage);
         double drobnaya = percentage - Math.Truncate(percentage);
         CalculatorModule.SecondNumber = celaya;
         CalculatorModule.FractionalNumber2 = drobnaya;
         Text.text = (CalculatorModule.SecondNumber + CalculatorModule.FractionalNumber2) + "";
      }
   }
   
   public void Click_Button_PlusMinus()
   {
      if (CalculatorModule._FourOperations == FourOperations.None)
      {
         CalculatorModule.FirstNumber = -CalculatorModule.FirstNumber;
         CalculatorModule.FractionalNumber1 = -CalculatorModule.FractionalNumber1;
         Text.text =   CalculatorModule.FirstNumber + CalculatorModule.FractionalNumber1 + "";
      }
      else
      { 
         CalculatorModule.SecondNumber = -CalculatorModule.SecondNumber;
         CalculatorModule.FractionalNumber2 = -CalculatorModule.FractionalNumber2;
         Text.text =   CalculatorModule.SecondNumber + CalculatorModule.FractionalNumber2 + "";
      }
   }

   public void Click_Dot()
   {
      CalculatorModule.Dot = !CalculatorModule.Dot;
      OnOffDotColor(CalculatorModule.Dot);
   }

   public void OnOffDotColor(bool offOn)
   {
      Colors.ChangeDotColor();
      if (offOn)
      {
         if (CalculatorModule._FourOperations == FourOperations.None && CalculatorModule.FractionalNumber1 == 0)
         {
            Text.text = CalculatorModule.FirstNumber + ".";
         }
         else if (CalculatorModule._FourOperations != FourOperations.None && CalculatorModule.FractionalNumber2 == 0)
         {
            Text.text = CalculatorModule.SecondNumber + ".";
         }
      }
      else
      {
         if (CalculatorModule._FourOperations == FourOperations.None && CalculatorModule.FractionalNumber1 == 0)
         {
            Text.text = CalculatorModule.FirstNumber + "";
         }
         else if (CalculatorModule._FourOperations != FourOperations.None && CalculatorModule.FractionalNumber2 == 0)
         {
            Text.text = CalculatorModule.SecondNumber + "";
         }
      }
   }
}
