using System.Linq;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEditor.Rendering.Universal
{
    [VolumeComponentEditor(typeof(Bloom))]
    sealed class BloomEditor : VolumeComponentEditor
    {
        SerializedDataParameter m_Threshold;
        SerializedDataParameter m_Intensity;
        SerializedDataParameter m_Scatter;
        SerializedDataParameter m_Clamp;
        SerializedDataParameter m_Tint;
        SerializedDataParameter m_HighQualityFiltering;
        SerializedDataParameter m_DirtTexture;
        SerializedDataParameter m_DirtIntensity;
        SerializedDataParameter m_CustomBloomInterNum;
        SerializedDataParameter m_BloomWithBlurStartRatio;
        SerializedDataParameter m_BloomWithBlurEffectStart;
        SerializedDataParameter m_BloomWithBlurEffectEnd;


        public override void OnEnable()
        {
            var o = new PropertyFetcher<Bloom>(serializedObject);

            m_Threshold = Unpack(o.Find(x => x.threshold));
            m_Intensity = Unpack(o.Find(x => x.intensity));
            m_Scatter = Unpack(o.Find(x => x.scatter));
            m_Clamp = Unpack(o.Find(x => x.clamp));
            m_Tint = Unpack(o.Find(x => x.tint));
            m_HighQualityFiltering = Unpack(o.Find(x => x.highQualityFiltering));
            m_DirtTexture = Unpack(o.Find(x => x.dirtTexture));
            m_DirtIntensity = Unpack(o.Find(x => x.dirtIntensity));
            m_CustomBloomInterNum = Unpack(o.Find(x => x.customBloomInterNum));
            m_BloomWithBlurStartRatio = Unpack(o.Find(x => x.bloomWithBlurStartRatio));
            m_BloomWithBlurEffectStart = Unpack(o.Find(x => x.bloomWithBlurEffectStart));
            m_BloomWithBlurEffectEnd = Unpack(o.Find(x => x.bloomWithBlurEffectEnd));
        }

        public override void OnInspectorGUI()
        {
            if (UniversalRenderPipeline.asset?.postProcessingFeatureSet == PostProcessingFeatureSet.PostProcessingV2)
            {
                EditorGUILayout.HelpBox(UniversalRenderPipelineAssetEditor.Styles.postProcessingGlobalWarning, MessageType.Warning);
                return;
            }

            EditorGUILayout.LabelField("Bloom", EditorStyles.miniLabel);

            PropertyField(m_Threshold);
            PropertyField(m_Intensity);
            PropertyField(m_Scatter);
            PropertyField(m_Tint);
            PropertyField(m_Clamp);
            PropertyField(m_HighQualityFiltering);

            if (m_HighQualityFiltering.overrideState.boolValue && m_HighQualityFiltering.value.boolValue && CoreEditorUtils.buildTargets.Contains(GraphicsDeviceType.OpenGLES2))
                EditorGUILayout.HelpBox("High Quality Bloom isn't supported on GLES2 platforms.", MessageType.Warning);

            EditorGUILayout.LabelField("Lens Dirt", EditorStyles.miniLabel);

            PropertyField(m_DirtTexture);
            PropertyField(m_DirtIntensity);
            PropertyField(m_CustomBloomInterNum);
            PropertyField(m_BloomWithBlurStartRatio);
            PropertyField(m_BloomWithBlurEffectStart);
            PropertyField(m_BloomWithBlurEffectEnd);

        }
    }
}
