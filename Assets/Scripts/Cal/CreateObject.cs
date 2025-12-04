using UnityEngine;
using System.Collections;
public class CreateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefab;       // 생성할 프리팹
    public byte interval = 2;    // 생성 간격
    public byte fallSpeed = 2;    // 떨어지는 속도
    public byte spawnXRange = 10;  // X 랜덤 범위
    public byte spawnY = 5;       // Y 시작 높이

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // 랜덤 X 위치로 생성
            Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange, spawnXRange), spawnY, 0f);
            GameObject obj = Instantiate(prefab, spawnPos, Quaternion.identity);

            // 밑으로 떨어지는 스크립트 추가
            FallingObject fallScript = obj.AddComponent<FallingObject>();
            fallScript.speed = fallSpeed;
            fallScript.mainCamera = mainCamera;

            yield return new WaitForSeconds(interval);
        }
    }
}

// ======================================================
// 밑으로 떨어지고 화면 밖이면 삭제
public class FallingObject : MonoBehaviour
{
    public float speed = 2f;
    public Camera mainCamera;

    void Update()
    {
        // 밑으로 이동
        transform.position += Vector3.down * speed * Time.deltaTime;

        // 화면 밖이면 삭제
        Vector3 viewportPos = mainCamera.WorldToViewportPoint(transform.position);
        if (viewportPos.y < 0) // Y가 0 아래이면 삭제
        {
            Destroy(gameObject);
        }
    }
}
