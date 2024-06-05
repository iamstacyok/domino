using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    internal class Domino
    {
        public int leftSide;
        public int rightSide;
        public string img_path;
        public Domino(int left, int right)
        {
            leftSide = left;
            rightSide = right;
            img_path = "..\\..\\img\\"+left.ToString() + right.ToString() + ".png";
        }

        public void Flip()
        {
            int ind = leftSide;
            leftSide = rightSide; 
            rightSide = ind;
        }
    }
}
