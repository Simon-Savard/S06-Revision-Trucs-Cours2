using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;

    void Start()
    {
        Vector3 _positionActuelle = transform.position;
        Quaternion _rotationActuelle = transform.rotation;
        Instantiate(_prefabOriginal, _positionActuelle, _rotationActuelle);
    }

}
