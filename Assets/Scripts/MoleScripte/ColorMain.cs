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
        for (int i = 0; i < 7; i++)
        {
            CreateColorObject("Square" + i, i);
        }
    }

    Color[] color = { Color.red, Color.orange, Color.yellow, Color.green, Color.magenta, Color.cyan,Color.aliceBlue};

    Vector3 v3 = new Vector3(-3, 1,0);
    void CreateColorObject(string name,int ColorNum)
    {
        obj = new GameObject();
        // 생성된 GameObject의 SpriteRenderer를 가져오기 
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        // 생성된 GameObject의 Transform가져오기 
        Transform tf = obj.transform;
        // sr의 sprite를 받아온 sprite로 변환하기 
        sr.sprite = sprite;

        obj.name = name;

        sr.color = color[ColorNum];
        tf.transform.position = new Vector3(v3.x + ColorNum, v3.y,0);

    }
}
