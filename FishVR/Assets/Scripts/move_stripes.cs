using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_stripes : MonoBehaviour
{
    float speed;
    float direction;
    public GameObject obj;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = obj.GetComponent<Renderer>();
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;
        rend.material.SetFloat("_Offset", offset);
    }
    public void UpdateVelocity(string newVelocity)
    {
        float.TryParse(newVelocity, out speed);
    }

    public void UpdateDirection(string newDirection)
    {
        float.TryParse(newDirection, out direction);
        if (direction > 1f)
        {
            direction = 1f;
        }
        if (direction < 0f)
        {
            direction = 0f;
        }
        rend.material.SetFloat("_Direction", direction);
    }
}
