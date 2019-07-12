using System;

namespace BlingBlong {
  class BBCheck {
    public static void BBChecker () {
      for (int i = 0; i < 100; i++) {
        string results = "";
        if (i % 15 == 0) {
          results = "BlingBlong";
        } else if (i % 5 == 0) {
          results = ("Blong");
        } else if (i % 3 == 0) {
          results = ("Bling");
        } else {
          if (results.Length == 0) {
            results = i.ToString ();
          }
        }
        Console.WriteLine (results);
      }
    }
  }
}