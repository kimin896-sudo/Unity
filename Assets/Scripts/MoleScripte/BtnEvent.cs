using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BtnEvent : MonoBehaviour
{
    private CanvasScripts canvasScripts;

    private Button buttonComponent; // 버튼 컴포넌트를 저장할 변수 추가

    void Start()
    {

        // 1. 캔버스 스크립트 안전하게 찾기
        GameObject canvasObject = GameObject.Find("Canvas");

        if (canvasObject != null)
        {
            canvasScripts = canvasObject.GetComponent<CanvasScripts>();
        }

        if (canvasScripts == null)
        {
            Debug.LogError("Error: Canvas 오브젝트를 찾았지만 CanvasScripts 컴포넌트가 없습니다.");
            // 오류가 발생했으므로 여기서 함수 실행을 중단합니다.
            enabled = false;
            return;
        }

        // 2. 버튼 컴포넌트 안전하게 가져오기
        buttonComponent = gameObject.GetComponent<Button>();

        if (buttonComponent != null)
        {
            // 3. AddListener 연결
            buttonComponent.onClick.AddListener(ClickMe);
        }
        else
        {
            Debug.LogError("Error: 이 오브젝트에 Button 컴포넌트가 없습니다. AddListener를 실행할 수 없습니다.");
            enabled = false;
        }
    }

    void ClickMe()
    {
        // canvasScripts가 null이 아닐 때만 호출 (Start에서 이미 체크했으므로 안전)
        canvasScripts.RandomMole();
        canvasScripts.MoleSetActive();
        Debug.Log("클릭");
    }
}
