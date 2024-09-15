using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoCtrl : MonoBehaviour
{
    public Transform rawTr;
    public VideoPlayer videoPlayer;
    private float videoLength;
    private float time;

    void Start()
    {
        videoPlayer = rawTr.GetChild(0).GetComponent<VideoPlayer>();
        videoLength = (float)videoPlayer.clip.length;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= videoLength)
        {
            videoPlayer.Stop();
            videoPlayer.enabled = false;
            rawTr.GetComponent<RawImage>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            videoPlayer.Stop();
            videoPlayer.enabled = false;
            rawTr.GetComponent<RawImage>().enabled = false;
        }
    }
}
