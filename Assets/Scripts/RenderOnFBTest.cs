using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RenderOnFBTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"RenderOnFB:{UniversalRenderPipeline.asset.renderOnFB}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.renderOnFB = !UniversalRenderPipeline.asset.renderOnFB;
    }
}
