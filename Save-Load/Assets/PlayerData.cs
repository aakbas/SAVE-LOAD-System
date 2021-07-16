using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class PlayerData 
{
    public int level;
  
    public int health;
   
   public int exp;
   
   public int hp,str,dex,intelligence;
  
  public PlayerData(StatsDisplay stats)
  {
      level=stats.level;
      health=stats.health;
      exp=stats.exp;
      hp=stats.hp;
      str=stats.str;
      dex=stats.dex;
      intelligence=stats.intelligence;
  }
    



}
