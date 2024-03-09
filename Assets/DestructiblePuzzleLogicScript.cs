using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestructiblePuzzleLogicScript : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPuzzle()
    {
        GameObject puzzleObject = GameObject.FindGameObjectWithTag("DestructiblePuzzlePrefab");
        Vector3 puzzlePosition = puzzleObject.transform.position;
        Debug.Log("reset puzzle");
        Destroy(puzzleObject);
        Instantiate(prefab, puzzlePosition, new Quaternion());
    }
}
