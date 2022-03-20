using System;
using System.Linq;
using System.Collections.Generic;

namespace _19_06_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация
            System.Console.WriteLine("Give me a count and a list of numbers:");
            int count = int.Parse(Console.ReadLine());
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //Ако бройката не отговаря
            while (nums.Count != count){
                System.Console.WriteLine("Write a new list of numbers:");
                int c = int.Parse(Console.ReadLine());
                nums.Add(c);
            }
            //Разделяне
            List<int> split1 = new List<int>();
            List<int> split2 = new List<int>();
            for(var i = 0; i < nums.Count/2; i++){
                split1.Add(nums[i]);
            }
            nums.Reverse();
            for (var i = 0; i <nums.Count/2; i++){
                split2.Add(nums[i]);
            }
            int temp = 0;
            //Възходящо
            for(var i = 0; i < split1.Count -2; i++){
                for(var a = 0; a < split1.Count- 2; a++){
                    if(split1[a] > split1[a+1]){
                        temp = split1[a + 1];
                        split1[a + 1] = split1[a];
                        split1[a] = temp;
                    }
                }
            }
            //Низходящо
            for(var i = 0; i < split2.Count -1; i++){
                for(var a = 0; a < split2.Count- 1; a++){
                    if(split2[a] < split2[a+1]){
                        temp = split2[a + 1];
                        split2[a + 1] = split2[a];
                        split2[a] = temp;
                    }
                }
            }
            //Завършен вид
            System.Console.WriteLine(String.Join(" ",split1) + " " + String.Join(" ",split2));
        }
    }
}
