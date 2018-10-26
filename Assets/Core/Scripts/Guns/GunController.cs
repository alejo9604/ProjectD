using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    #region PRIVATE_FIELDS

    [SerializeField]
    private Transform weaponHold;
    [SerializeField]
    private GunBase equippedGun;

    #endregion

    #region PUBLIC_FIELDS

    public GunBase EquippedGun
    {
        get
        {
            return equippedGun;
        }
    }

    public float GunHeight
    {
        get { return weaponHold.position.y; }
    }

    #endregion

    #region PUBLIC_FUNCTIONS
    public void EquipGun(GunBase gunToEquip)
    {
        if(equippedGun != null)
        {
            //TODO: Move the logic to GunBase script?
            //----------------------------------------------------------------
            equippedGun.transform.parent = gunToEquip.transform.parent;
            equippedGun.transform.position = gunToEquip.transform.position;
            //----------------------------------------------------------------
        }

        equippedGun = gunToEquip;
        //TODO: Move the logic to GunBase script?
        //----------------------------------------------------------------
        equippedGun.transform.parent = weaponHold;
        equippedGun.transform.localPosition = Vector3.zero;
        equippedGun.transform.localEulerAngles= Vector3.zero;
        //----------------------------------------------------------------
    }

    public void OnTriggerHold()
    {
        if (equippedGun != null)
            equippedGun.OnTriggerHold();
    }

    public void OnTriggerRelease()
    {
        if (equippedGun != null)
            equippedGun.OnTriggerRelease();
    }

    #endregion PUBLIC_FUNCTIONS

}
