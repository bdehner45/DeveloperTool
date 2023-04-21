using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ContinueGame : MonoBehaviour
{
    [SerializeField] private AudioSource _deathSound;



    public void Start()
    {
        AudioSource newSound = Instantiate(_deathSound, transform.position, Quaternion.identity);
        Cursor.visible = true;
    }

    
}
