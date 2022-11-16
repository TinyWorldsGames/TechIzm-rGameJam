using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkArea : MonoBehaviour
{
    [SerializeField] Transform colunmPoint;
    [SerializeField] GameObject colunm;
   public void insertColunm()
    {
        Instantiate(colunm, colunmPoint.position, colunmPoint.rotation);

        Destroy(gameObject);
    }
}
