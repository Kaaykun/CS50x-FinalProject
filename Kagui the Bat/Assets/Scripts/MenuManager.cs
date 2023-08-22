using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuManager: MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;
    private bool isMuted;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize standard volume and make sure sound is not muted when starting the apllication
        mixer.GetFloat("Volume", out value);
        volumeSlider.value = value;
        isMuted = false;
    }

    // Function to adjust volume in the menu, using a volume slider
    public void SetVolume()
    {
        mixer.SetFloat("Volume", volumeSlider.value);
    }

    // Function to mute gamesound on button click
    public void SetMute()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }

    // Function to load the game scene on button click
    public void LoadGame(int index)
    {
        SceneManager.LoadScene(index);
    }
}
