using UnityEngine;

public class MainScript : MonoBehaviour
{
    GameObject prefab;
    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Poop");
    }

    float sum;
    void Update()
    {
        float timeRandom = Random.Range(0f, 4f);
        float prefabPosition = Random.Range(-7f, 7f);
        sum += Time.deltaTime;


        if(timeRandom <= sum)
        {
            Instantiate(prefab);

            prefab.transform.position = new Vector2 (prefabPosition, 6);

            sum = 0;
        }
    }
}
