using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDots : MonoBehaviour
{
    // Start is called before the first frame update
    public float coherent_velocity;
    [Range(-180f,180f)]
    public float coherent_direction;
    public int density;
    [Range(0f,1f)]
    public float coherence;
    public GameObject noisyDots;
    public GameObject coherentDots;
    

    void Start()
    {
        ParticleSystem ns;
        ParticleSystem cs;
        noisyDots = GameObject.Find("Background/Noise");
        coherentDots = GameObject.Find("Background/Coherent");
        ns = noisyDots.GetComponent<ParticleSystem>();
        cs = coherentDots.GetComponent<ParticleSystem>();
        var nsMain = ns.main;
        var nsE = ns.emission;
        var csE = cs.emission;
        var csMain = cs.main;
        var nsS = ns.shape;
        var csS = cs.shape;
        
        
        nsMain.maxParticles = 2 * density;
        csMain.maxParticles = 2 * density;
        nsMain.startSpeed = 0f;
        csMain.startSpeed = coherent_velocity;

        nsE.rateOverTime = (int)(density * (1 - coherence));
        csE.rateOverTime = (int)(coherence * density);
        csS.rotation = new Vector3(0, -1*coherent_direction, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem ns;
        ParticleSystem cs;
        noisyDots = GameObject.Find("Background/Noise");
        coherentDots = GameObject.Find("Background/Coherent");
        ns = noisyDots.GetComponent<ParticleSystem>();
        cs = coherentDots.GetComponent<ParticleSystem>();
        var nsMain = ns.main;
        var nsE = ns.emission;
        var csE = cs.emission;
        var csMain = cs.main;
        var nsS = ns.shape;
        var csS = cs.shape;
        nsMain.maxParticles = 2 * density;
        csMain.maxParticles = 2 * density;
        nsMain.startSpeed = 0f;
        csMain.startSpeed = coherent_velocity;

        nsE.rateOverTime = (int)(density * (1 - coherence));
        csE.rateOverTime = (int)(coherence * density);
        csS.rotation = new Vector3(0, -1*coherent_direction, 0); // -90 degrees should be right, 90 degrees should be left
    }
}
