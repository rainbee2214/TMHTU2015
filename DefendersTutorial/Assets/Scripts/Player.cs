using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(HealthCanvas))]
public class Player : Ship, IHealth
{
    float moveDistance;
    float rotationAngle;

    Weapon weapon;

    new void Awake()
    {
        base.Awake();
        weapon = GetComponent<Weapon>();
        MAX_HEALTH *= 10f;
        health = MAX_HEALTH;
    }

    new void Update()
    {
        base.Update();
        moveDistance = Input.GetAxisRaw("Vertical");
        rotationAngle = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Shoot")) weapon.Shoot(transform.eulerAngles.z, false);
    }

    void FixedUpdate()
    {
        if (moveDistance != 0)
        {
            movement.Move(moveDistance);
        }
        if (rotationAngle != 0)
        {
            movement.Rotate(rotationAngle);
        }
    }

    public override void Die()
    {
        base.Die();
    }
}
