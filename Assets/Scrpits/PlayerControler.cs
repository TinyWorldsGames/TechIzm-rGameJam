using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControler : MonoBehaviour
{
    public Animator _animator;

    Tree tree;

    

    private void Start()
    {
        _animator=  GetComponent<Animator>();
    }

    public void CutTree()
    {
        if (tree != null)
        {
            tree.CutTree();
        }
      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Tree>() != null)
        {

            _animator.SetBool("isCutTree", true);
            tree = collision.GetComponent<Tree>();
        }

        if (collision.GetComponent<CollactableLog>() != null)
        {
            if (!_animator.GetBool("hasLog")|| _animator.GetBool("hasColunm"))
            {
                collision.GetComponent<CollactableLog>().Collect(this);
            }
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Tree>() != null)
        {
            _animator.SetBool("isCutTree", false);
            tree = null;
        }
    }
}
