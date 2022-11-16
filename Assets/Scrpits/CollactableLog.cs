using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollactableLog : MonoBehaviour
{
    [SerializeField] string animationName;

   public void Collect(PlayerControler controler)
    {
        controler._animator.SetBool(animationName, true);
        Destroy(gameObject);
    }
}
