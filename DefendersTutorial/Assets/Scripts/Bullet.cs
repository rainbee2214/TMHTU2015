using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Bullet : MonoBehaviour
{
    GameObject explosion;

    Vector2 direction;
    float speed = 10;

    float startTime;
    float bulletLife = 2.5f;

    Rigidbody2D rb;

    float delay = 5f;

    bool canCollide = true;

    bool enemyAttack; //because enemies don't want to attack other enemies

    Sprite defaultSprite;
    SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        defaultSprite = sr.sprite;
        rb = GetComponent<Rigidbody2D>();
        //explosion = GetComponentsInChildren<SpriteRenderer>()[1].gameObject;

    }

    public void Explode()
    {
        StopCoroutine("TurnOff");
        StartCoroutine(ExplodeRoutine());
    }

    public void Move(float theta, bool isEnemyAttack)
    {
        enemyAttack = isEnemyAttack;
        //explosion.gameObject.SetActive(false);
        rb.velocity = new Vector2(-Mathf.Sin(theta * Mathf.PI / 180), Mathf.Cos(theta * Mathf.PI / 180)) * speed;
        StartCoroutine("TurnOff");
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    IEnumerator ExplodeRoutine()
    {
        rb.velocity = Vector3.zero;
        Debug.Log("explode");
        canCollide = false;
        // play explosion
        //explosion.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        gameObject.SetActive(false);
        canCollide = true;

        //explosion.gameObject.SetActive(false);
        yield return null;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (canCollide)
        {
            if (other.tag == "Planet" && enemyAttack)
            {
                //Debug.Log("Damaging the home planet");
                IHealth ih = other.GetComponent<IHealth>();
                if (ih != null) ih.TakeDamage(5);
                Explode();
            }
            else if (other.tag == "Enemy" && !enemyAttack)
            {
                //Debug.Log("Damaging the enemy");
                IHealth ih = other.GetComponent<IHealth>();
                if (ih != null) ih.TakeDamage(3);
                //Take Damage on the enemy
                Explode();
            }
            else if (other.tag == "Player" && enemyAttack)
            {
                //Take Damage on the player
                //Debug.Log("Damaing the player");
                IHealth ih = other.GetComponent<IHealth>();
                if (ih != null) ih.TakeDamage(50f);
                Explode();
            }

            
        }
    }
}
