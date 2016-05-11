﻿using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

    public GameObject panel;
    public Animation pauseAnimation;


    public void Pause()
    {
        panel.SetActive(true);
        pauseAnimation.Play();
        Time.timeScale = 0.0f;
    }

    public void Unpause()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(0);
        Destroy(GameObject.FindObjectOfType<GameManager>().gameObject);
    }

}
