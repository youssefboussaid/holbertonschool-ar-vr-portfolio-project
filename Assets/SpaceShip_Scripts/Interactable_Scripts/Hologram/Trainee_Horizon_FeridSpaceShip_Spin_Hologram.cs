using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee_Horizon_FeridSpaceShip_Spin_Hologram : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;


    void Update()
    {
        transform.Rotate(_rotate * Time.deltaTime * _speed);
    }
}
