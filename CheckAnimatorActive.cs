using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnimatorActive : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (animator.isActiveAndEnabled)
        {
            Debug.Log("Animator is active.");
        }
        else
        {
            Debug.Log("Animator is not active.");
        }
    }
}
