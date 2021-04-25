using System;
using System.Collections.Generic;
using System.Text;

namespace EnRuDictionary {
  class Program {
    static void Main() {
      Console.OutputEncoding = Encoding.Unicode;

      var dict = new Dictionary<dynamic, dynamic> {
        { "again", new { Transcription = "əˈɡen", Translation = "опять" } },
        { "almost", new { Transcription = "ˈɔːlmoʊst", Translation = "почти" } },
        { "always", new { Transcription = "ˈɔːlweɪz", Translation = "всегда" } },
        { "enough", new { Transcription = "ɪˈnʌf", Translation = "достаточно" } },
        { "especially", new { Transcription = "ɪˈspeʃəli", Translation = "особенно" } },
        { "even", new { Transcription = "ˈiːvn", Translation = "даже" } },
        { "just", new { Transcription = "dʒʌst", Translation = "только что, просто" } },
        { "quickly", new { Transcription = "ˈkwɪkli", Translation = "быстро" } },
        { "never", new { Transcription = "ˈnevər", Translation = "никогда" } },
        { "now", new { Transcription = "naʊ", Translation = "сейчас" } }
      };

      foreach (var word in dict) {
        Console.WriteLine("{0,-14}{1,-14}{2}", word.Key, $"[{word.Value.Transcription}]", word.Value.Translation);
      }

      Console.ReadKey();
    }
  }
}
