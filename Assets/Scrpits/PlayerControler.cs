using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControler : MonoBehaviour
{
    public Animator _animator;

    Tree tree;
    LogPrecessing logPrecessing;
    WorkArea workArea;

    public GameObject plusStone,particularEffect, stoneColunm;

    public Transform plusEndPoint,plusStartPoint,particularEffectPoint, particularEffectPoint2;
    

    private void Start()
    {
        _animator=  GetComponent<Animator>();
    }

    public void InsantieteParticular()
    {
        Instantiate(particularEffect, particularEffectPoint.position, particularEffectPoint.rotation);
        Instantiate(particularEffect, particularEffectPoint2.position, particularEffectPoint2.rotation);
    }

    public void InsantieteColunm()
    {
        _animator.SetBool("hasColunm", true);
    }

    public void WorkArea()
    {
        workArea.insertColunm();
        _animator.SetBool("hasColunm", false);
        _animator.SetBool("isWorkArea", false);
    }


    public void CutTree()
    {
        if (tree != null)
        {
            tree.CutTree(this);
        }
       
      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Tree>() != null)
        {

            _animator.SetBool(collision.GetComponent<Tree>().animationName, true);
            
            tree = collision.GetComponent<Tree>();
        }

        if (collision.GetComponent<CollactableLog>() != null)
        {
            if (!_animator.GetBool("hasLog")|| !_animator.GetBool("hasColunm"))
            {
                collision.GetComponent<CollactableLog>().Collect(this);
            }
           
        }

        if (collision.GetComponent<StoneProcessing>()!=null)
        {
            if ( _animator.GetBool("hasColunm"))
            {
                collision.GetComponent<CollactableLog>().Collect(this);
            }
        }

        if (collision.GetComponent<LogPrecessing>() != null)
        {
            _animator.SetBool("isProcessing", true);

            logPrecessing = collision.GetComponent<LogPrecessing>();


        }

        if (collision.GetComponent<WorkArea>() != null)
        {
            workArea = collision.GetComponent<WorkArea>();
          
            _animator.SetBool("isWorkArea", true);
           

        }






    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Tree>() != null)
        {
            _animator.SetBool(collision.GetComponent<Tree>().animationName, false);
            tree = null;
        }

        if (collision.GetComponent<LogPrecessing>() != null)
        {
            _animator.SetBool("isProcessing", false);

        }
    }
}
