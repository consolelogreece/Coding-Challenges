export class G964 {
  public static evaporator(content: number, evap_per_day: number, threshold: number): number {
    let days:number = 0;
    let thresholdNumber = (content/100*threshold)
    while(thresholdNumber <= content) {
      content -= (content/100 * evap_per_day);
      days++;
    }
    return days;
  }
}
//https://www.codewars.com/kata/5506b230a11c0aeab3000c1f