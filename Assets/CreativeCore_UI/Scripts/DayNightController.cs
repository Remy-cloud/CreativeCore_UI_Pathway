using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public Light sunLight;

    public void SetDay()
    {
        sunLight.intensity = 1.2f;
    }

    public void SetNight()
    {
        sunLight.intensity = 0.2f;
    }
}
