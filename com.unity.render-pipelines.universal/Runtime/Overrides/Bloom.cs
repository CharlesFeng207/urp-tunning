using System;

namespace UnityEngine.Rendering.Universal
{
    [Serializable, VolumeComponentMenu("Post-processing/Bloom")]
    public sealed class Bloom : VolumeComponent, IPostProcessComponent
    {
        [Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
        public MinFloatParameter threshold = new MinFloatParameter(0.95f, 0f);

        [Tooltip("Strength of the bloom filter.")]
        public MinFloatParameter intensity = new MinFloatParameter(10f, 0f);

        [Tooltip("Changes the extent of veiling effects.")]
        public ClampedFloatParameter scatter = new ClampedFloatParameter(0.5f, 0f, 1f);

        [Tooltip("Clamps pixels to control the bloom amount.")]
        public MinFloatParameter clamp = new MinFloatParameter(65472f, 0f);

        [Tooltip("Global tint of the bloom filter.")]
        public ColorParameter tint = new ColorParameter(Color.white, false, false, true);

        [Tooltip("Use bicubic sampling instead of bilinear sampling for the upsampling passes. This is slightly more expensive but helps getting smoother visuals.")]
        public BoolParameter highQualityFiltering = new BoolParameter(false);

        [Tooltip("Dirtiness texture to add smudges or dust to the bloom effect.")]
        public TextureParameter dirtTexture = new TextureParameter(null);

        [Tooltip("Amount of dirtiness.")]
        public MinFloatParameter dirtIntensity = new MinFloatParameter(0f, 0f);

        [Tooltip("When use custom bloom, control iteration count")]
        public MinIntParameter customBloomInterNum = new MinIntParameter(1, 1);

        [Tooltip("Set _BloomWithBlurStartRatio")]
        public ClampedFloatParameter bloomWithBlurStartRatio = new ClampedFloatParameter(0.47f, 0f, 0.5f);

        [Tooltip("Set _BloomWithBlurEffectStart")]
        public ClampedFloatParameter bloomWithBlurEffectStart = new ClampedFloatParameter(0.35f, 0f, 0.5f);

        [Tooltip("Set _BloomWithBlurEffectEnd")]
        public ClampedFloatParameter bloomWithBlurEffectEnd = new ClampedFloatParameter(0.43f, 0f, 0.5f);

        public bool IsActive() => intensity.value > 0f;

        public bool IsTileCompatible() => false;
    }
}
