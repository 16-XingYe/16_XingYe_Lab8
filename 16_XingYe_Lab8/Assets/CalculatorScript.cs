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
    float TaiwanDollar = 23.69f;//nice
    float won = 988.69f;
    float ringgit = 3.48f;
    float Euros = 0.69f;

    public Toggle MalaysianRingit;
    public Toggle JPYen;
    public Toggle KoreanWon;
    public Toggle TogTaiwanDollar;
    public Toggle USDollar;
    public Toggle TogEuros;

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
                Inputtext.text = "$" + (inputamount * SGDUSD);
            }
            if (JPYen.isOn)// got rid of your else if if alone is better idc yandere dev moment
            {
                Inputtext.text = "$" + (inputamount * SGDJPY);
            }
            if (TogTaiwanDollar.isOn)
            {
                Inputtext.text = "$" + (inputamount * TaiwanDollar);
            }
            if (KoreanWon.isOn)// got rid of your else if if alone is better idc yandere dev moment
            {
                Inputtext.text = "$" + (inputamount * won);
            }
            if (MalaysianRingit.isOn)// got rid of your else if if alone is better idc yandere dev moment
            {
                Inputtext.text = "$" + (inputamount * ringgit);
            }
            if (TogEuros.isOn)// got rid of your else if if alone is better idc yandere dev moment
            {
                Inputtext.text = "$" + (inputamount * Euros);
            }
        }
        catch (System.FormatException)
        {
            Debugtext.text = "Invalid input. Please enter a numeric value.";
        }
    }
}
