using UnityEngine;
using UnityEngine.UI;

public class Btn_PoopAllDelete : MonoBehaviour
{
    GameObject Poop;
    void Start()
    {


        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(BtnClickAllDelete);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BtnClickAllDelete()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Poop");

        foreach (GameObject obj in objs)
        {
            Destroy(obj);
        }
        Debug.Log("전부 삭제합니다.");
    }
}
