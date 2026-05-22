using UnityEngine;

public class FireSlider : MonoBehaviour
{
    public ParticleSystem[] fireParticles;

    public void ChangeFire(float value)
    {
        foreach (ParticleSystem fire in fireParticles)
        {
            var main = fire.main;
            main.startSizeMultiplier = value;
        }
    }
}
