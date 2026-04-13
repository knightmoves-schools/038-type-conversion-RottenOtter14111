﻿namespace knightmoves;

public class Converter{
      public static int ConvertToInt(string input){
         return int.Parse(input);
      }
      public static string ConvertToString(int input){
         return input.ToString();
      }

      public decimal ConvertImplicitly(int input){
         decimal result = input;
         return result;
      }

      public int ConvertExplicitly(decimal input){
         return (int)input;
      }
}