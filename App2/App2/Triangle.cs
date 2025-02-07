namespace App2
{
    class Triangle(float a, float b, float c)
    {
        public float sideA = a;
        public float sideB = b;
        public float sideC = c;

        public float CalcPerimeter()
        {
            float calc = (sideA + sideB + sideC) / 2;
            return calc;
        }
    }
}
