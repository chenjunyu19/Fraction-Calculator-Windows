using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction_Calculator
{
  public class Fractions
  {
    public struct Fraction
    {
      public int Numerator;
      public int Denominator;
    }

    public static int GetMaxCommonFactor(int i1, int i2)
    {
      int tmp;
      while (i2 != 0)
      {
        tmp = i1 % i2;
        i1 = i2;
        i2 = tmp;
      }
      return i1;
    }

    public static int GetMinCommonMultiple(int i1, int i2)
    {
      int tmp = i1;
      while (tmp % i2 != 0)
      {
        tmp += i1;
      }
      return tmp;
    }

    public static bool isMeaningful(Fraction f)
    {
      if (f.Denominator != 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static Fraction MoveMinusToNumerator(Fraction f)
    {
      if (f.Numerator != 0 && f.Denominator < 0)
      {
        f.Numerator = -f.Numerator;
        f.Denominator = -f.Denominator;
      }
      return f;
    }

    public static Fraction ReductionofAFraction(Fraction f)
    {
      if (isMeaningful(f))
      {
        f = MoveMinusToNumerator(f);
        int MaxCommonFactor = GetMaxCommonFactor(Math.Abs(f.Numerator), Math.Abs(f.Denominator));
        f.Numerator /= MaxCommonFactor;
        f.Denominator /= MaxCommonFactor;
      }
      return f;
    }

    public static Fraction[] ReductionofFractionstoACommonDenominator(Fraction f1, Fraction f2)
    {
      Fraction[] f = new Fraction[2];
      if (!isMeaningful(f1) || !isMeaningful(f2))
      {
        f[0] = f1;
        f[1] = f2;
        return f;
      }
      f1 = ReductionofAFraction(f1);
      f2 = ReductionofAFraction(f2);
      f[0].Numerator = f1.Numerator;
      f[1].Numerator = f2.Numerator;
      int MinCommonMultiple = GetMinCommonMultiple(Math.Abs(f1.Denominator), Math.Abs(f2.Denominator));
      f[0].Denominator = MinCommonMultiple;
      f[1].Denominator = MinCommonMultiple;
      f[0].Numerator = f[0].Numerator * MinCommonMultiple / f1.Denominator;
      f[1].Numerator = f[1].Numerator * MinCommonMultiple / f2.Denominator;
      f[0] = MoveMinusToNumerator(f[0]);
      f[1] = MoveMinusToNumerator(f[1]);
      return f;
    }

    public static Fraction Addition(Fraction f1, Fraction f2)
    {
      if (!isMeaningful(f1) && !isMeaningful(f2))
      {
        return new Fraction();
      }
      Fraction[] fs = ReductionofFractionstoACommonDenominator(f1, f2);
      Fraction f;
      f.Numerator = fs[0].Numerator + fs[1].Numerator;
      f.Denominator = fs[0].Denominator;
      return f;
    }

    public static Fraction Subaddition(Fraction f1, Fraction f2)
    {
      if (!isMeaningful(f1) && !isMeaningful(f2))
      {
        return new Fraction();
      }
      Fraction[] fs = ReductionofFractionstoACommonDenominator(f1, f2);
      Fraction f;
      f.Numerator = fs[0].Numerator - fs[1].Numerator;
      f.Denominator = fs[0].Denominator;
      return f;
    }

    public static Fraction Multiplication(Fraction f1, Fraction f2)
    {
      Fraction f;
      f.Numerator = f1.Numerator * f2.Numerator;
      f.Denominator = f1.Denominator * f2.Denominator;
      f = ReductionofAFraction(f);
      return f;
    }

    public static Fraction Division(Fraction f1, Fraction f2)
    {
      Fraction f;
      f.Numerator = f1.Numerator * f2.Denominator;
      f.Denominator = f1.Denominator * f2.Numerator;
      f = ReductionofAFraction(f);
      return f;
    }
  }
}