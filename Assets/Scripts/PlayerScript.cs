using UnityEngine;
using UnityEngine.U2D;

public class PlayerScript : MonoBehaviour
{
    [Header("플레이어 스탯 ")]
    public int level = 1;
    public int hp = 100;
    public int damage = 10;

    private Sprite sprite;
    void Start()
    {
        //개인오브젝트가 이미 있을것이다 가정하고 작업 
        GameObject go = gameObject;
        SpriteRenderer sr = go.AddComponent<SpriteRenderer>();

        sprite = base.GetComponent<Sprite>();

        sr.color = Color.blue;

        Transform transform = go.GetComponent<Transform>();
        transform.position = new Vector3(5, 0,0);
        sr.sprite = sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
