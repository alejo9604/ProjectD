using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour {


    #region PRIVATE_FIELDS
    [SerializeField]
    private float lifetime = 3f;
    [SerializeField]
    private float speed = 10f;
    #endregion PRIVATE_FIELDS

    #region UNITY_FUNCTIONS
    void Start () {
        Destroy(gameObject, lifetime);
    }
	
	
	void Update () {
        float moveDistance = speed * Time.deltaTime;
        CheckCollision();
        transform.Translate(Vector3.forward * moveDistance);
    }
    #endregion UNITY_FUNCTIONS


    #region PRIVATE_FUNCTIONS
    void CheckCollision()
    {

    }
    #endregion PRIVATE_FUNCTIONS
}
