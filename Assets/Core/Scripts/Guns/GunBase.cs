using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : WeaponBase {


    #region PRIVATE_FIELDS
    [Space(20)]
    [SerializeField]
    public Transform[] projectileSpawn;
    [SerializeField]
    public ProjectileBase projectile;

    [SerializeField]
    private float msBetweenShots = 100;

    //Contrl Shoot
    float nextShotTime;

    #endregion PRIVATE_FIELDS

    
    #region FUNCTIONS
    void Shoot()
    {
        if(Time.time > nextShotTime)
        {
            nextShotTime = Time.time + msBetweenShots/100;

            for (int i = 0; i < projectileSpawn.Length; i++)
            {
                ProjectileBase newProjectile = Instantiate(projectile, projectileSpawn[i].position, projectileSpawn[i].rotation);
                //newProjectile.SetSpeed(muzzleVelocity);
            }
        }
    }
    #endregion FUNCTIONS


    #region PUBLIC_FUNCTIONS
    /// <summary>
    /// Call when player hold the trigger
    /// </summary>
    public void OnTriggerHold()
    {
        Shoot();
    }

    /// <summary>
    /// Call when player release the trigger
    /// </summary>
    public void OnTriggerRelease()
    {
        
    }
    #endregion PUBLIC_FUNCTIONS
}
