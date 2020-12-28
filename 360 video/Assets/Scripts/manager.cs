using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class manager : MonoBehaviour
{
    VideoPlayer videoPlayer;
    bool rewind = false;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();  
    }

    public void Play()
    {
        rewind = false;
        videoPlayer.Play();
    }

    public void Pause()
    {
        rewind = false;
        videoPlayer.Pause();
    }

    public void Rewind()
    {
        rewind = true;
        videoPlayer.Pause();
    }

        public void Quit()
    {
        rewind = false;
        //return to main menu
    }

    void Update()
    {

        if (rewind == true)
        {
            videoPlayer.frame -= 2;
            Debug.Log(videoPlayer.frame);

            if (videoPlayer.frame <= 5)
            {
                rewind = false;
                videoPlayer.Play();
            }
        }
    }
}
