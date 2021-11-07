using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponShootSystem : MonoBehaviour, IShoot
{
    public float SpeedBullet;
    public float ShootTimeWeapon;
    public GameObject CurrentBullet;
    public Transform[] SpawnBullet;
    public AudioClip shootSound;
    public AudioClip clinSound;
    public AudioSource AS;

    public Slider heatWeapon;
    public Image heatWeaponimage;

    public bool Clin = false;
    float heat;
    public Image[] ImageUIInv;
    public GameObject[] allWeapons;
    public float Speed { get => SpeedBullet; }
    public float ShootTime { get => ShootTimeWeapon; }

    public GameObject Bullet => CurrentBullet;

    public Transform[] BulletSpawn => SpawnBullet;

    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    void TakeNewWeapon(int index)
    {
        for (int i = 0; i < allWeapons.Length; i++)
        {
            allWeapons[i].gameObject.SetActive(false);
            ImageUIInv[i].color = Color.gray;
        }
        allWeapons[index].gameObject.SetActive(true);
        ImageUIInv[index].color = Color.yellow ;
        SpawnBullet = allWeapons[index].GetComponent<WeapConf>().SpawnPos;
        shootSound = allWeapons[index].GetComponent<WeapConf>().ShootSound;
        heat = allWeapons[index].GetComponent<WeapConf>().currheat;
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!Clin)
            {
                if(SpawnBullet.Length == 1)
                {
                    Instantiate(Bullet, SpawnBullet[0].position, SpawnBullet[0].rotation);
                }
                else
                {
                    for (int i = 0; i < SpawnBullet.Length; i++)
                    {
                        Instantiate(Bullet, SpawnBullet[i].position, SpawnBullet[i].rotation);
                    }
                }
                AS.PlayOneShot(shootSound);
                heat += Random.RandomRange(5, 20);
                heatWeapon.value = heat;
            }
            else
            {
                AS.PlayOneShot(clinSound);
            }
        }
    }


    void Update()
    {
        Shoot();
        HeatClin();
        InputWeapon();

    }
    void InputWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TakeNewWeapon(0);
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TakeNewWeapon(1);
        }
    }
    void HeatClin()
    {
        if (!Clin)
        {
            if (heat > 0)
            {
                heatWeapon.gameObject.SetActive(true);
                heat -= 1 * Time.deltaTime * 2;
                heatWeapon.value = heat;
                if (heat > 70)
                {
                    heatWeaponimage.color = Color.red;
                }
                else
                {
                    heatWeaponimage.color = Color.white;
                }
                if (heat >= 100)
                {
                    Clin = true;
                    heat = 110;
                }
            }
            else
            {
                heatWeapon.gameObject.SetActive(false);
            }
        }
        else
        {
           
            
            heat -= 1 * Time.deltaTime * 20;
            heatWeaponimage.color = Color.red;
            heatWeapon.value = heat;
            if (heat <= 0)
            {
                {
                    Clin = false;
                }
            }
        }
    }
}

    

    

