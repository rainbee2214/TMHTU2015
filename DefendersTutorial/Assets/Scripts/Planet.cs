using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Planet : BaseSpaceObject, IHealth
{
    SpriteRenderer sr;

    new void Awake()
    {
        base.Awake();
        sr = gameObject.AddComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>("Sprites/Planets/Planet"+Random.Range(1,10));
        gameObject.AddComponent<CircleCollider2D>();
        sr.sortingOrder = 1;
        MAX_HEALTH *= 100f;
        health = MAX_HEALTH;
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
