using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomBloomWithBlurTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset Asset;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"BloomWithBlur:{Asset.customBloomWithBlur}";
    }

    public void OnClick()
    {
        Asset.customBloomWithBlur = !Asset.customBloomWithBlur;
    }
}