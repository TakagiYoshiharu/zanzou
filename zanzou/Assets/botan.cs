using UnityEngine;

public class AfterImageSwitcher : MonoBehaviour
{
    public GameObject fastAfterImage; // ‘¬‚¢Žc‘œ
    public GameObject slowAfterImage; // ’x‚¢Žc‘œ

    public void SetFast()
    {
        fastAfterImage.SetActive(true);
        slowAfterImage.SetActive(false);
    }

    public void SetSlow()
    {
        fastAfterImage.SetActive(false);
        slowAfterImage.SetActive(true);
    }

    public void SetBoth() 
    { 
      fastAfterImage.SetActive(true);
      slowAfterImage.SetActive(true);
    }
}
