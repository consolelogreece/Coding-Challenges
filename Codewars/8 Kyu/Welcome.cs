using System.Collections.Generic;

public static class Kata
{
  private static readonly Dictionary<string, string> db = new Dictionary<string, string>(){
    {"english", "Welcome"},
    {"czech", "Vitejte"},
    {"danish", "Velkomst"},
    {"dutch", "Welkom"},
    {"estonian", "Tere tulemast"},
    {"finnish", "Tervetuloa"},
    {"flemish", "Welgekomen"},
    {"french", "Bienvenue"},
    {"german", "Willkommen"},
    {"irish", "Failte"},
    {"italian", "Benvenuto"},
    {"latvian", "Gaidits"},
    {"lithuanian", "Laukiamas"},
    {"polish", "Witamy"},
    {"spanish", "Bienvenido"},
    {"swedish", "Valkommen"},
    {"welsh", "Croeso"}
  };
  
  public static string Greet(string language)
  {
      return db.ContainsKey(language) ? db[language] : db["english"];
  }
}

// https://www.codewars.com/kata/577ff15ad648a14b780000e7