using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    float moveDistance;
    private void Start()
    {
    }



   
    private void Update()
    {
        Vector3 moveDirectio = Vector3.zero;

        moveDistance = speed * Time.deltaTime;

   
        if (Input.GetKey(KeyCode.A))
        {
            moveDirectio += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirectio += Vector3.right;
        }
      

        gameObject.transform.position += moveDirectio.normalized*moveDistance;
    }
}
