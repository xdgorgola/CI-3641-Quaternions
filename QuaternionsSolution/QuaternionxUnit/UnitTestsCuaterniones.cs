using System;
using Xunit;

public class QuaternionUnitTest
{
    private static double GetRandomNumber(double minimum, double maximum, Random random = null)
    {
        if (random == null)
            random = new Random();

        return random.NextDouble() * (maximum - minimum) + minimum;
    }


    [Fact]
    public void QuatAdd()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        float a2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d2 = (float)GetRandomNumber(-100.0, 100.0, r);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        Quaternions.Quaternions bQ = new Quaternions.Quaternions(a2, b2, c2, d2);
        Quaternions.Quaternions added = aQ + bQ;

        Assert.True(added.a == (a1 + a2) && added.b == (b1 + b2) &&
                added.c == (c1 + c2) && added.d == (d1 + d2));
    }


    [Fact]
    public void QuatAddWithScalar()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        float s = r.Next(-100, 100);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        Quaternions.Quaternions sum = aQ + s;

        Assert.True(sum.a == a1 + s && sum.b == b1 && sum.c == c1 &&
                sum.d == d1);
    }


    [Fact]
    public void QuatMult()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        float a2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c2 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d2 = (float)GetRandomNumber(-100.0, 100.0, r);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        Quaternions.Quaternions bQ = new Quaternions.Quaternions(a2, b2, c2, d2);
        Quaternions.Quaternions product = aQ * bQ;

        Assert.True(product.a == (a1 * a2 - b1 * b2 - c1 * c2 - d1 * d2) && 
                product.b == (a1 * b2 + b1 * a2 + c1 * d2 - d1 * c2) &&
                product.c == (a1 * c2 - b1 * d2 + c1 * a2 + d1 * b2) &&
                product.d == (a1 * d2 + b1 * c2 - c1 * b2 + d1 * a2));
    }


    [Fact]
    public void QuatMultByScalar()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        float s = r.Next(-100, 100);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        Quaternions.Quaternions product = aQ * s;

        Assert.True(product.a == a1 * s && product.b == b1 * s && 
                product.c == c1 * s && product.d == d1 * s);
    }


    [Fact]
    public void QuatConj()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        Quaternions.Quaternions conj = ~aQ;

        Assert.True(conj.a == a1 && conj.b == -b1 && conj.c == -c1 && conj.d == -d1);
    }


    [Fact]
    public void QuatAbs()
    {
        Random r = new Random();

        float a1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float b1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float c1 = (float)GetRandomNumber(-100.0, 100.0, r);
        float d1 = (float)GetRandomNumber(-100.0, 100.0, r);

        Quaternions.Quaternions aQ = new Quaternions.Quaternions(a1, b1, c1, d1);
        float abs = !aQ;
    
        Assert.True(MathF.Sqrt(a1 * a1 + b1 * b1 + c1 * c1 + d1 * d1) == abs);
    }
}


