using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NumberClick : MonoBehaviour
{
    enum Cal
    {
        None,
        Add,
        Sub,
        Mul,
        Div
    }
    Cal state = Cal.None;



    string firstNumber;
    string secondNumber;
    string Local_Event;

    int firstNumber_int;
    int secondNumber_int;

    public TextMeshProUGUI uiText;
    public TextMeshProUGUI secondText;
    public void OnNumberButtonClicked(string number)
    {
        // 초기값이 0 또는 + 제거
        if (uiText.text == "0"|| 
            uiText.text == "+" || 
            uiText.text == "-" ||
            uiText.text == "*" ||
            uiText.text == "/" )
        {
            uiText.text = number;
        }
        else
        {
            uiText.text += number;
        }
    }
    public void EventClick(string Event)
    {
        if (state==Cal.None) 
        {
            switch(Event)
            {
                case "+":
                    state = Cal.Add;
                    break;
                case "-":
                    state = Cal.Sub;
                    break;
                case "*":
                    state = Cal.Mul;
                    break;
                case "/":
                    state = Cal.Div;
                    break;
                    default:
                    state = Cal.None;
                    break;
            }

            firstNumber = uiText.text;
            uiText.text = "";
            uiText.text += Event;

            secondText.text = firstNumber;
        }
    }
    public void All_Delete()
    {
        state = Cal.None ;

        uiText.text = "0";
        secondText.text = "";
    }

    public void ResultClick()
    {
        Debug.Log($"{uiText.text}");
    }

    public void ResultMesod()
    {
        secondText.text = "";
        firstNumber_int = int.Parse(firstNumber);
        secondNumber = uiText.text;
        secondNumber_int = int.Parse(secondNumber);

        switch (state)
        {
            case Cal.Add:
                uiText.text = (firstNumber_int + secondNumber_int).ToString();
                break;
            case Cal.Sub:
                uiText.text = (firstNumber_int - secondNumber_int).ToString();
                break;
            case Cal.Mul:
                uiText.text = (firstNumber_int * secondNumber_int).ToString();
                break;
            case Cal.Div:
                uiText.text = (firstNumber_int / secondNumber_int).ToString();
                break;
                
        }
        state = Cal.None ;
      
    }
}


