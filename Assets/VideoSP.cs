using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoSP : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
        player.Pause();
    }

    void Update()
    {

    }

    public void ChangeStartStop()
    {
        if (player.isPlaying)
        {
            player.Pause();
            button.image.sprite = startSprite;
        }
        else
        {
            player.Play();
            button.image.sprite = stopSprite;
        }
    }
}
