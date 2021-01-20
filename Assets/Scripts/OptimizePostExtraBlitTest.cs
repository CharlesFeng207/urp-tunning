using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OptimizePostExtraBlitTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"OptimizePostExtraBlit:{UniversalRenderPipeline.asset.optimizePostExtraBlit}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.optimizePostExtraBlit = !UniversalRenderPipeline.asset.optimizePostExtraBlit;
    }
}
