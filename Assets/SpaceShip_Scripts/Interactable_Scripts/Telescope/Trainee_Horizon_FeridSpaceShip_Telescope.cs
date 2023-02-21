using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trainee_Horizon_FeridSpaceShip_Telescope : Trainee_Horizon_FeridSpaceShip_Interactable
{
    [SerializeField] private Animator transition;
    public override void Interact()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(Trainee_Horizon_FeridSpaceShip_Constants.Telescope_Scene));
    }

    IEnumerator LoadLevel(string sceneName)
    {
        transition.SetTrigger(Trainee_Horizon_FeridSpaceShip_Constants.TRANSATION_ANIM);

        yield return new WaitForSeconds(1);


        SceneManager.LoadScene(sceneName);
    }
}
