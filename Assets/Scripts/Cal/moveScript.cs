using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.InputSystem;


public class moveScript : MonoBehaviour
{
    public GameObject target;
    public byte moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            // Time.deltaTime을 곱해서 프레임 독립적 이동
            target.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            target.transform.position -= Vector3.left * moveSpeed * Time.deltaTime;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
            target.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            target.transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }

    }
}
