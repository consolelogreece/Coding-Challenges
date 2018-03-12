function convertToRoman(number) {
    var num = number;
    var numeralstring = "";

    var numlen;
    while (num > 0) {
        numlen = num.toString().length;

        switch (numlen) {

            case 1:
                if ((num - 5) >= 0) {

                    if (num == 9) {
                        numeralstring += "IX";
                        num -= 9;

                    } else {
                        numeralstring += "V";
                        num -= 5;
                    }



                } else {

                    if (num == 4) {
                        numeralstring += "IV";
                        num -= 4;

                    } else {
                        numeralstring += "I";
                        num -= 1;
                    }
                }

                break;
case 2:
                if ((num - 50) >= 0) {

                    if (num >= 90) {
                        numeralstring += "XC";
                        num -= 90;

                    } else {
                        numeralstring += "L";
                        num -= 50;
                    }

                } else {

                    if (num >= 40) {
                        numeralstring += "XL";
                        num  -= 40;

                    } else {
                        numeralstring += "X";
                        num -= 10;
                    }

                }

                break;


            case 3:
                if ((num - 500) >= 0) {

                    if (num >= 900) {
                        numeralstring += "CM";
                        num -= 900;

                    } else {
                        numeralstring += "D";
                        num -= 500;
                    }



                } else {
                    if (num >= 400) {
                        numeralstring += "CD";
                        num -= 400;

                    } else {
                        numeralstring += "C";
                        num -= 100;
                    }
                }

                break;


            default:
                numeralstring += "M";
                num -= 1000;
        }

    }
    return numeralstring;
}

convertToRoman(4334);