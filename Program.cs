using System;
using bb = BlingBlong.BBCheck;
using ss = Sequence.Sequencer;

namespace finalProject {
    class Program {
        static void Main (string[] args) {
            bb.BBChecker ();
            ss.Fibonacci (8);
            // call fibonacci method
            for (int i = 0; i < 8 + 3; i++) {
                Console.WriteLine (ss.Fibonacci (i));
            }
        }
    }
}