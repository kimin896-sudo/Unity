using TMPro;
using UnityEngine;

public class StudyTest2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI tmpText;

    int result;

    public int number;

    public void OnResult()
    {

    }

    public void Number5()
    {
        result = 5;

        tmpText.text = result.ToString();
    }
    public void OnClick()
    {
        result++;
        Debug.Log($"{result}");
    }

    public void OnText()
    {
        tmpText.text = result.ToString();

    }

 
}
