using System.Runtime.InteropServices;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{


    Player player;

    [SerializeField]
    float speed = 0.3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindAnyObjectByType<Player>();
    }
    // Update is called once per frame
    void Update()
    {
        float moveDistance = speed * Time.deltaTime;

        Vector3 monsterDistance = player.transform.position - gameObject.transform.position;

        if (monsterDistance.magnitude < 1)
            Destroy(gameObject);


        gameObject.transform.position -= monsterDistance.normalized * moveDistance;
    }
}
