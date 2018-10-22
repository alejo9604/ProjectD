using UnityEngine;


[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : StatsBase
{
    #region PRIVATE_FIELDS

    private Camera viewCamera;
    private PlayerController controller;
    private GunController gunController;

    #endregion

    #region PRIVATE_FUNCTIONS

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

    }


    #endregion


}