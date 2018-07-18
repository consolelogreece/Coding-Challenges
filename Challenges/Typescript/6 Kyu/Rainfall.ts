export class G964 {

    public static mean = (town, strng) => {
      let townData:string = G964.getTownData(town, strng);
      if (!townData) return -1; 
      let monthData = townData.split(",");
      return monthData.reduce((acc, val) =>  acc + parseFloat(val.substr(4)), 0) / monthData.length
      
    }

    public static variance = (town, strng) => {
      let townData =  G964.getTownData(town, strng); 
      if (!townData) return -1; 
      let monthData = townData.split(",");
      let mean = G964.mean(town, strng);
      return (monthData.reduce((acc, val) => acc + Math.pow((mean - parseFloat(val.substr(4))), 2), 0) / monthData.length);
         
    }
    
    public static getTownData = (town, strng) => {
      let allCities = strng.split('\n')
          let townData:string;
          let data:string[];
          for (let i = 0; i < allCities.length; i++) {
            data = allCities[i].split(':');
            if (data[0] === town) {
              townData = data[1]
              break;
            }
          }
          return townData;
      }
}

//https://www.codewars.com/kata/56a32dd6e4f4748cc3000006