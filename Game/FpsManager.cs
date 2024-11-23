using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class FpsManager : MonoBehaviour {
    [SerializeField] bool vSync = true;
    [ShowIf("@vSync == false")]
    [SerializeField] int targetFps = 60;
    [SerializeField] TMP_Text fpsText;

    void Awake() {
        if(vSync) {
            Application.targetFrameRate = -1;
        } else {
            Application.targetFrameRate = targetFps;
        }
    }
    
    void Update() {
        if(fpsText != null && fpsText.isActiveAndEnabled) {
            fpsText.text = $"FPS: {1.0f / Time.deltaTime}";
        }
    }
}