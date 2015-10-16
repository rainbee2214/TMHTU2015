using UnityEngine;
using System.Collections;

/// <summary>
/// Will move a rigidbody 2d in a forward/backward and rotational motion
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 3f;
    Vector2 position;
    Vector2 force;

    float minX= -18f, maxX = 18f, minY = -18f, maxY = 18f;
    [HideInInspector]
    public Rigidbody2D rb2d;

    bool outOfBounds = true;

    float rotation;

    void Awake()
    {
    }


    public void Move(float distance)
    {
    }

    public void Rotate(float rotation)
    {
       
    }

    //The enemy is using a rigidbody to rotate because the enemy is also using
    //MoveTowards() which affects the rigidbody rotation, so let Unity manage the two happening together
    public void EnemyRotate(float angle)
    {
    }

}
