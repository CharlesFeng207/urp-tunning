using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomBloomTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"CustomBloom:{UniversalRenderPipeline.asset.customBloom}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.customBloom = !UniversalRenderPipeline.asset.customBloom;
    }
}