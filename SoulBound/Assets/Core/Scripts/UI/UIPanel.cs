using UnityEngine;

public class UIPanel : MonoBehaviour
{
    public GameObject container;
    public virtual void Open() 
    {
        container.SetActive(true);
    }
    public virtual void Close() 
    {
        container.SetActive(true);
    }
}
