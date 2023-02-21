using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee_Horizon_FeridSpaceShip_Door_Contoller : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {
            _animator.SetBool(Trainee_Horizon_FeridSpaceShip_Constants.DOOR_ANIM, true);
            Trainee_Horizon_FeridSpaceShip_SoundManager.instance.play(Trainee_Horizon_FeridSpaceShip_Constants.DOOR_OPEN);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Trainee_Horizon_FeridSpaceShip_Mouvement>() != null)
        {
            _animator.SetBool(Trainee_Horizon_FeridSpaceShip_Constants.DOOR_ANIM, false);
            Trainee_Horizon_FeridSpaceShip_SoundManager.instance.play(Trainee_Horizon_FeridSpaceShip_Constants.DOOR_CLOSE);
        }
    }
}
