using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherControll : MonoBehaviour
{
    public WeatherStates weatherState;

    //Sandstorm
    public ParticleSystem sandstormSystem;
    private ParticleSystem.EmissionModule sandstormEm;

    public ParticleSystem rainySystem;
    private ParticleSystem.EmissionModule rainyEm;
    //Light Intensity
    public Light Sun;
    public Light Moon;
    public float sun_curIntensity;
    public float moon_curIntensity;
    public enum WeatherStates { 
        NoWeather,
        SnowWeather,
        SunnyWeather,
        RainyWeather,
        SandstormWeather,
        WindyWeather
    }
    // Start is called before the first frame update
    void Start()
    {
        sandstormEm = sandstormSystem.emission;
        rainyEm = rainySystem.emission;
        StartCoroutine(WeatherFSM());
        weatherState = WeatherStates.NoWeather;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WeatherFSM() {
        while (true) {

            switch (weatherState) {
                case WeatherStates.NoWeather:
                    NoWeather();
                    sun_curIntensity = Sun.intensity;
                    moon_curIntensity = Moon.intensity;
                    Sun.intensity = Mathf.Lerp(sun_curIntensity, 1.25f, Time.deltaTime * 0.5f);
                    Moon.intensity = Mathf.Lerp(moon_curIntensity, 1f, Time.deltaTime * 0.5f);
                    break;
                case WeatherStates.SnowWeather:
                    SnowWeather();
                    break;
                case WeatherStates.SunnyWeather:
                    SunnyWeather();
                    break;
                case WeatherStates.RainyWeather:
                    RainyWeather();
                    sun_curIntensity = Sun.intensity;
                    moon_curIntensity= Moon.intensity;
                    Sun.intensity = Mathf.Lerp(sun_curIntensity, 0.85f, Time.deltaTime * 0.5f);
                    Moon.intensity = Mathf.Lerp(moon_curIntensity, 0.7f, Time.deltaTime * 0.5f);
                    break;
                case WeatherStates.SandstormWeather:
                    SandstormWeather();
                    sun_curIntensity = Sun.intensity;
                    moon_curIntensity = Moon.intensity;
                    Sun.intensity = Mathf.Lerp(sun_curIntensity, 0.85f, Time.deltaTime * 0.5f);
                    Moon.intensity = Mathf.Lerp(moon_curIntensity, 0.6f, Time.deltaTime * 0.5f);
                    break;
                case WeatherStates.WindyWeather:
                    WindyWeather();
                    break;
            }
            yield return null;
        }
    }
    void NoWeather() {
        sandstormEm.enabled = false;
        rainyEm.enabled = false;
        
    }

    void SnowWeather() { 

    }

    void SunnyWeather() { 
    
    }
    void RainyWeather() {
        sandstormEm.enabled = false;
        rainyEm.enabled = true;
        //Sun.intensity = 0.85f;
        
        //Moon.intensity = 0.7f;
    }
    void SandstormWeather() {
        sandstormEm.enabled = true;
        rainyEm.enabled = false;
        
        //Moon.intensity = 0.6f;

    }
    void WindyWeather() { 
    
    }
}
