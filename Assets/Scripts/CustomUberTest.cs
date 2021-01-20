using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomUberTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"CustomUber:{UniversalRenderPipeline.asset.customUberPost}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.customUberPost = !UniversalRenderPipeline.asset.customUberPost;
    }
}