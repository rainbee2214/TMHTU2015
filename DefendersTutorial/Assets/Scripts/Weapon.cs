using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapon : MonoBehaviour
{
    GameObject bullet;
    GameObject b;

    int spinAttackDelay = 25;

    List<GameObject> bullets;
    int topBullet;
    int numberOfBullets = 10;

    Vector3 weapon1Position;
    public float shootDelay = .1f;
    public float nextShootTime;

    GameObject weapons;

    void Awake()
    {

    }

    public void Shoot(float theta, bool isEnemyAttack)
    {

    }

}
