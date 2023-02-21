using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class Trainee_Horizon_FeridSpaceShip_ClotheButton : MonoBehaviour
{
    [SerializeField] private Image myClothe;

    public string Label { get; set; }

    public void Set_Me(Sprite m_sprite, string label)
    {
        myClothe.sprite = m_sprite;
        this.Label = label;
    }
}