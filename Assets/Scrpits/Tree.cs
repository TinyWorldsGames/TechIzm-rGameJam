using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject logPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int health;

    


    public void CutTree()
    {
       
        int randomPoint = Random.Range(0,spawnPoints.Length);

        transform.DOShakeScale(0.15F, 1, 10, 90, true);

        GameObject newResources = Instantiate(logPrefab, spawnPoints[randomPoint].position, spawnPoints[randomPoint].rotation);

        health--;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
