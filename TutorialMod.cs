using System;
using UnityEngine;
using CementTools;
using Femur;

// This is an example Mod class
public class TutorialMod : CementMod 
{
   bool CanSwitch = false;

    private void Awake()
    {
    
    }
    private void Start()
    {
      CanSwitch = true;
    }

    private void Update()
    {
      if(CanSwitch){
         ChangeColor();
      }
    }
    
   private void ChangeColor(){
      CanSwitch = false;
      foreach(Actor guy in FindObjectsOfType<Actor>())
    {
        // float r = UnityEngine.Random.Range(1,255);
        // float g = UnityEngine.Random.Range(1,255);
        // float b = UnityEngine.Random.Range(1,255);

        // Vector4 newColor = new Vector4(r,g,b,1);
        
        guy.primaryColor = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        guy.CostumeColor = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        
    }
    Invoke("ResetColorChange", 0.5f);
   }

   private void ResetColorChange(){
      CanSwitch = true;
   }
 }
