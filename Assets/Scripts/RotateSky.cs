using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateSky : MonoBehaviour
{
     public float RotateSpeed = 1.2f;

   
    void Update()
    {
       RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        


    }
}
