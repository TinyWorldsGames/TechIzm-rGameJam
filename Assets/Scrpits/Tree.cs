using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject logPrefab;
    [SerializeField] Transform[] spawnPoints;

    public void CutTree()
    {
        int randomPoint = Random.Range(0,spawnPoints.Length);

        GameObject newResources = Instantiate(logPrefab, spawnPoints[randomPoint].position, spawnPoints[randomPoint].rotation);



    }
}
