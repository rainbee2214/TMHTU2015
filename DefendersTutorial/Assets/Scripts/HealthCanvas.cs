using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthCanvas : MonoBehaviour
{
    IHealth healthBar;

    void Awake()
    {
        healthBar = GetComponent<IHealth>();
    }
    void Start()
    {
        healthBar.CreateHealthCanvas();
    }
}
