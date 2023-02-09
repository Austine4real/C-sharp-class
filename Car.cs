using System;

namespace my_app
{
    public class Car
    {
      public string? model;  
      public string? color;  
      public int year;
      public string fullDec()
      {
        return $"{model} {color} {year}";
      }
    }
}