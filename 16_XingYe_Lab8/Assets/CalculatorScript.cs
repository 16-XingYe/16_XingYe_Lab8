using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public Button Convert;
    public InputField InputAmount;
    public InputField Inputtext;
    public Text Debugtext;

    float SGDUSD = 0.74f;
    float SGDJPY = 82.78f;

    public Toggle USDollar;
    public Toggle JPDollar;

    public void Converter()
    {
        Convert.onClick.AddListener(Conversion);
    }

    public void Clear()
    {
        InputAmount.text = "";
        Debugtext.text = "Debugging Text";
    }

    private void Conversion()
    {
        try
        {
            string inputvalue = InputAmount.text;
            float inputamount = float.Parse(inputvalue);

            if (USDollar.isOn)
            {
                Inputtext.text = "$" + (inputamount + SGDUSD);
            }
            else if (JPDollar.isOn)
            {
                Inputtext.text = "$" + (inputamount + SGDJPY);
            }
        }
        catch (System.FormatException)
        {
            Debugtext.text = "Invalid input. Please enter a numeric value.";
        }
    }
}
