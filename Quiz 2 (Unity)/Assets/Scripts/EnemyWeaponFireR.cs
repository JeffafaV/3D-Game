using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponFireR : MonoBehaviour
{
    public GameObject bulletSpawn;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }
    }
}
