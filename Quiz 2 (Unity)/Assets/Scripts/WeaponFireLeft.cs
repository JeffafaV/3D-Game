using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFireLeft : MonoBehaviour
{
    public GameObject bulletSpawn;
    public GameObject bulletPrefab;

    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Time.timeScale == 1)
        {
            audioData.Play(0);
            Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }
    }
}
