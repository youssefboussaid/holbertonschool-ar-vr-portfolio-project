using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainee_Horizon_FeridSpaceShip_Hologram : Trainee_Horizon_FeridSpaceShip_Interactable
{
    [SerializeField]
    private Trainee_Horizon_FeridSpaceShip_UIManager _UIManager;

    public override void Interact()
    {
        _UIManager.OpenCloseDictionaryPanel(false);
    }


}
