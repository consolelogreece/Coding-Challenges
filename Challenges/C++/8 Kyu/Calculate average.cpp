#include <vector>

double calcAverage(const std::vector<int>& values){
  float total = 0;
  for (int val : values) total +=  val;
  return total / values.size();
}

// https://www.codewars.com/kata/57a2013acf1fa5bfc4000921