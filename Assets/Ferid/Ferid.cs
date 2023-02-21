using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ferid : MonoBehaviour
{
    public UnityEngine.U2D.Animation.SpriteResolver upperAccessory;
    public UnityEngine.U2D.Animation.SpriteResolver downAccessory;
    public Animator myAnim;

    public AudioSource myAudioSource;

    public static bool isSkinChanged = false;

    bool isTalking = false;

    private float[] clipSampleData = new float[512];

    private float clipLoudness;
    private float currentUpdateTime;

    const float EPSILON = 0.0001f;

    void Awake()
    {
        ChangeMySkin(false);
    }
    private void Start()
    {
        clipSampleData = new float[512];
    }

    void ChangeMySkin(bool canPlayAnim)
    {
        //upperAccessory.SetCategoryAndLabel(Constants.UPPER_SPRITE_RESOLVER_CATEGORY, Account.GetInstance().user.upperBodyAccessoriesWeared.ToString());
        //downAccessory.SetCategoryAndLabel(Constants.DOWN_SPRITE_RESOLVER_CATEGORY, Account.GetInstance().user.downBodyAccessoriesWeared.ToString());

        //if (canPlayAnim) myAnim.Play(Constants.ANIM_FERID_NEW_CLOTHES, -1, 0);
    }

    void Update()
    {
        if (isSkinChanged)
        {
            ChangeMySkin(true);
            isSkinChanged = false;
        }

        if (isTalking)
        {
            Analyze_Speech_Data();
        }
    }

    public void Talk(AudioClip speech)
    {
        //isTalking = true;
        //myAudioSource.clip = speech;
        //currentUpdateTime = 0;
        //myAudioSource.Stop();
        //myAudioSource.clip = speech;
        //myAudioSource.Play();
    }

    void Analyze_Speech_Data()
    {
        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= 0.1f)
        {
            currentUpdateTime = 0f;
            myAudioSource.clip.GetData(clipSampleData, myAudioSource.timeSamples); //I read 512 samples
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            clipLoudness /= 512; //clipLoudness is what you are looking for

            if (clipLoudness > EPSILON)
            {
                myAnim.SetLayerWeight(1, Mathf.Lerp(myAnim.GetLayerWeight(1), 1, 200 * Time.deltaTime));
            }
            else
            {
                myAnim.SetLayerWeight(1, Mathf.Lerp(myAnim.GetLayerWeight(1), 0, 200 * Time.deltaTime));
            }
        }
    }
}
