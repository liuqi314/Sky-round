using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CameraController : MonoBehaviour
{
    [SerializeField]
    public float duration;

  


    // Update is called once per frame
    public void LookAt(Transform target)
    {
        transform.DOLookAt(target.position, duration);
    }
}
