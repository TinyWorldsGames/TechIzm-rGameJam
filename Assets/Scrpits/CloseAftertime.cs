using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAftertime : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3250f);
        gameObject.SetActive(false);
    }
}
