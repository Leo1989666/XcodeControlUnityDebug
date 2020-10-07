using iOSNativeDebug;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour
{
    public Text TxtText;

    public void Start()
    {
        TxtText.text = iOSNativeDebugFlagWrapper.GetEnableDebugFlag() == true ? "TRUE" : "FALSE";
    }
}
