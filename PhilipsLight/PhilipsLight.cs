using System;
using System.Collections.Generic;
using System.Linq;

namespace LibPhilips
{
    public class PhilipsLight
    {
        List<string> Lines = new List<string>() 
        {"  _",
        @" / \",
         "(<o>)",
        @" \_/"};
        bool on;
        public void TurnOn() => on = true;
        public void TurnOff() => on = false;
        public void Draw() {
            if (on)
                DrawLight(Lines);
            else
                DrawLight(Lines.Select(v => new string(v.Select(ch => ch == 'o' ? 'O' : ' ').ToArray())));
        }
        private void DrawLight(IEnumerable<string> lines)
        {
            var c = (x: Console.CursorLeft, y: Console.CursorTop);
            var topleft = (x: c.x - 2, y: c.y - 3);
            foreach (var l in lines.Select((v, i) => (v, x: topleft.x, y: i + topleft.y)))
            {
                var (s, x, y) = l;
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(s);
            }
            Console.CursorTop = c.y;
            Console.CursorLeft = c.x;
        }
    }
}
