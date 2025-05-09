using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallThrow : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float FireSpeed = 05f;
    private float LifeTime;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = transform.right * FireSpeed;
    }
}
