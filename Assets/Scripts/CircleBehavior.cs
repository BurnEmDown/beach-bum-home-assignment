using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleBehavior : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void SetRandomColor()
    {
        GetComponent<Image>().color = Random.ColorHSV();
    }

    public void DropAnimationTrigger()
    {
        animator.SetBool("Click", true);
    }
}
