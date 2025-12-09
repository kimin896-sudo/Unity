using UnityEngine;
using UnityEngine.UI;

public class Btn_PoopAllDelete : MonoBehaviour
{
    GameObject Poop;
    Image SkillImage;
    Button btn;
    void Start()
    {

        SkillImage = GetComponent<Image>();
         btn = GetComponent<Button>();

        btn.onClick.AddListener(BtnClickAllDelete);
    }


    void Update()
    {
        if (SkillImage.fillAmount < 1)
        {
            SkillImage.fillAmount += Time.deltaTime;
            btn.interactable = false;
        }
        if (SkillImage.fillAmount >= 1)
        {
            btn.interactable = true;
        }
    }

    void BtnClickAllDelete()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Poop");

        foreach (GameObject obj in objs)
        {
            Destroy(obj);
        }
        Debug.Log("전부 삭제합니다.");

        SkillImage.fillAmount = 0;
    }
}
