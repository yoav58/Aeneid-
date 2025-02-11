using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider slider;
    public Agent agent;
    public States.DamageState damageState;
    public StatesLoader stl;

    public GameOverManager gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        if (stl.has_load_Health()) slider.value = stl.LoadHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // reduce the health 
    public void reduceHealth(float hitPower)
    {
        agent.transitionToOtherState(damageState, agent.currentState);
        slider.value -= hitPower;
        if (slider.value - hitPower < 0) diedAction();
    }

    public float getHealth() { return slider.value; }
    
    public void addLife(float lifeAdding)
    {
        float newVal = slider.value + lifeAdding;
        if (newVal > 100) newVal = 100;
        slider.value = newVal;
    }

    private void diedAction()
    {
        slider.value = 0;
        slider.value += 15; // since we dont want that the player will return to life with zero life
        gameOverScreen.showGameOver();
    }
}
