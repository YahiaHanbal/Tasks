using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class line_length
    {
        private float x1piont;
        private float x2piont;
        private float y1piont;
        private float y2piont;

        public line_length(float x1, float y1, float x2, float y2) {
            x1piont = x1;
            x2piont = x2;
            y1piont = y1;
            y2piont = y2;            
        }

        public float find_length() {
            float x = x2piont - x1piont;
            float y = y2piont - y1piont;
            return x * x + y * y;
        }
    }
}
