using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Planet : BaseSpaceObject, IHealth
{
    SpriteRenderer sr;

    new void Awake()
    {
        base.Awake();
    }

    new void Update()
    {
        base.Update();
    }

    public override void Die()
    {
        base.Die();
    }
}
