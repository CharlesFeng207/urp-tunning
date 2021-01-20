using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class MemorylessTest : MonoBehaviour
{
    public Text Text;
    public UniversalRenderPipelineAsset Asset;

    // Update is called once per frame
    void Update()
    {
        Text.text = $"Memoryless:{Asset.depthBufferMemoryless}";
    }

    public void OnClick()
    {
        Asset.depthBufferMemoryless = !Asset.depthBufferMemoryless;
    }
}