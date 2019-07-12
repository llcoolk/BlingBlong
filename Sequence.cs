using System;

namespace Sequence {
  class Sequencer {
    public static int Fibonacci (int n) {
      // Console.WriteLine ("Enter how many additional numbers to prints besides 0, 1, 1 : ");
      // int num = int.Parse (Console.ReadLine ());
      int a = 0;
      int b = 1;
      // n represents number of fibonacci series
      for (int i = 0; i < n; i++) {
        int temp = a;
        a = b;
        b = temp + b;
      }
      return a;
    }
  }
}