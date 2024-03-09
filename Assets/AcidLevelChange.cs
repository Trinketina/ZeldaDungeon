using Gamekit3D;
using Gamekit3D.GameCommands;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AcidLevelChange : MonoBehaviour
{
    public float acidLevel;
    public bool isThisAcidLevel;
    public GameObject acid;


    private Vector3 acidVector;
    // Start is called before the first frame update
    void Start()
    {
        acidVector = new Vector3(acid.transform.position.x, acidLevel, acid.transform.position.z);
    }

// Update is called once per frame
void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            acid.transform.position = acidVector;
        }
    }
}
