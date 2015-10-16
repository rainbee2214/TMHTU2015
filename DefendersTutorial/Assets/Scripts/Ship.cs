using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Weapon))]
[RequireComponent(typeof(Movement))]
public class Ship : BaseSpaceObject
{
    public bool dead;
    public GameObject myCamera;
    Vector3 cameraPosition;
    protected Movement movement;

    public string shipName;

    public new void Awake()
    {
        base.Awake();
        myCamera = GameObject.FindGameObjectWithTag("Player1Camera");
        movement = GetComponent<Movement>();
        shipName = name;
    }

    public new void Update()
    {
        base.Update();
        if (health <= 0) Die();
        if (canvas != null) canvas.transform.position = transform.position;
        if (myCamera != null)
        {
            cameraPosition = transform.position;
            cameraPosition.z = -10f;
            myCamera.transform.position = cameraPosition;
        }
    }
}
