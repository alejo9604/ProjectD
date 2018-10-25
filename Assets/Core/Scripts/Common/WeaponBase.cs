using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour {

    #region PRIVATE_FIELDS
    [SerializeField]
    private float damage;
    //TODO: private Type type:
    [SerializeField]
    private float precision;

    [SerializeField]
    private Fidvar fidvarRequired;

    #endregion PRIVATE_FIELDS


    #region PUBLIC_FUNCTIONS

    public bool CanGrabIt(Fidvar other)
    {
        return other >= fidvarRequired;
    }

    #endregion PUBLIC_FUNCTIONS   

}
