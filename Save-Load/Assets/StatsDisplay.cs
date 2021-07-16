using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsDisplay : MonoBehaviour
{
  
    public StatsObject stats;

   public int level;
   public Text levelText;
   public int health;
   public Text healthText;
   public int exp;
   public Text expText;
   public int hp,str,dex,intelligence;
  public  Text hpText,strText,dexText,intText;
    
    private void Start() {
       AssignVariables();
        UpdateDisplay();

    }

    private void Update() {
        UpdateDisplay();
    }
    
    private void AssignVariables(){
         level=stats.level;
        health=stats.health;
        exp=stats.exp;
        hp=stats.hp;
        str=stats.str;
        dex=stats.dex;
        intelligence=stats.intelligence;
    }

    private void UpdateDisplay(){
        levelText.text=level.ToString();
        healthText.text=health.ToString();
        expText.text=exp.ToString();
        hpText.text=hp.ToString();
        strText.text=str.ToString();
        dexText.text=dex.ToString();
        intText.text=intelligence.ToString();
    }

    public void InreaseValue(int i){
        
        switch(i){
            case 0 :           
                level++;           
            break;
            case 1:           
                health++;
            break;
            case 2:             
                exp++;
           break;
            case 3:           
                hp++;
           break;
            case 4:            
                str++;
           break;
            case 5:            
                dex++;
            break;
            case 6:            
                intelligence++;
           break;                 

        }

    }
    public void DecraseValue(int i){
        switch(i){
            case 0 :           
                level--;           
            break;
            case 1:           
                health--;
            break;
            case 2:             
                exp--;
           break;
            case 3:           
                hp--;
           break;
            case 4:            
                str--;
           break;
            case 5:            
                dex--;
            break;
            case 6:            
                intelligence--;
           break;                 

        }

    }



    public void SaveStats(){
        SaveSystem.SavePlayer(this);
    }

    public void LoatStats(){
        PlayerData data =SaveSystem.LoadPlayer();
        level=data.level;
        health=data.health;
        exp=data.exp;
        hp=data.hp;
        str=data.str;
        dex=data.str;
        intelligence=data.intelligence;


    }
}
