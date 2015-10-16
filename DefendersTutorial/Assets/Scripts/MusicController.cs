using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour
{
    public static MusicController controller;

    public void Awake()
    {
        if (controller == null)
        {
            controller = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (controller != this) Destroy(gameObject);
    }
}
