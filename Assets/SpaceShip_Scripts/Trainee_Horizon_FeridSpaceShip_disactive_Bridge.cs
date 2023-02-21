using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee_Horizon_FeridSpaceShip_disactive_Bridge : MonoBehaviour
{
    [SerializeField] private GameObject Bridge;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {

            Bridge.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {
            Bridge.SetActive(true);
        }

    }
}
