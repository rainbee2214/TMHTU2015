using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseSpaceObject : MonoBehaviour
{
    public float health;
    public float MAX_HEALTH = 10;
    protected Canvas canvas;
    protected Slider slider; //healthbarSlider
    protected GameObject healthBar;
    protected Font font;

    public void Awake()
    {
        font = Resources.Load<Font>("Font/Space");
        health = MAX_HEALTH;
        healthBar = Resources.Load<GameObject>("Prefabs/HealthBar");
    }
    public virtual void Die()
    {
        Debug.Log("Died!");
        gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
    }

    public void Update()
    {
        slider.value = health;
    }

    public void CreateHealthCanvas()
    {
        Font font = Resources.Load<Font>("Font/Space");

        canvas = new GameObject(name + "Canvas").AddComponent<Canvas>();
        canvas.transform.localScale = new Vector3(0.01f, 0.01f, 1f);
        canvas.sortingLayerName = "Player";
        canvas.gameObject.AddComponent<CanvasScaler>();
        canvas.gameObject.AddComponent<GraphicRaycaster>();

        slider = Instantiate<GameObject>(healthBar).GetComponent<Slider>();
        slider.transform.SetParent(canvas.transform, false);
        slider.maxValue = MAX_HEALTH;
        slider.minValue = 0;
        slider.wholeNumbers = true;
        slider.value = MAX_HEALTH;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    public void ResetHealth()
    {
        health = MAX_HEALTH;
    }

    public void SetHealth(float health)
    {
        this.health = health;
    }
}
