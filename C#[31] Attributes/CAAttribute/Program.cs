using System;
using System.Collections.Generic;
using System.Reflection;

namespace CAAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player{Name="Slah",BallControll=9,Drilling=20,Power=95,Spped=100,Passing=4},
                new Player{Name="Nimar",BallControll=6,Drilling=15,Power=85,Spped=80,Passing=2},
                new Player{Name="Missi",BallControll=5,Drilling=10,Power=75,Spped=60,Passing=3},
                new Player{Name="Nimar",BallControll=4,Drilling=5,Power=65,Spped=50,Passing=2},
            };
            var errors = new List<Error>();

            foreach (var player in players)
            {
                var properties = player.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    var skillAttribute = prop.GetCustomAttribute<SkillAttribute>();
                    if (skillAttribute is not null)
                    {
                        var value = prop.GetValue(player);
                        if (!skillAttribute.IsValid(value))
                        {
                            errors.Add(new Error(prop.Name , $"Invalid Value Accepted Range is {skillAttribute.Minimum}-{skillAttribute.Maxmum}"));
                        }
                    }
                }

            }
                if (errors.Count > 0)
                {
                    foreach (var e in errors)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("players info is valid");
                }


            Console.ReadKey();
        }
    }

    public class Player
    {
        public string Name { get; set; }

        [Skill(nameof(BallControll) , 1, 10)]
        public int BallControll { get; set; }    // 1 -10

        [Skill(nameof(Drilling), 1, 20)]
        public int Drilling { get; set; }       // 1 - 20 

        [Skill(nameof(Power), 1, 100)]
        public int Power { get; set; }          // 1 - 100

        [Skill(nameof(Spped), 1, 100)]
        public int Spped { get; set; }          // 1 - 100

        [Skill(nameof(Passing), 1, 4)]
        public int Passing { get; set; }        // 1 -4

    }

    [AttributeUsage(AttributeTargets.Property , AllowMultiple =true , Inherited =false)]
    public class SkillAttribute:Attribute
    {

        public string Name { get;private set; }
        public int Minimum { get; private set; }
        public int Maxmum { get; private set; }
        public SkillAttribute(string name, int minimum, int maxmum)
        {
            Name = name;
            Minimum = minimum;
            Maxmum = maxmum;
        }

        public bool IsValid(object obj)
        {
            var value =(int) obj;
            return value >= Minimum && value <= Maxmum;
        }
    }

    public class Error
    {
        private string field;
        private string details;

        public Error(string field, string details)
        {
            this.field = field;
            this.details = details;
        }
        public override string ToString()
        {
            return $"{{\"{field}\": \"{details}\"}}";
        }
    }


}
