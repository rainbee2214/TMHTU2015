using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum ShipType
{
    Player,
    Enemy
}

[RequireComponent(typeof(Weapon))]
[RequireComponent(typeof(Movement))]
public class Ship : BaseSpaceObject
{
    protected ShipType shipType;
    public bool dead;
    public GameObject myCamera;
    Vector3 cameraPosition;
    protected Movement movement;

    public string shipName;

    public new void Awake()
    {
        base.Awake();

    }

    public void Setup(Vector2 startLocation)
    {

    }

    public new void Update()
    {
        base.Update();

    }
}
