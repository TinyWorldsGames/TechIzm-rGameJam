using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject logPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] int health;
    [SerializeField] bool isTree;
    public string animationName;
    


    public void CutTree(PlayerControler controler)
    {

         if(!isTree)
        {
            controler.plusStone.SetActive(true);
            controler.plusStone.transform.DOMove(controler.plusEndPoint.position, 0.225f).SetEase(Ease.Linear).OnComplete(() =>

            {
                controler.plusStone.transform.position = controler.plusStartPoint.position;


            });

        }



        transform.DOShakeScale(0.55F, 1, 10, 90, true).OnComplete(()=> 
        {
            if (isTree)
            {
                int randomPoint = Random.Range(0, spawnPoints.Length);

                GameObject newResources = Instantiate(logPrefab, spawnPoints[randomPoint].position, spawnPoints[randomPoint].rotation);

            }
           

            health--;

            if (health <= 0)
            {
                Destroy(gameObject);
            }

        });

      

    }
}
