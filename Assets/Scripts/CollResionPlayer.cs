using UnityEngine;

public class CollResionPlayer : MonoBehaviour
{
    void Start()
    {
        
    }

   
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
        {
          
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//스크린 좌표를 월드 좌표로 변환 

            Debug.DrawRay(worldPos,Vector3.forward*10,Color.red,3);
            RaycastHit2D hit = Physics2D.Raycast(worldPos,Vector3.zero,10); // z축 은 000을 넣어줌 기준점을 쏨 

            if(hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
