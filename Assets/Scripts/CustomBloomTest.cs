using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class CustomBloomTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset Asset;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"CustomBloom:{Asset.customBloom}";
    }

    public void OnClick()
    {
        Asset.customBloom = !Asset.customBloom;
    }
}