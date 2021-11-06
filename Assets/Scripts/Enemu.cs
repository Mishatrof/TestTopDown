using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemu : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    public GameObject player;
    public GameObject sf;

    public float speed;

    private void OnTriggerEnter2D(Collider2D gg)
    {
        if(gg.tag == "Player")
        {
            transform.position = Vector2.MoveTowards(transform.position, sf.transform.position, speed * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerStay2D(Collider2D ff)
    {
        if (ff.tag == "Player")
        {
            transform.position = Vector2.MoveTowards(transform.position, sf.transform.position, speed * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
