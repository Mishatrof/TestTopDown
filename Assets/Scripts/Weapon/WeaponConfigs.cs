using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class WeaponConfigs : ScriptableObject
{
    public float Dmg;
    public float ShootTime;
    public float ReloadTime;
    public AudioClip ShootSound;
    
}
