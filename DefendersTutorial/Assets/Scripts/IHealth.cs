using UnityEngine;
using System.Collections;

public interface IHealth 
{
    void TakeDamage(float damage);

    void ResetHealth();

    void SetHealth(float health);

    void CreateHealthCanvas();
}
