using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float EnemySpeed = 3f;
    public Rigidbody2D e_body;
    public LayerMask OnGroundControl;
    public Transform OnGroundCheck;
    private bool E_LookRight = true;
    RaycastHit2D hit;

    private void Update()
    {
        hit = Physics2D.Raycast(OnGroundCheck.position, -transform.up, 1f, OnGroundControl);
        
    }

    private void FixedUpdate()
    {
        if (hit.collider != false)
        {
            if (E_LookRight)
            {
                e_body.velocity = new Vector2(EnemySpeed, 0f);
            }
            else
            {
                e_body.velocity = new Vector2(-EnemySpeed, 0f);
            }
        }
        else
        {
            E_LookRight = !E_LookRight;
            transform.localScale = new Vector3(-transform.localScale.x, 1f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
        {
           if(collision.CompareTag("star"))
           {
              Destroy(gameObject);
           }
        }
}
