using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PoopScript : MonoBehaviour
{
    bool isPlayer = false;

    private Player player;

    private TMP_Text textUI;
    int typePoop;
    int speed;
    SpriteRenderer sr;
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();

        typePoop = Random.Range(1, 4);
        speed = Random.Range(3, 10);
        textUI = GameObject.FindGameObjectWithTag("TextUi").GetComponent<TMP_Text>();

        PoopType();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 몬스터 태그 확인
        {
            isPlayer = true;
            TextMius();
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(!isPlayer)
            TextChange();
    }
    void Update()
    {
        
        float moveDisctance = speed * Time.deltaTime;
        gameObject.transform.position += Vector3.down* moveDisctance;
    }


    enum poopEnum
    {
        None,
        Nomal,
        Silver,
        Gold
    }
    void PoopType()
    {
        switch((poopEnum)typePoop)
        {
            case poopEnum.None:

                break;
            case poopEnum.Gold:
                sr.color = Color.black;
                break;
            case poopEnum.Silver:
                sr.color = Color.red;
                break;
            case poopEnum.Nomal:
                break;
            default:
                break;
        }
    }

    void TextChange()
    {

        if (textUI != null)
        {
            int damage;
            switch ((poopEnum)typePoop)
            {
                case poopEnum.None:

                    break;
                case poopEnum.Gold:
                    damage = 200;
                    textUI.text = (int.Parse(textUI.text) + damage).ToString();
                    break;
                case poopEnum.Silver:
                    damage = 50;
                    textUI.text = (int.Parse(textUI.text) + damage).ToString();
                    break;
                case poopEnum.Nomal:
                    damage = 1;
                    textUI.text = (int.Parse(textUI.text) + damage).ToString();
                    break;
                default:
                    break;
            }

        }
        else
        {
            Debug.Log("널입니다,");
        }

    }

    void TextMius()
    {
        int damage;
        switch ((poopEnum)typePoop)
        {
            case poopEnum.None:

                break;
            case poopEnum.Gold:
                damage = 200;
                textUI.text = (int.Parse(textUI.text) - damage).ToString();
                break;
            case poopEnum.Silver:
                damage = 50;
                textUI.text = (int.Parse(textUI.text) - damage).ToString();
                break;
            case poopEnum.Nomal:
                damage = 1;
                textUI.text = (int.Parse(textUI.text) - damage).ToString();
                break;
            default:
                break;
        }
    }
}
