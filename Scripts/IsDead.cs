using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IsDead : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    public int hp;
    public Text hpT;
    public int hpDmg;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        hpT.text = "HP: " + hp.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            hp = hp - hpDmg;
            hpT.text = "HP: " + hp.ToString();
            if (hp <= 0)
            {
                die();
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp = hp - hpDmg;
            hpT.text = "HP: " + hp.ToString();
            if (hp <= 0)
            {
                die();
            }
        }

        if (collision.gameObject.CompareTag("fall"))
        {
                die();
        }
    }

    private void die()
    {
        anim.SetTrigger("IsDead");
        body.bodyType = RigidbodyType2D.Static;
    }

    private void RestartL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
