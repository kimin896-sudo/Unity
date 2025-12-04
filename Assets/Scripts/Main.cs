using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour 
{
    public Sprite sprite;
    GameObject obj;

    GameObject playerScript;


    
    private void Start()
    {
    }



    PlayerScript player;
    float sum = 0;
    private void Update()
    {
        GameObject player = GameObject.Find("Player");



        VecterSum();
        sum += Time.deltaTime;
        //GameObject go = GameObject.Find("Player");
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        
        if(go!=null)
        {
            //게임오브젝트에서 player 컴퍼넌트를 가져와서 player란 변수에 저장하기 
            //go.name = "CopyPlayer";

            if (sum > 3)
            {
                player.SetActive(false);
                sum = 0;
            }
        }
    }

    void VecterSum()
    {
        GameObject Aobject = GameObject.Find("Aobject");
        Transform Aobj = Aobject.transform;

        GameObject Bobject = GameObject.Find("Bobject");
        Transform Bobj = Bobject.transform;


        Vector3 directionVector = Aobj.position - Bobj.position;

        Vector3 normalizedDirection = directionVector.normalized;

        float speed = 0.5f;
        Aobj.position -= normalizedDirection * speed * Time.deltaTime;

        Debug.Log(Aobj.position);
    }
    void CreatePlayer()
    {
        playerScript = new GameObject();
        playerScript.AddComponent<PlayerScript>();
       // playerScript.name = "RL_Plyer";

        playerScript.AddComponent<SpriteRenderer>();

        SpriteRenderer sr = playerScript.GetComponent<SpriteRenderer>();
        sr.sprite = sprite;
        sr.color = new Color(255, 0, 0);
    }
}
