using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PoopScript : MonoBehaviour
{


    private Player player;

    private TMP_Text textUI;
    int typePoop;
    int speed;
    SpriteRenderer sr;
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();
        sr = gameObject.GetComponent<SpriteRenderer>();

        typePoop = Random.Range(1, 4);
        speed = Random.Range(3, 10);
        textUI = GameObject.FindGameObjectWithTag("TextUi").GetComponent<TMP_Text>();
        player = GameObject.FindAnyObjectByType<Player>();
        Debug.Log(speed);

        PoopType();

    }
   
    void Update()
    {
        
        float moveDisctance = speed * Time.deltaTime;
        gameObject.transform.position += Vector3.down* moveDisctance;


        PlayerPotisionDistance();
        MainOutPoop();

    }

    private Vector3 playerDistance;
    void PlayerPotisionDistance()
    {
        playerDistance = player.transform.position - gameObject.transform.position;

        if(playerDistance.magnitude < 1)
        {
            TextMius();
            Destroy(gameObject);
        }
    }

    void MainOutPoop()
    {
        if(gameObject.transform.position.y < -6f)
        {
            TextChange();
            Destroy(gameObject);
        }
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
            textUI.text = (int.Parse(textUI.text) + 1).ToString();

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
