using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefabs;
    [SerializeField] GameObject gun;
    [SerializeField] Animator animator;
  //[SerializeField] int damage;

    void Start()
    {
        
    }

    void Update()
    {
       // Fire();
    }
    public void Fire() { var projectile = Instantiate(projectilePrefabs, gun.transform.position, Quaternion.identity); }
}
