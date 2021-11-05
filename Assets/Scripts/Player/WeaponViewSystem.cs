using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponViewSystem : MonoBehaviour
{
    public Transform TargetAimTransform;

    private void Update()
    {
        ViewTo();
    }
    void ViewTo()
    {
        Vector3 Dir = (GetPositionMouse() - transform.position).normalized;
        float angle = Mathf.Atan2(Dir.y, Dir.x) * Mathf.Rad2Deg;
        TargetAimTransform.eulerAngles = new Vector3(0, 0, angle);
    }
    Vector3 GetPositionMouse()
    {
        Vector3 PosMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        PosMouse.z = 0;
        return PosMouse;
    }
}
