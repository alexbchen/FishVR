using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_stripes : MonoBehaviour
{
    public float speed = 0.01f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;
        rend.material.SetFloat("_Offset", offset);
    }
}
