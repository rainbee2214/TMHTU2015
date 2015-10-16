using UnityEngine;
using System.Collections;

public class StarFieldGenerator : MonoBehaviour
{

    public GameObject stars;
    public int width = 10, height = 10;
    public Vector3 startingLocation;

    void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                GameObject s = Instantiate(stars, new Vector3(x * 10, y * 10, 1f)+startingLocation, Quaternion.identity) as GameObject;
                s.transform.SetParent(transform);
            }
        }
    }
}
