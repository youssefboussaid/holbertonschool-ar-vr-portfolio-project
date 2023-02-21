using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UI;

public class Trainee_Horizon_FeridSpaceShip_ChangeClothes_Panel : MonoBehaviour
{


    public GameObject btn;


    [Header("Sprites Resolver")]
    [SerializeField]
    private SpriteLibrary spritelibrary = default;
    [SerializeField]
    private SpriteResolver targetResolveUpper;
    [SerializeField]
    private SpriteResolver targetResolveLower;


    [Header("Clothe Properties")]
    [SerializeField]
    private string upperCategorie;
    [SerializeField]
    private string lowerCategorie;
    public Transform upperParent;
    public Transform lowerParent;

    [SerializeField]
    private Sprite _emptySprite;

    private SpriteLibraryAsset LibraryAsset => spritelibrary.spriteLibraryAsset;

    void Start()
    {

        GenarateButtons(targetResolveUpper, upperCategorie, upperParent);
        GenarateButtons(targetResolveLower, lowerCategorie, lowerParent);
    }

    private void GenarateButtons(SpriteResolver spriteResolver ,string catogory,Transform parent)
    {
        string[] labels = LibraryAsset.GetCategoryLabelNames(catogory).ToArray();

        for (int i = 0; i < labels.Length; i++)
        {
            GameObject newBtn = Instantiate(btn, parent);
            Trainee_Horizon_FeridSpaceShip_ClotheButton myCloth = newBtn.GetComponent<Trainee_Horizon_FeridSpaceShip_ClotheButton>();
            if (LibraryAsset.GetSprite(catogory, labels[i]) == null)
            {
                myCloth.Set_Me(_emptySprite, labels[i]);
            }
            else
            {
                myCloth.Set_Me(LibraryAsset.GetSprite(catogory, labels[i]), labels[i]);
            }
            
            newBtn.GetComponent<Button>().onClick.AddListener(delegate { Change(catogory,myCloth.Label, spriteResolver); });
        }
    }



    public void Change(string category,string label, SpriteResolver spriteResolver)
    {
        spriteResolver.SetCategoryAndLabel(category, label);
    }


}
