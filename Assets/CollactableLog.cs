using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollactableLog : MonoBehaviour
{
   
   public void Collect(PlayerControler controler)
    {
        controler._animator.SetBool("hasLog", true);
        Destroy(gameObject);
    }
}
