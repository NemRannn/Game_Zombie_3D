using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHealthBarUI : MonoBehaviour
{
    public Transform Maincamera;
   public  void LateUpdate()
    {
        transform.LookAt(transform.position + Maincamera.forward);
    } 
}
