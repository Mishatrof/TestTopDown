using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShootSystem : MonoBehaviour , IShoot
{
    public float SpeedBullet;
    public float ShootTimeWeapon;
    public float Speed { get => SpeedBullet;  }
    public float ShootTime { get => ShootTimeWeapon;  }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"Shoot {ShootTimeWeapon}");
        }
    }
    void Update()
    {
        Shoot();
    }
}
