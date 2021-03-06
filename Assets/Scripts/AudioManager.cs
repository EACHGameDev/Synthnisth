﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System.IO;
using System.Linq;

public class AudioManager : MonoBehaviour {
    public AudioSource sfx;
    public static AudioSource tema1;
    public static AudioSource tema2;
    public static AudioSource tema3;
    public int currentPlaying;
    public AudioClip theme1;
    public AudioClip theme2;
    public AudioClip theme3;
    public AudioClip atual;
    public AudioClip ataque;
    public AudioClip pulo;
    public AudioClip powerup;
    public AudioClip morte1;
    public AudioClip morte2;
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;
    public static AudioManager instance =null;
    
 
    void Awake () {
        if (instance = null)
        {
            //Instancia as 3 musicas ao mesmo tempo e da start na primeira
            instance = this;
            tema1.volume = 1.2f;
            tema1.Play();
            currentPlaying = 1;
            tema2.volume = 0.0f;
            tema2.Play();
            tema3.volume = 0.0f;
            tema3.Play();
        }
        else if(instance!=this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
	}

    public void playSound(string s)
    {
        //Seleciona a sfx para tocar
        if (s == "attack")
        {
            atual = ataque;
        }
        if (s == "jump")
        {
            atual =pulo;
        }
        if (s == "getPowerUp")
        {
         atual = powerup;
        }
        if (s == "die1")
        {
         atual = morte1;
        }
        if (s == "die2")
        {
            atual = morte2;
        }

        sfx.clip = atual;
        sfx.Play();
    }
    public void playTheme(int number)
    {
        if (currentPlaying == 1) {
            if (number == 1)
            {
                //Faz nada
            }
            if (number == 2)
            {
                tema1.volume = 0.0f;
                tema2.volume = 1.2f;
                tema3.volume = 0.0f;
                
            }

            if (number == 3)
            {
                tema1.volume = 0.0f;
                tema2.volume = 0.0f;
                tema3.volume = 1.2f;
            }
        }

    }
}
