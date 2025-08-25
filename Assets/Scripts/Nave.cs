using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Nave : MonoBehaviour
{
    Rigidbody2D _rb;

    [SerializeField] GameObject municaoPrefab;
    [SerializeField] float xSpeed;
    
    float xDir;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movimentar();
    }
    void OnMove(InputValue inputValue)
    {
        //Extraindo apenas a componente X do mapa de ações.
        xDir = inputValue.Get<Vector2>().x;
    }
    void Movimentar()
    {
        //Modificar a velocidade no componente X
        _rb.linearVelocityX = xDir * xSpeed * Time.deltaTime; 
    }
    //Chamado pelo PlayerInput
    void OnAttack(InputValue inputValue)
    {
        Instantiate(municaoPrefab, transform.position, Quaternion.identity);
    }
    
}
