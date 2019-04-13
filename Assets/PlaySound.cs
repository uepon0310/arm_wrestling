using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    //音声ファイル格納用変数
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound_end;

    public AudioSource AS;



    void Start()
    {
        AS = GetComponent<AudioSource>();

    }
    void Update()
    {

        //指定のキーが押されたら音声ファイルの再生をする
        if (Input.GetKeyDown(KeyCode.K))
        {
            AS.PlayOneShot(sound01);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            AS.PlayOneShot(sound02);
        }
    }

    public void Count1()
    {
        AS.PlayOneShot(sound01);
    }

    public void Count2()
    {
        AS.PlayOneShot(sound02);
    }

    public void Count3()
    {
        AS.PlayOneShot(sound03);
    }

    public void CountEnd()
    {
        AS.PlayOneShot(sound_end);
    }
}
