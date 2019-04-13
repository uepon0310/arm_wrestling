using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManeger : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;

    public Sprite StartSprite;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite4_1;
    public Sprite Sprite4_2;
    public Sprite Sprite4_3;

    public Sprite Sprite2b;
    public Sprite Sprite3b;
    public Sprite Sprite4b;
    public Sprite Sprite4b_1;
    public Sprite Sprite4b_2;
    public Sprite Sprite4b_3;

    //public AudioClip audioClip1;
    // public AudioClip audioClip2;
    // public AudioClip audioClip3;
    // public AudioClip audioFinal;
    //private AudioSource audioSource;
    private AudioSource sound01;
    private AudioSource sound02;

    private bool sound1Flag;
    private bool sound2Flag;
    private bool sound3Flag;
    private bool soundEndFlag;

    public int armcount=0;

    public GameObject arm;
    public GameObject gamemaneger;



    // Use this for initialization
    void Start()
    {
        arm = GameObject.Find("arm");
        gamemaneger = GameObject.Find("GameManeger");
        MainSpriteRenderer =arm.GetComponent<SpriteRenderer>();
        //audioSource = gamemaneger.GetComponent<AudioSource>();
        /*        AudioSource[] audioSources = GetComponents<AudioSource>();
                sound01 = audioSources[0];
                sound02 = audioSources[1];
        */
        sound1Flag = true;
        sound2Flag = true;
        sound3Flag = true;
        soundEndFlag = true;
    }

    public void Update()
    {
        PlaySound playsound = GetComponent<PlaySound>();
        /*        if (Input.GetKeyDown(KeyCode.K))
                {
                    sound01.PlayOneShot(sound01.clip);
                }
        */
        if (armcount <= 10 & armcount >= -10)
        {
            MainSpriteRenderer.sprite = StartSprite;
        }
        else if (armcount > 10 & armcount <= 20)
        {
            MainSpriteRenderer.sprite = Sprite2;
        }
        else if (armcount > 20 & armcount <= 30)
        {
            MainSpriteRenderer.sprite = Sprite3;
        }
        else if (armcount > 30 & armcount <= 35)
        {
            MainSpriteRenderer.sprite = Sprite4;
            sound1Flag = true;
        }
        /*        else if (armcount == 31)
                {
                    if (sound1Flag == true)
                    {
                        playsound.Count1();
                        //               sound01.PlayOneShot(sound01.clip);
                        sound1Flag = false;
                        sound2Flag = true;
                        sound3Flag = true;
                        soundEndFlag = true;
                    }
                }*/
        else if (armcount > 35 & armcount <= 40)
        {
            MainSpriteRenderer.sprite = Sprite4_1;
            if (sound1Flag == true)
            {
                playsound.Count1();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = false;
                sound2Flag = true;
                sound3Flag = true;
                soundEndFlag = true;
            }
        }
        /*        else if (armcount == 36)
                {
                    if (sound2Flag == true)
                    {
                        playsound.Count2();
                        //               sound01.PlayOneShot(sound01.clip);
                        sound1Flag = true;
                        sound2Flag = false;
                        sound3Flag = true;
                        soundEndFlag = true;
                    }
                }
        */
        else if (armcount > 40 & armcount <= 45)
        {
            MainSpriteRenderer.sprite = Sprite4_2;
            if (sound2Flag == true)
            {
                playsound.Count2();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = false;
                sound3Flag = true;
                soundEndFlag = true;
            }
        }
        /*else if (armcount == 41)
        {
            if (sound3Flag == true)
            {
                playsound.Count3();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = true;
                sound3Flag = false;
                soundEndFlag = true;
            }
        }*/
        else if (armcount > 45 & armcount <= 50)
        {
            MainSpriteRenderer.sprite = Sprite4_3;
            if (sound3Flag == true)
            {
                playsound.Count3();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = true;
                sound3Flag = false;
                soundEndFlag = true;
            }
        }
                else if (armcount ==51)
                {
                    if (soundEndFlag == true)
                    {
                        playsound.CountEnd();
                        //               sound01.PlayOneShot(sound01.clip);
                        sound1Flag = true;
                        sound2Flag = true;
                        sound3Flag = true;
                        soundEndFlag = false;
                    }
                }
        else if (armcount < -10 & armcount >= -20)
        {
            MainSpriteRenderer.sprite = Sprite2b;
        }
        else if (armcount < -20 & armcount >= -30)
        {
            MainSpriteRenderer.sprite = Sprite3b;
        }
        else if (armcount < -30 & armcount >= -35)
        {
            MainSpriteRenderer.sprite = Sprite4b;
            sound1Flag = true;
        }
        else if (armcount < -35 & armcount >= -40)
        {
            MainSpriteRenderer.sprite = Sprite4b_1;
            if (sound1Flag == true)
            {
                playsound.Count1();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = false;
                sound2Flag = true;
                sound3Flag = true;
                soundEndFlag = true;
            }
        }
        else if (armcount < -40 & armcount >= -45)
        {
            MainSpriteRenderer.sprite = Sprite4b_2;
            if (sound2Flag == true)
            {
                playsound.Count2();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = false;
                sound3Flag = true;
                soundEndFlag = true;
            }
        }
        else if (armcount < -45 & armcount >= -50)
        {
            MainSpriteRenderer.sprite = Sprite4b_3;
            if (sound3Flag == true)
            {
                playsound.Count3();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = true;
                sound3Flag = false;
                soundEndFlag = true;
            }
        }
        else if (armcount == -51)
        {
            if (soundEndFlag == true)
            {
                playsound.CountEnd();
                //               sound01.PlayOneShot(sound01.clip);
                sound1Flag = true;
                sound2Flag = true;
                sound3Flag = true;
                soundEndFlag = false;
            }
        }
        else
        {
            MainSpriteRenderer.sprite = MainSpriteRenderer.sprite;
        }

    }
    public void ButtonDown1P()
    {
        armcount = armcount + 1;
        Debug.Log("armcount:" + armcount);
    }
    public void ButtonDown2P()
    {
        armcount = armcount -1;
    }

}

