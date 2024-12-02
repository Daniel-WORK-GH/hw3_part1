using UnityEngine;

public class CanvasCameaUpdater : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {

    }

    void Update()
    {
        canvas.worldCamera = Camera.main;
    }
}
