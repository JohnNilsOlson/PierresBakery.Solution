using System;
using System.Collections.Generic;

namespace PierresBakery.Models.Breads
{
  public class Bread
  {
    public static Dictionary<int, string> breadTypes = new Dictionary<int, string>() {{1, "rye"}, {2, "sourdough"}, {3, "whole grain"}, {4, "baguette"}, {5, "ciabatta"}, {6, "challah"}, {7, "cornbread"}, {8, "banana"}, {9, "brioche"}, {10, "foccacia"}};
    public string Type { get; set; }
    public Bread()
    {
      Random rnd = new Random();
      int num  = rnd.Next(1, 10);

      if (breadTypes.ContainsKey(num))
      {
        Type = breadTypes[num];
        breadTypes.Remove(num);
      }
    }
  }
}