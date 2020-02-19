using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDots : MonoBehaviour
{
    // Start is called before the first frame update
    public float coherent_velocity;
    [Range(-180f,180f)]
    public float coherent_direction;
    public int density = 10000;
    [Range(0f,1f)]
    public float coherence;
    public GameObject noisyDots;
    public GameObject coherentDots;
    

    void Start()
    {
        ParticleSystem ns;
        ParticleSystem cs;
        ns = noisyDots.GetComponent<ParticleSystem>();
        cs = coherentDots.GetComponent<ParticleSystem>();
        var nsMain = ns.main;
        var nsE = ns.emission;
        var csE = cs.emission;
        var csMain = cs.main;
        var nsS = ns.shape;
        var csS = cs.shape;
        density = 10000;
        
        nsMain.maxParticles = 2 * density;
        csMain.maxParticles = 2 * density;
        nsMain.startSpeed = 0f;
        csMain.startSpeed = coherent_velocity;

        nsE.rateOverTime = (int)(density * (1 - coherence));
        csE.rateOverTime = (int)(coherence * density);
        csS.rotation = new Vector3(0, -1*coherent_direction, 0);
    }

    // Update is called once per frame
    public void UpdateCoherentVelocity(string newVelocity )
    {
        ParticleSystem cs;
        float.TryParse(newVelocity, out coherent_velocity);
        
        cs = coherentDots.GetComponent<ParticleSystem>();
        
        
        var csMain = cs.main;
        
        
        csMain.startSpeed = coherent_velocity;

    }

    public void UpdateCoherentDirection(string newDirection)
    {
        ParticleSystem cs;
        float.TryParse(newDirection, out coherent_direction);

        cs = coherentDots.GetComponent<ParticleSystem>();


        var csS = cs.shape;


        csS.rotation = new Vector3(0, -1 * coherent_direction, 0);

    }

    public void UpdateCoherence(string newCoherence)
    {
        float.TryParse(newCoherence, out coherence);
        if (coherence > 1f)
        {
            coherence = 1f;
        }
        if(coherence < 0f)
        {
            coherence = 0f;
        }
        ParticleSystem ns;
        ParticleSystem cs;
        ns = noisyDots.GetComponent<ParticleSystem>();
        cs = coherentDots.GetComponent<ParticleSystem>();
        var nsE = ns.emission;
        var csE = cs.emission;
        nsE.rateOverTime = (int)(density * (1 - coherence));
        csE.rateOverTime = (int)(coherence * density);

    }
}
