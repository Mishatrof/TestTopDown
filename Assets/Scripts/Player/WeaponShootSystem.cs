using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShootSystem : MonoBehaviour , IShoot
{
    public float SpeedBullet;
    public float ShootTimeWeapon;
    public GameObject CurrentBullet;
    public Transform SpawnBullet;

    public float Speed { get => SpeedBullet;  }
    public float ShootTime { get => ShootTimeWeapon;  }

    public GameObject Bullet => CurrentBullet;

    public Transform BulletSpawn => SpawnBullet;

    public void Reload()
    {
        throw new System.NotImplementedException();
    }
    
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, SpawnBullet.position, transform.localRotation);
        }
    }
    void Update()
    {
        Shoot();
    }
}
