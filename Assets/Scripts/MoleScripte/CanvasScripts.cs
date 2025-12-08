using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class CanvasScripts : MonoBehaviour
{

    GameObject prefab;

    GameObject ParentTransform;

    // 두더쥐
    GameObject Mole;
    Transform canvasParentTransform;

    // 그림자 위치 
    private List<Vector2> shadowPositions = new List<Vector2>();
    void Start()
    {
        // 두더쥐
        Mole = Resources.Load<GameObject>("Prefabs/Mole");

        // 하이라키에서 찾기 
        ParentTransform = GameObject.Find("Canvas");
        canvasParentTransform = ParentTransform.GetComponent<Transform>();
        for (int i = 0; i < 3; i++) // 2행 (i = 0, 1)
        {
            for (int j = 0; j < 2; j++) // 3열 (j = 0, 1, 2)
            {
                // 총 2 * 3 = 6번 호출
                ShadowCreate(i*100, j*50);
            }
        }

        CreateMole();

    }
    private void Update()
    {
        RandomMole();
    }
    void ShadowCreate(int x,int y)
    {
        prefab = Resources.Load<GameObject>("Prefabs/Shadow");

        prefab = Instantiate(prefab, canvasParentTransform);


        RectTransform rec = prefab.GetComponent<RectTransform>();
        rec.anchoredPosition = new Vector2(1+x,2+y);
        Vector2 position  = rec.anchoredPosition;

        shadowPositions.Add(position);
    }

    void CreateMole()
    {
        
            Mole = Instantiate(Mole, canvasParentTransform);
            Mole.name = "Mole";

            RandomPosition();
    }

    float sum;
    public void RandomMole()
    {
        sum += Time.deltaTime;

     
        if (sum > 1)
        {
            EventSystem.current.SetSelectedGameObject(Mole);

            Mole.SetActive(true);
            RandomPosition();
            sum = 0;
            
        }
        
    }

    public void MoleSetActive()
    {
        Mole.SetActive(false);
    }
    private void RandomPosition()
    {
        
        int randomIndex = Random.Range(0, shadowPositions.Count);
        Vector2 randomPosition = shadowPositions[randomIndex];

        Mole.GetComponent<RectTransform>().anchoredPosition = randomPosition;
    }
 
}
