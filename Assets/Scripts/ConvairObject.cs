using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvairObject : MonoBehaviour
{
    float x = 8.5f;
    void Update()
    {
        transform.position += (Vector3.right * Time.deltaTime);
        if(transform.position.x >= x)
        {
            Managers.Game.presents.Add(GetComponent<SelectPresent>().present);
            Managers.Sound.SoundPlay("Warning");
            Destroy(gameObject);
        }
    }
}
