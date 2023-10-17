using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle
    {

        // variabeln som innehåller värdet för den valda radius
        int _radius;

        //konstruktor av klassen
        public Circle(int radius)
        {
            _radius = radius;
        }

        // metoden för att räkna ur arean
        public int GetArea()
        {
            int area = (int)(_radius * _radius * Math.PI);
            return area;
        }
        
    }
}
