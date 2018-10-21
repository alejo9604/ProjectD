using UnityEngine;


[RequireComponent(typeof(PlayerController))]
public class Player : StatsBase
{
    #region PRIVATE_FIELDS

    private Camera viewCamera;
    private PlayerController controller;

    #endregion

    #region PRIVATE_FUNCTIONS

    private void Awake()
    {
        viewCamera = Camera.main;
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;
        controller.Move(moveVelocity);
    }


    #endregion


}