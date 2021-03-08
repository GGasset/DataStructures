using System;
using DataStructures;

namespace DataStructures
{
    public class Fraction
    {
        public int numerator, denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("The denominator must not equal zero.")
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public double Calculate() => numerator / (denominator + 0.0);
        public override string ToString() => $"{numerator} / {denominator}";
        public static Fraction ToFraction(int value) => new Fraction(value, 1);
        //TODO: Implement ToFraction(double value)

        public static Fraction operator *(Fraction x, Fraction y)
            => new Fraction(x.numerator * y.numerator, x.denominator * y.denominator);

        public static Fraction operator *(Fraction x, double y)
            => new Fraction(x.numerator + y * x.denominator, x,denominator);

        public static Fraction operator /(Fraction x, Fraction y)
            => new Fraction(x.numerator * y.denominator, x.denominator * y.numerator);

        public static Fraction operator /(Fraction x, double y) => x / new Fraction(y, 1);

        public static Fraction operator +(Fraction x, Fraction y) => Add(x, y);
        public static Fraction operator -(Fraction x, Fraction y) => Subtract(x, y);

        private static Fraction Add(Fraction x, Fraction y)
        {
            if (x.denominator == y.denominator)
                return new Fraction(x.numerator + y.numerator, x.denominator + y.denominator);
            else
            {
                ToCommonDenominator(x, y, out x, out y);
                return new Fraction(x.numerator + y.numerator, x.denominator);
            }
        }

        private static Fraction Subtract(Fraction x, Fraction y)
        {
            if (x.denominator == y.denominator)
                return new Fraction(x.numerator - y.numerator, x.denominator - y.denominator);
            else
            {
                ToCommonDenominator(x, y, out x, out y);
                return new Fraction(x.numerator - y.numerator, x.denominator);
            }
        }

        private static void ToCommonDenominator(Fraction x, Fraction y, out Fraction commonX, out Fraction commonY)
        {
                int commonDenominator = x.denominator * y.denominator;
                x.numerator = x.numerator * (commonDenominator / x.denominator);
                y.numerator = y.numerator * (commonDenominator / y.denominator);
                commonX = new Fraction(x.numerator, commonDenominator);
                commonY = new Fraction(y.numerator, commonDenominator);
        }
    }
}