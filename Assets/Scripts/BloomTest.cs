using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BloomTest : MonoBehaviour
{
    public Text Text;

    public Camera Camera;
    // Update is called once per frame
    void Update()
    {
        Text.text = $"Bloom:{Camera.GetUniversalAdditionalCameraData().renderPostProcessing}";
    }

    public void OnClick()
    {
        Camera.GetUniversalAdditionalCameraData().renderPostProcessing = !Camera.GetUniversalAdditionalCameraData().renderPostProcessing;
    }
}