using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Интерфейс ближнего боя
/// </summary>
public interface IMelee 
{
   float MeleeTime { get; set; }

    void Melee();
}
