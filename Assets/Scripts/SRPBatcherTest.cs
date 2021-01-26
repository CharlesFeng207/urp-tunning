using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SRPBatcherTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"UseSRP:{UniversalRenderPipeline.asset.useSRPBatcher}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.useSRPBatcher = !UniversalRenderPipeline.asset.useSRPBatcher;
    }
}