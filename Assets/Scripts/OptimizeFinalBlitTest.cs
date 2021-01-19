using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OptimizeFinalBlitTest : MonoBehaviour
{
    public Text Text;

    public UniversalRenderPipelineAsset Asset;
    // Update is called once per frame
    void Update()
    {
        Text.text = $"OptimizeFinalBlit:{Asset.useFinalBlitOptimize}";
    }

    public void OnClick()
    {
        Asset.useFinalBlitOptimize = !Asset.useFinalBlitOptimize;
    }
}
