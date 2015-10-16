using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(HealthCanvas))]
public class Player : Ship, IHealth
{
    float moveDistance;
    float rotationAngle;

    Weapon weapon;

    new void Awake()
    {
        base.Awake();
    }

    new void Update()
    {
        base.Update();
    }

    void FixedUpdate()
    {

    }
    public override void Die()
    {
        base.Die();
    }
}
