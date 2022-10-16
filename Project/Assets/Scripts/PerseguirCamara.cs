using System.Collections;
using System.Collections.Generic; using UnityEngine;
public class PerseguirCamara : MonoBehaviour { public Transform objetivo;
public float distanciaX;
public float distanciaY;
public float distanciaZ;
void Update( ) {
// Ajusta la posición
this.transform.position = new Vector3(objetivo.position.x + distanciaX,
objetivo.position.y + distanciaY, objetivo.position.z + distanciaZ);
// Ajusta la rotación
this.transform.LookAt(objetivo); }
}