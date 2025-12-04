using System;
using UnityEngine;

public class ColorMain : MonoBehaviour
{
    GameObject obj;

    [SerializeField]
    private Sprite sprite;


    enum ColorType
    {
        red,
        orange,
        yellow,
        green,
        alpha
    }
    void Start()
    {
        for (int i = 1; i < 8; i++)
        {
            CreateColorObject("Square", i);
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateColorObject(string name,int ColorNum)
    {
        

        obj = new GameObject();
        obj.name = "Square";

        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        Transform tf = obj.transform;
        sr.sprite = sprite;

        switch(ColorNum)
        {
            case 1:
                sr.color = Color.red;
                tf.transform.position = new Vector3(-3,1);
                break;
            case 2:
                sr.color = Color.orange;
                tf.transform.position = new Vector3(-2, 1);

                break;
            case 3:
                sr.color = Color.yellow;
                tf.transform.position = new Vector3(-1, 1);

                break;
            case 4:
                sr.color = Color.green;
                tf.transform.position = new Vector3(0, 1);

                break;
            case 5:
                sr.color = Color.blue;
                tf.transform.position = new Vector3(1, 1);

                break;
            case 6:
                sr.color = Color.magenta;
                tf.transform.position = new Vector3(2, 1);

                break;
            case 7:
                sr.color = Color.cyan;
                tf.transform.position = new Vector3(3, 1);

                break;
            default:
                break;
        }
    }
}
