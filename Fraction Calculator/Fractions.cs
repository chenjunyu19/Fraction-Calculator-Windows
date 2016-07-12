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
      public decimal Numerator;
      public decimal Denominator;
    }

    /// <summary>
    /// 取两个数的最大公因数
    /// </summary>
    /// <param name="n1">数1</param>
    /// <param name="n2">数2</param>
    public static decimal GetMaxCommonFactor(decimal n1, decimal n2)
    {
      decimal tmp;
      while (n2 != 0)
      {
        tmp = n1 % n2;
        n1 = n2;
        n2 = tmp;
      }
      return n1;
    }

    /// <summary>
    /// 取两个数的最小公倍数
    /// </summary>
    /// <param name="n1">数1</param>
    /// <param name="n2">数2</param>
    public static decimal GetMinCommonMultiple(decimal n1, decimal n2)
    {
      decimal tmp = n1;
      while (tmp % n2 != 0)
      {
        tmp += n1;
      }
      return tmp;
    }

    /// <summary>
    /// 检查一个分数是否有意义
    /// </summary>
    /// <param name="f">要检查的分数</param>
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

    /// <summary>
    /// 将分母的负号移到分子
    /// </summary>
    /// <param name="f">要操作的分数</param>
    public static Fraction MoveMinusToNumerator(Fraction f)
    {
      if (f.Numerator != 0 && f.Denominator < 0)
      {
        f.Numerator = -f.Numerator;
        f.Denominator = -f.Denominator;
      }
      return f;
    }

    /// <summary>
    /// 对一个分数进行约分
    /// </summary>
    /// <param name="f">要约分的分数</param>
    public static Fraction ReductionofAFraction(Fraction f)
    {
      if (isMeaningful(f))
      {
        f = MoveMinusToNumerator(f);
        decimal MaxCommonFactor = GetMaxCommonFactor(Math.Abs(f.Numerator), Math.Abs(f.Denominator));
        f.Numerator /= MaxCommonFactor;
        f.Denominator /= MaxCommonFactor;
      }
      return f;
    }

    /// <summary>
    /// 对两个分数进行通分
    /// </summary>
    /// <param name="f1">分数1</param>
    /// <param name="f2">分数2</param>
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
      decimal MinCommonMultiple = GetMinCommonMultiple(Math.Abs(f1.Denominator), Math.Abs(f2.Denominator));
      f[0].Denominator = MinCommonMultiple;
      f[1].Denominator = MinCommonMultiple;
      f[0].Numerator = f[0].Numerator * MinCommonMultiple / f1.Denominator;
      f[1].Numerator = f[1].Numerator * MinCommonMultiple / f2.Denominator;
      f[0] = MoveMinusToNumerator(f[0]);
      f[1] = MoveMinusToNumerator(f[1]);
      return f;
    }

    /// <summary>
    /// 将两个分数相加
    /// </summary>
    /// <param name="f1">分数1</param>
    /// <param name="f2">分数2</param>
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

    /// <summary>
    /// 将两个分数相减
    /// </summary>
    /// <param name="f1">分数1</param>
    /// <param name="f2">分数2</param>
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

    /// <summary>
    /// 将两个分数相乘
    /// </summary>
    /// <param name="f1">分数1</param>
    /// <param name="f2">分数2</param>
    public static Fraction Multiplication(Fraction f1, Fraction f2)
    {
      Fraction f;
      f.Numerator = f1.Numerator * f2.Numerator;
      f.Denominator = f1.Denominator * f2.Denominator;
      f = ReductionofAFraction(f);
      return f;
    }

    /// <summary>
    /// 将两个分数相除
    /// </summary>
    /// <param name="f1">分数1</param>
    /// <param name="f2">分数2</param>
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