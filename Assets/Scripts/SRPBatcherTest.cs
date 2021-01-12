using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SRPBatcherTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset asset;

    // Update is called once per frame
    void Update()
    {

        Text.text = $"UseSRP:{asset.useSRPBatcher}";
    }

    public void OnClick()
    {
        asset.useSRPBatcher = !asset.useSRPBatcher;
    }
}