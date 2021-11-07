using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemu : MonoBehaviour
{

    public GameObject player;

    public float speed;
    private Animator Anim;
    public float StopDistance = 1f;

    private void Start()
    {
        Anim = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        Vector2 Dist = player.transform.position - transform.position;
        Anim.SetBool("Move", true);
        if (Dist.magnitude < StopDistance)
        {
            player.GetComponent<HealthPlayer>().TakeDmg();
            Destroy(gameObject);
        }
    }
  
}
