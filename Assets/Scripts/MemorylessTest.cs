using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class MemorylessTest : MonoBehaviour
{
    public Text Text;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"Memoryless:{UniversalRenderPipeline.asset.depthBufferMemoryless}";
    }

    public void OnClick()
    {
        UniversalRenderPipeline.asset.depthBufferMemoryless = !UniversalRenderPipeline.asset.depthBufferMemoryless;
    }
}