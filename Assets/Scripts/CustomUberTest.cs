using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomUberTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset Asset;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"CustomUber:{Asset.customUberPost}";
    }

    public void OnClick()
    {
        Asset.customUberPost = !Asset.customUberPost;
    }
}