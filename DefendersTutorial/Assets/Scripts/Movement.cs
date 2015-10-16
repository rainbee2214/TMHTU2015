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

    float minX = -18f, maxX = 18f, minY = -18f, maxY = 18f;

    [HideInInspector]
    public Rigidbody2D rb2d;

    bool outOfBounds = true;

    float rotation;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    public void Move(float distance)
    {
        position = rb2d.position;

        //Add the distance to our position
        force.Set(Mathf.Sin(-rotation) * speed * Time.deltaTime * distance, Mathf.Cos(-rotation) * speed * Time.deltaTime * distance);
        position += force;
        if ((position.x != Mathf.Clamp(position.x, minX, maxX)) || (position.y != Mathf.Clamp(position.y, minY, maxY)))
        {
            position.x = Mathf.Clamp(position.x, minX, maxX);
            position.y = Mathf.Clamp(position.y, minY, maxY);
        }
        rb2d.position = position;
    }

    public void Rotate(float rotation)
    {
        Vector3 angles = transform.localEulerAngles;
        angles.z -= rotation * rotationSpeed;
        if (float.IsNaN(angles.z)) angles.z = 0f;
        transform.localEulerAngles = angles;
        EnemyRotate(transform.localEulerAngles.z);
        this.rotation = transform.localEulerAngles.z * Mathf.PI / 180f;
    }

    //The enemy is using a rigidbody to rotate because the enemy is also using
    //MoveTowards() which affects the rigidbody rotation, so let Unity manage the two happening together
    public void EnemyRotate(float angle)
    {
        if (float.IsNaN(angle)) angle = 0f;
        rb2d.MoveRotation(angle);
    }

}
