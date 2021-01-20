using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RenderOnFBTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset Asset;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"RenderOnFB:{Asset.renderOnFB}";
    }

    public void OnClick()
    {
        Asset.renderOnFB = !Asset.renderOnFB;
    }
}
