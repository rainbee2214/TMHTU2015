using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapon : MonoBehaviour
{
    GameObject bullet;
    GameObject b;

    int spinAttackDelay = 25;

    public List<GameObject> bullets;
    int topBullet;
    int numberOfBullets = 10;

    public float shootDelay = .1f;
    public float nextShootTime;

    GameObject weapons;
    GameObject weapon1;
    void Awake()
    {
        bullet = Resources.Load<GameObject>("Prefabs/Bullet");
        bullets = new List<GameObject>();

        weapon1 = new GameObject(name + "Weapon1");

        weapon1.transform.position = transform.position;
        weapon1.transform.eulerAngles = Vector3.zero;

        for (int i =0; i <numberOfBullets; i++)
        {
            bullets.Add(Instantiate<GameObject>(bullet));
            bullets[i].name = "Bullet" + i;
            bullets[i].transform.SetParent(weapon1.transform);
            bullets[i].SetActive(false);
        }
    }

    public void Shoot(float theta, bool isEnemyAttack)
    {
        b = bullets[topBullet];
        topBullet++;
        if (topBullet >= bullets.Count) topBullet = 0;
        b.transform.position = transform.position;
        b.gameObject.SetActive(true);
        b.GetComponent<Bullet>().Move(theta, isEnemyAttack);
    }

}
