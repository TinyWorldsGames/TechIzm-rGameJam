using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControler : MonoBehaviour
{
    Animator _animator;


    private void Start()
    {
        _animator=  GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Tree>() != null)
        {
            _animator.SetBool("isCutTree", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Tree>() != null)
        {
            _animator.SetBool("isCutTree", false);
        }
    }
}
