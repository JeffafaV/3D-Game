using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float maxHealth = 100;
    public float currentHealth;

    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (healthSlider)
        {
            healthSlider.value = maxHealth;
        }

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player")
        {
            healthSlider.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            currentHealth--;
            Debug.Log("Damage has been dealt");
        }

        if (collision.gameObject.tag == "Lava")
        {
            currentHealth = 0;
            Debug.Log("You fell into lava");
        }
    }
}
