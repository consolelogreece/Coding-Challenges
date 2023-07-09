class Arge
{
  public:
  static int nbYear(int p0, double percent, int aug, int p)
  {
    int yrs = 0;
    
    while (p0 < p)
    {
      yrs++;
      p0 += (p0 * (percent / 100)) + aug;
    }

    return yrs; 
  }
};

//https://www.codewars.com/kata/563b662a59afc2b5120000c6