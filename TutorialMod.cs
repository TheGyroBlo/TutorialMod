using System;
using UnityEngine;
using CementTools;
using Femur;

// This is an example Mod class
public class TutorialMod : CementMod 
{

    private void Awake()
    {
    }
    private void Start(){

 }

    private void Update()
 {
    foreach(Actor guy in FindObjectsOfType<Actor>())
    {
        guy.primaryColor = Color.blue;
    }

 }

 


}