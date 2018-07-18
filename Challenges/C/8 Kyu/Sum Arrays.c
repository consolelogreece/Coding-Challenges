#include <stddef.h>

int sum_array(const int *values, size_t count){

  int accumulator = 0;
  for (int i = 0; i < count; i++){
    accumulator += values[i];
  };

  return accumulator;

}

https://www.codewars.com/kata/53dc54212259ed3d4f00071c