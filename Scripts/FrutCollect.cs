using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrutCollect : MonoBehaviour
{
    private int PointCounter = 0;
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] private Text Fruits;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fruit"))
        {
            PointCounter++;
            Destroy(collision.gameObject);
            Fruits.text = "Fruits : " + PointCounter;
        }
    }
}
