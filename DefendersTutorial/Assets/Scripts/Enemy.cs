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
        shipName = GetRandomName();
        player = GameObject.FindObjectOfType<Player>().gameObject;
        planet = GameObject.FindObjectOfType<Planet>().gameObject;
    }

    new void Update()
    {
        base.Update();
        if (dead) return;

        if (Vector3.Distance(player.transform.position, transform.position) > trackDistance)
        {
            //Going towards planet
            transform.position = Vector3.MoveTowards(transform.position, planet.transform.position, speed * Time.deltaTime);
            Vector3 v = planet.transform.position - transform.position;

            if (planet.transform.position.y - transform.position.y < 0)
            {
                movement.EnemyRotate(-Mathf.Atan(v.x / v.y) * 180 / Mathf.PI - 180f);
            }
            else
            {
                movement.EnemyRotate(-Mathf.Atan(v.x / v.y) * 180 / Mathf.PI);
            }
        }
        else
        {
            //Going towards player
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            Vector3 v = player.transform.position - transform.position;
            if (player.transform.position.y - transform.position.y < 0)
            {
                movement.EnemyRotate(-Mathf.Atan(v.x / v.y) * 180 / Mathf.PI - 180f);
            }
            else
            {
                movement.EnemyRotate(-Mathf.Atan(v.x / v.y) * 180 / Mathf.PI);
            }
        }
        //if (Vector3.Distance(player.transform.position, transform.position) > shootDistance)
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
