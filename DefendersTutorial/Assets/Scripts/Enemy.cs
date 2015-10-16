using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : Ship, IHealth
{
    public float speed = 1f;

    float moveDistance;
    float rotationAngle;

    GameObject player;
    GameObject planet;
    Weapon weapon;

    float trackDistance = 5f, shootDistance = 5f;
    float shootDelayMin = 5f, shootDelayMax = 10f;

    new void Awake()
    {
        base.Awake();
    }

    new void Update()
    {
        base.Update();
    }

    string GetRandomName()
    {
        switch (Random.Range(0, 2))
        {
            default: return "FYU-9001";
            case 0: return "WNH-1337";
            case 1: return "CIL-9912";
        }
    }
}
