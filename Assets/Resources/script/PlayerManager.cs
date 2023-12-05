using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerManager : MonoBehaviour
{
    Animator animator;                  // PlayerのAniamtor
    Rigidbody rb;                       // PlayerのRigidbody

    void Start()
    {
        animator = GetComponent<Animator>();    // PlayerのAnimatorを取得
    }
    
    void Update()
    {
        playerAttack();
    }
    
    private void playerAttack()
    {
        if (Input.GetButtonDown("Fire1"))    //左クリックされたら
        {
            animator.SetTrigger("Attack");   // 「Attack」Triggerをonにする
        }
    }
}