using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversii
{
    internal class Start
    {
        int count = 0;
        Image[,] Field = { { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
                           { Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp"), Image.FromFile("E.bmp")},
        };
        public Image[,] fieldFill()
        {
            return Field;
        }
        public Image[,] fieldFill(int x, int y)
        {
            if (Field[x,y] == (Image.FromFile("E.bmp"))) 
            {
                
                count++;
            }
                if (count % 2 != 0)
                {
                    Field[x, y] = Image.FromFile("W.bmp");
                    
                    return Field;
                }
                if (count % 2 == 0)
                {
                    Field[x, y] = Image.FromFile("B.bmp");
                    
                    return Field;
                }
            
            return Field;
        }
    } 
    
}
