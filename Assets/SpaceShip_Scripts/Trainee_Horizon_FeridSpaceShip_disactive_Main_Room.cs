using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee_Horizon_FeridSpaceShip_disactive_Main_Room : MonoBehaviour
{

    [SerializeField] private GameObject MainRoom;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {
            
            MainRoom.SetActive(false);
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {
            MainRoom.SetActive(true);
        }
           
    }
}
