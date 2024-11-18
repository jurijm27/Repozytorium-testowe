using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public PlayerController playerController;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerController.zebranePunkty.ToString(); 
    }
}
