using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArithmeticInput : MonoBehaviour
{

    public TMP_InputField input;
    public TextMeshProUGUI resultText;     

    public string text;

    string plus = "+";
    string sub = "-";
    string mult = "*";
    string divi = "/";

    int num1;
    int num2;
    int[] nums;
    string[] splitText;  
    
    int result;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("space0");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            text = input.text;
            input.text = "";
            Debug.Log(text);

            splitText = text.Split();

            int.TryParse(splitText[0], out num1);
            int.TryParse(splitText[2], out num2);

            CalculateNumbers();
        
            resultText.text = result.ToString();
        }

    }

    void CalculateNumbers()
    {
        if(splitText[1] == plus)
        {
            Debug.Log(plus);
            result = num1 + num2;
        }
        else if(splitText[1] == sub)
        {
            Debug.Log(sub);
            result = num1 - num2;
        }
        else if(splitText[1] == divi)
        {
            Debug.Log(divi);
            result = num1 / num2;
        }
        else if(splitText[1] == mult)
        {
            Debug.Log(mult);
            result = num1 * num2;
        }
        else
        {
            result = 0;
            Debug.Log("no operator found!");
        }
    }
}
