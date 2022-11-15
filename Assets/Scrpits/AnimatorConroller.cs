using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorConroller : MonoBehaviour
{
    [SerializeField] JoystickPlayerExample joystickPlayer;
    [SerializeField] Animator animator;

    private void Update()
    {
        animator.SetFloat("Horizontal", joystickPlayer.move.x);
       
        animator.SetFloat("Vertical", joystickPlayer.move.y);
        
        animator.SetFloat("Speed", joystickPlayer.move.sqrMagnitude);
        

    }
}
