using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Animator animator;
    public int currentAnim;

    public int CurrentAnimGS
    {
        get { return currentAnim;  }
        set 
        {   
            currentAnim = value;
            if (currentAnim == 1)
                label.SetActive(true);
            else
                label.SetActive(false);
        }
    }

    private static UIManager instance;
    public GameObject label;

    public static UIManager Instance
    {
        get{ return instance; }
    }

    private void Awake()
    {
        instance = this;
        label.SetActive(false);
    }


    public void Next()
    {
        if(CurrentAnimGS <= 2)
        {
            CurrentAnimGS++;
            animator.SetInteger("NextAnimation", currentAnim);
        }

    }

    public void Previous()
    {
        if (CurrentAnimGS != 0)
        {
            CurrentAnimGS--;
            animator.SetInteger("NextAnimation", currentAnim);
        }
    }
}
