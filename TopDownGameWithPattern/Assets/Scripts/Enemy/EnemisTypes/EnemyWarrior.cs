using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWarrior : MonoBehaviour, InterfaceEnemy
{
    [SerializeField] private Plaer _plaer;
    public int health;
    public int speed;
    public LayerMask _whatIsSolid{get;set;}
    [SerializeField] private Rigidbody2D _rb;
    public Vector3 transformPositions;
    InterfaceEnemy newenemy;
    private void Start() {
        _plaer = FindObjectOfType<Plaer>();
        
        newenemy.SetSettingsEnemy();
        Debug.Log(health);
        Debug.Log(speed);

        Destroy(gameObject, 30f);
    }
    
    private void Update() 
    {
        newenemy.movements(_plaer.transform.position, transform.position);     
    }
    
}
