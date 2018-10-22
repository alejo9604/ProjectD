using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    #region PRIVATE_FIELDS

    [SerializeField]
    private Transform weaponHold;

    #endregion

    #region PUBLIC_FIELDS

    public float GunHeight
    {
        get { return weaponHold.position.y; }
    }

    #endregion



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
