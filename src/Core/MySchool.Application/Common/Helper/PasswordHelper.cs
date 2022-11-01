using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Application.Common.Helper
{
    public class PasswordHelper
    {
        public static string GenerateRandomPassword()
        {
            var randomChars = new[] {
            "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
            "abcdefghijkmnopqrstuvwxyz",    // lowercase
            "0123456789"                   // digits
        };

            var rand = new Random(Environment.TickCount);
            var chars = new List<char>();

            chars.Insert(rand.Next(0, chars.Count),
                randomChars[0][rand.Next(0, randomChars[0].Length)]);


            chars.Insert(rand.Next(0, chars.Count),
                randomChars[1][rand.Next(0, randomChars[1].Length)]);


            chars.Insert(rand.Next(0, chars.Count),
                randomChars[2][rand.Next(0, randomChars[2].Length)]);



            for (var i = chars.Count; i < 12
                                      || chars.Distinct().Count() < 12; i++)
            {
                var rcs = randomChars[rand.Next(0, randomChars.Length)];
                chars.Insert(rand.Next(0, chars.Count),
                    rcs[rand.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());
        }
    }
}
