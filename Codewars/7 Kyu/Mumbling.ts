export class G964 {
    public static accum(s: string):string {
        return s.split('').map((char:string, index:number) => char.toUpperCase() + char.repeat(index).toLowerCase()).join('-')
    }
}

//https://www.codewars.com/kata/5667e8f4e3f572a8f2000039