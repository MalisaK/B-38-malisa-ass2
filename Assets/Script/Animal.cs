using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //Attributes
    string name;
    public string Name 
    { 
        get 
        {
            return name; 
        } 
        set 
        { 
            name = value; 
        } 
    }
    protected string[] food = { "Meat", "Plant" };
    public int Hp = 10;
    public int Health 
    { 
        get 
        { 
            return Hp; 
        } 
        set 
        {
            Health = Hp; 
        }
    }
    private float speed = 3f;
    public float Speed 
    {
        get 
        {
            return speed; 
        } 
        private set 
        {
            Speed = speed; 
        }
    }
    private float hunger;
    //Get hunger และ Set hunger
    public float GetHunger()
    {
        return hunger;
    }
    private void SetHunger(float Hunger) 
    {
        Hunger = 0;
        hunger = Hunger;
    }
    // กิน เดิน หลับ
    public void Eat(string Food)
    {
        Debug.Log($"{Name} Eat {Food}.");
    }
    public void Move()
    {
        Debug.Log($"{Name} Move.");
    }
    public void Sleep()
    {
        Debug.Log($"{Name} Sleep.");
    }
    
}
    

