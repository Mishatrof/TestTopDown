using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTranslate : MonoBehaviour
{
  
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime);
    }
}
