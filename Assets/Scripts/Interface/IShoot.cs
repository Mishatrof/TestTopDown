using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Интерфейс стрельбы, да да, разделение интерфейса , вся хуйня, но у нас все оружки перезаряжаются , и джем всего 72 ч 
/// да пох ;)
/// </summary>
public interface IShoot 
{
    float Speed { get; set; }

    float ShootTime { get; set; }

    void Shoot();

    void Reload();
}
