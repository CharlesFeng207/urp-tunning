using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OptimizePostExtraBlitTest : MonoBehaviour
{
    public Text Text;

    public UniversalRenderPipelineAsset Asset;
    // Update is called once per frame
    void Update()
    {
        Text.text = $"OptimizePostExtraBlit:{Asset.optimizePostExtraBlit}";
    }

    public void OnClick()
    {
        Asset.optimizePostExtraBlit = !Asset.optimizePostExtraBlit;
    }
}
