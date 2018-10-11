package learnwithllew.KeyboardShortcutKatas;

import java.util.function.Supplier;

public class Inline
{
  int e = 2;
  public int practice()
  {
    int i = 2;
    int a = 5;
    int s = 2 - i;
    int j = (b() - a + i);
    int m = f(3);
    int t = 0;
    if (n())
    {
      t += 56;
    }
    Supplier<Integer> k = () -> {
      int l = m + j;
      return l - c(e);
    };
    int q = 1 - O.create().p;
    return 42 + k.get() + q + Extensions.h(7) + s + t;
  }
  private boolean n()
  {
    return false;
  }
  private static int f(int g)
  {
    return -3 + g;
  }
  private static int c(int d)
  {
    return d;
  }
  private static int b()
  {
    return 5;
  }
  public static class Extensions
  {
    public static int h(int that)
    {
      return that - 7;
    }
  }
  public static class O
  {
    public int p = 1;
    public static O create()
    {
      return new O();
    }
  }
}