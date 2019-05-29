using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Animator animator;
    public int currentAnim = 0;

    public void Next()
    {
        if(currentAnim <= 2)
        {
            currentAnim++;
            animator.SetInteger("NextAnimation", currentAnim);
        }

    }

    public void Previous()
    {
        if (currentAnim != 0)
        {
            currentAnim--;
            animator.SetInteger("NextAnimation", currentAnim);
        }
    }
}
