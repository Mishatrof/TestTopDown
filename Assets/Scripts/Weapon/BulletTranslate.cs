using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTranslate : MonoBehaviour
{
    [Range(3,35)]
    [SerializeField] private float Speed;
    [SerializeField] private float Damage;


    void Update()
    {
        transform.Translate(Vector2.right * Speed *  Time.deltaTime);
    }
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Health>())
        {
            var enemy = collision.gameObject.GetComponent<Health>();
            enemy.TakeDmg(Damage);
        }
        Destroy(gameObject);
    }
}
