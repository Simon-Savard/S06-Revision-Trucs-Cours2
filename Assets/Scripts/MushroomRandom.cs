using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRandom : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _position1;
    [SerializeField] GameObject _position2;
    [SerializeField] GameObject _mushroom;


    void Start()
    {
        float nombreRandom = Random.value;
        if(nombreRandom <= 0.5f){

            _mushroom.transform.position = _position1.position;

        }else{
            _mushroom.transform.position = _position2.position;
        }
        
    }

}
