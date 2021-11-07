using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTranslate : MonoBehaviour
{
    [Range(3,15)]
    [SerializeField] private float Speed;
    void Update()
    {
        transform.Translate(transform.right * Speed *  Time.deltaTime);
    }
}
