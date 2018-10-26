using UnityEngine;


[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : StatsBase
{
    #region PRIVATE_FIELDS

    private Camera viewCamera;
    private PlayerController controller;
    private GunController gunController;

    private GunBase gunToEquip;
    #endregion

    #region UNITY_FUNCTIONS
    private void Awake()
    {
        viewCamera = Camera.main;
        controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
    }

    private void Update()
    {
        //Movement input
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;
        controller.Move(moveVelocity);

        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.up * gunController.GunHeight);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            //Intersection
            Vector3 point = ray.GetPoint(rayDistance);
            controller.LookAt(point);

        }


        // Weapon input
        if (Input.GetMouseButton(0))
        {
            gunController.OnTriggerHold();
        }
        if (Input.GetMouseButtonUp(0))
        {
            gunController.OnTriggerRelease();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryToEquipGun();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //Gun to equip
        if (other.tag == "Gun" && other.GetComponent<GunBase>() != null)
        {
            gunToEquip = other.GetComponent<GunBase>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Gun" && other.GetComponent<GunBase>() != null && gunToEquip == other.GetComponent<GunBase>())
        {
            gunToEquip = null;
        }
    }
    #endregion


    #region PRIVATE_FUNCTIONS

    private void TryToEquipGun()
    {
        if (gunToEquip == null)
            return;
        if (gunToEquip.CanGrabIt(Fidvar))
        {
            GunBase nextGunToEquip = gunController.EquippedGun;
            gunController.EquipGun(gunToEquip);
            gunToEquip = nextGunToEquip;
        }
        else
        {
            Debug.Log("Not enough FIDVAR");
        }
    }


    #endregion

}