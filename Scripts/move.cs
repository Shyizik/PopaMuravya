using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jump;

    public Animator animator;

    private Vector3 _input;
    private Rigidbody2D body;
    private bool _IsMoving;
    private bool _IsJumping;

    private Rigidbody2D _rigidbody;
    private ani _animations;
    [SerializeField] private SpriteRenderer _Sprite;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animations = GetComponentInChildren<ani>();
    }

    private void Update()
    {
        Move();

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown("space") && _rigidbody.velocity.y == 0f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 3f);
        }
        _animations.IsMoving = _IsMoving;

        if (_rigidbody.velocity.y > 0.1f)
        {
            animator.SetBool("IsJumping", true);
        }
        else if (_rigidbody.velocity.y == 0f)
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _IsMoving = _input.x != 0 ? true : false;

        if (_IsMoving)
        {
            _Sprite.flipX = _input.x > 0 ? false : true;
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals ("platform hor"))
        {
            this.transform.parent = collision.transform;
        }

        if (collision.gameObject.name.Equals ("platform vert1"))
        {
            this.transform.parent = collision.transform;
        }

        if (collision.gameObject.name.Equals ("platform vert"))
        {
            this.transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals ("platform hor"))
        {
            this.transform.parent = null;
        }

        if (collision.gameObject.name.Equals ("platform vert1"))
        {
            this.transform.parent = null;
        }

        if (collision.gameObject.name.Equals ("platform vert"))
        {
            this.transform.parent = null;
        }
    }
}
