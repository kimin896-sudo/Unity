using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour 
{
    public Sprite sprite;
    GameObject obj;

    GameObject playerScript;

    private GameObject playerToDestroy;

    private void Start()
    {
        playerToDestroy = GameObject.FindGameObjectWithTag("Player");
    }



    PlayerScript player;
    float sum = 0;
    private void Update()
    {


        VecterSum();
        sum += Time.deltaTime;
        //GameObject go = GameObject.Find("Player");
       
        if (playerToDestroy != null)
        {
            //게임오브젝트에서 player 컴퍼넌트를 가져와서 player란 변수에 저장하기 
            //go.name = "CopyPlayer";

           

            if (sum > 3 && 5 > sum)
            {
                playerToDestroy.SetActive(false);
                Debug.Log("숨김");
            }
            
            if (sum > 5)
            {
                Destroy(playerToDestroy);
                Debug.Log("삭제 완료");

                // 삭제 후 참조를 null로 설정하고, Update() 실행 중지 (선택 사항)
                playerToDestroy = null;
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
