using System;
using System.Collections.Generic;

namespace WayPlant
{
    public class Plant
    {
        public int FoodLevel{get;set;}
        public int WaterLevel{get;set;}

        public int SunshineLevel{get;set;}
    }
    public Plant()
    {
        FoodLevel = 0;
        WaterLevel = 0;
        SunshineLevel = 0;
    }
    public  QuestionAnswered(string Letter)
    {
        if (Letter == "y")
        {
            GiveWater();
        }
        else if(Letter = "f")
        {
            GiveFood();
        }
        else if(Letter = "s")
        {
            SunshineLevel();
        }
        
        
        
    }
    private static void GiveWater()
    {
        WaterLevel+=50;
    }
    private static void GiveFood()
    {
        FoodLevel+=50;
    }
    private static void SunshineLevel()
    {
        SunshineLevel+=50;
    }
}