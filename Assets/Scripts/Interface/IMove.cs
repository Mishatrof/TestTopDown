using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Интерфейс передвижения
/// </summary>
public interface IMove 
{
    float Speed { get; set; }
    void Move(float h, float v);
    
}
