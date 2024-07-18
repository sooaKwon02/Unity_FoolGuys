using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private Collider[] colliders;

    private readonly int fallCubes = 5;

    private void Awake()
    {
        colliders = GetComponentsInChildren<Collider>();
    }

    private void Start()
    {
        List<int> Indexs = new List<int>();

        while (Indexs.Count < fallCubes)
        {
            int randomIndex = Random.Range(0, colliders.Length);

            if (!Indexs.Contains(randomIndex))
            {
                Indexs.Add(randomIndex);
            }
        }

        foreach (int index in Indexs)
        {
            Collider collider = colliders[index].GetComponent<Collider>();

            if (collider != null)
            {
                collider.isTrigger = true;
            }

            else
            {
                Debug.Log("경고! 라인 컨트롤러에 문제가 있습니다!");
            }
        }
    }
}