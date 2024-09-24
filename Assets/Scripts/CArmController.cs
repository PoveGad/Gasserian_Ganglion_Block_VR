using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArmController : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator
    private float delayTime = 5f; // 10 minutos en segundos (10 * 60 = 600)

    void Start()
    {
        // Inicia la corutina que esperar� los 10 minutos antes de iniciar la animaci�n
        StartCoroutine(StartAnimationAfterDelayCoroutine());
    }

    private IEnumerator StartAnimationAfterDelayCoroutine()
    {
        // Espera el tiempo especificado (600 segundos = 10 minutos)
        yield return new WaitForSeconds(delayTime);

        // Inicia la animaci�n
        animator.SetBool("StartAnimation", true);
    }

}
