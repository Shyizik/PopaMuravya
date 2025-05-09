using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator _animator;

    public bool IsMoving { private get; set;}

    public bool IsJumping { private get; set; }

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        _animator.SetBool("IsMoving", IsMoving);
    }

    public void Jump()
    {
        _animator.SetTrigger("Jump");
    }
    
}
