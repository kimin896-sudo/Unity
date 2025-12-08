using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour 
{
  
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a´Ù¿î");
        }
     if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("a¾÷");
        }

    }
}
