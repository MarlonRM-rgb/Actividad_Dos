using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiHelper : MonoBehaviour
{
    public void IniciarPartida() {
    GameManager.instance.ChangeScenes("08-EscenarioJuego-01-Bosque-A"); }
    public void VolverMenuPrincipal() {
    GameManager.instance.ChangeScenes("Portada"); }
    public void CerrarAplicacion() {
    Application.Quit(); }
}
