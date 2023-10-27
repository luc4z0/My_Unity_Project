using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ship : MonoBehaviour
{
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.value, Random.value, 0.0f);
        
    }

    // Update is called once per frame
    void Update(){
        // Move closer to target
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, Input.mousePosition, step);
            
    }
        public void UpdateSpeed(float s){
        speed = s;
    }



}
