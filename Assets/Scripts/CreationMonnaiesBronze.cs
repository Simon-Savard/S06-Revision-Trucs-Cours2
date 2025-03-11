using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;

    void Start()
    {
        Vector3 _position = transform.position;
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, _position, _rotation);
    }

}
