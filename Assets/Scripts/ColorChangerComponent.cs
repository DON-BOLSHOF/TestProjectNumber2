using UnityEngine;
using UnityEngine.EventSystems;

public class ColorChangerComponent : MonoBehaviour
{
    [SerializeField] private Material _colorMaterial;
    
    public void ColorChange()
    {
        _colorMaterial.SetColor("_Color" ,Random.ColorHSV());
    }
}