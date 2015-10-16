using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    #region Properties

    #endregion

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
