using System;

namespace Quaternions
{
    /// <summary>
    /// Estructura representativa de un cuaternion.
    /// </summary>
    public struct Quaternions
    {
        /// <summary>
        /// Coeficiente a del cuaternion.
        /// </summary>
        public float a;
        /// <summary>
        /// Coeficiente b de i del cuaternion.
        /// </summary>
        public float b;
        /// <summary>
        /// Coeficiente c de j del cuaternion.
        /// </summary>
        public float c;
        /// <summary>
        /// Coeficiente d de k del cuaternion.
        /// </summary>
        public float d;


        /// <summary>
        /// Operador unario que realiza la operacion absoluto sobre un 
        /// cuaternion.
        /// </summary>
        /// <param name="a">Cuaternion sobre el cual realizar el valor absoluto</param>
        /// <returns>Valor absoluto del cuaternion a</returns>
        public static float operator !(Quaternions a)
        {
            return MathF.Sqrt(a.a * a.a + a.b * a.b + a.c * a.c + a.d * a.d);
        }


        /// <summary>
        /// Operador unario que realiza la operacion conjugada sobre un 
        /// cuaternion.
        /// </summary>
        /// <param name="a">Cuaternion al cual calcular su conjugada.</param>
        /// <returns>Conjugada del cuaternion.</returns>
        public static Quaternions operator ~(Quaternions a)
        {
            return new Quaternions(a.a, -a.b, -a.c, -a.d);
        }


        /// <summary>
        /// Operador binario que realiza la opearcion multiplicacion entre 
        /// dos cuaterniones a y b.
        /// </summary>
        /// <remarks>La operacion es (a * b)</remarks>
        /// <param name="a">Cuaternion a</param>
        /// <param name="b">Cuaternion b</param>
        /// <returns>Cuaternion resultante de (a * b)</returns>
        public static Quaternions operator *(Quaternions a, Quaternions b)
        {
            return new Quaternions(a.a * b.a - a.b * b.b - a.c * b.c - a.d * b.d,
                                a.a * b.b + a.b * b.a + a.c * b.d - a.d * b.c,
                                a.a * b.c - a.b * b.d + a.c * b.a + a.d * b.b,
                                a.a * b.d + a.b * b.c - a.c * b.b + a.d * b.a);
        }


        /// <summary>
        /// Operador binario que realiza la opearcion suma entre 
        /// dos cuaterniones a y b.
        /// </summary>
        /// <param name="a">Cuaternion a</param>
        /// <param name="b">Cuaternion b</param>
        /// <returns>Cuaternion resultante de (a + b)</returns>
        public static Quaternions operator +(Quaternions a, Quaternions b)
        {
            return new Quaternions(a.a + b.a, a.b + b.b, a.c + b.c, a.d + b.d);
        }


        /// <summary>
        /// Operador binario que realiza la operacion suma entre 
        /// un cuaternion a y un flotante o entero b.
        /// </summary>
        /// <remarks>
        /// La operacion solo se realiza con el flotante o entero 
        /// a la derecha del cuaternion.
        /// </remarks>
        /// <param name="a">Cuaternion a</param>
        /// <param name="b">Flotante o entero b</param>
        /// <returns>Cuaternion resultante de a + b</returns>
        public static Quaternions operator +(Quaternions a, float b)
        {
            return new Quaternions(a.a + b, a.b, a.c, a.d);
        }


        /// <summary>
        /// Operador binario que realiza la operacion multiplicacion entre 
        /// un cuaternion a y un flotante o entero b.
        /// </summary>
        /// <remarks>
        /// La operacion solo se realiza con el flotante o entero 
        /// a la derecha del cuaternion.
        /// </remarks>
        /// <param name="a">Cuaternion a</param>
        /// <param name="b">Flotante o entero b</param>
        /// <returns>Cuaternion resultante de a * b</returns>
        public static Quaternions operator *(Quaternions a, float b)
        {
            return new Quaternions(a.a * b, a.b * b, a.c * b, a.d * b);
        }


        /// <summary>
        /// Constructor del cuaternion mediante sus coeficientes.
        /// </summary>
        /// <param name="a">Coeficiente a</param>
        /// <param name="b">Coeficiente de i</param>
        /// <param name="c">Coeficiente de j</param>
        /// <param name="d">Coeficiente de k</param>
        public Quaternions(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
}
