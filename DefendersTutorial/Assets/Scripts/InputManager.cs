using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    string levelName = "Level";

    void Update()
    {
        if (Input.GetButtonDown("StartGame"))
        {
            Application.LoadLevel(levelName);
        }
    }
}
