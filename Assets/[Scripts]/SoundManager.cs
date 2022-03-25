using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Sounds
{
    public static string Bumper = "Sounds/bumper";
    public static string BottomSpring = "Sounds/bottomSpring";
    public static string Toy = "Sounds/toy";



}


public class SoundManager : MonoBehaviour
{

    private static SoundManager _instance;

    public Dictionary<string, AudioClip> _audioClips = new Dictionary<string, AudioClip>();

    private AudioSource _audioSource;


    public static SoundManager Instance
    {
        get
        {
            return _instance;
        } 
    }

    void Awake()
    {
        if (null == _instance)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        _audioSource = GetComponent<AudioSource>();
        AddSounds(Sounds.Bumper);
        AddSounds(Sounds.BottomSpring);
        AddSounds(Sounds.Toy);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        

        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddSounds(string path)
    {
        _audioClips.Add(path, Resources.Load<AudioClip>(path));
    }

    public void PlaySound(string sound, float volume = 0.4f)
    {
        _audioSource.PlayOneShot(_audioClips[sound], volume);
    }
}
