/*
LUHNY.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Declaring a namespace for the
// Luhny library.
namespace LuhnyLib{

    // Declaring a container class for Luhny's
    // methods.
    public class Luhny{

        // Removes the last item of an array of long
        // integers.
        public static List<long> removeLast(List<long> arr){
            int lastIndex = arr.Count - 1;
            arr.RemoveAt(lastIndex);
            return arr;
        }

        // Splits a string into the characters that make it up
        // and returns these characters a list of strings.
        public static List<string> cleanSplit(
            string subject
        ) {
            List<string> result = new List<string>();
            foreach(char c in subject){
                result.Add(c.ToString());
            }
            return result;
        }

        // Checks whether the supplied string
        // is a long integer.
        public static bool isInt(string subject){
            bool result = long.TryParse(subject, out _);
            return result;
        }

        // Checks whether the supplied number sequence string
        // is a number sequence.
        public static bool isNumberSequence(string subject){
            bool result = true;
            List<string> splitString = cleanSplit(subject);
            for (int i = 0; i < splitString.Count; i++){
                if (isInt(splitString[i])){}
                else {
                    result = false;
                }
            }
            return result;
        }

        // Gets every second number ina list of long integers.
        public static List<long> getImportantNumbers(string subject){
            List<long> result = new List<long>();
            List<string> charList = cleanSplit(subject);
            for (int i = 0; i < charList.Count; i++){
                int currIndex = i + 1;
                if (currIndex%2 == 0){
                    long item = long.Parse(charList[i]);
                    result.Add(item);
                }
                else {}
            }
            return result;
        }

        // Gets the remaining numbers from the string.
        public static List<long> getTrashNumbers(string subject){
            List<long> result = new List<long>();
            List<string> charList = cleanSplit(subject);
            for (int i = 0; i < charList.Count; i++){
                int currIndex = i + 1;
                if (currIndex%2 == 0){}
                else {
                    long item = long.Parse(charList[i]);
                    result.Add(item);
                }
            }
            List<long> new_result = removeLast(result);
            return new_result;
        }

        // Doubles every second number in the sequence and returns
        // these doubles as a list.
        public static List<long> doubleImportantNumbers(string subject){
            List<long> importantNums = getImportantNumbers(subject);
            List<long> result = new List<long>();
            for (int i = 0; i < importantNums.Count;i++){
                result.Add(importantNums[i]*2);
            }
            return result;
        }

        // Adds all the remaining numbers together.
        public static long addTrashNumbers(string subject){
            long result = 0;
            List<long> garbage = getTrashNumbers(subject);
            for (int i =0; i < garbage.Count;i++){
                long longInt = Convert.ToInt64(garbage[i]);
                result = result + longInt;
            }
            return result;
        }

        // Converts a number array to a string array.
        public static List<string> numArrToStringArr(List<long> numArr){
            List<string> result = new List<string>();
            for (int i = 0; i < numArr.Count; i++){
                string num = numArr[i].ToString();
                List<string> sepChars = cleanSplit(num);
                for (int x = 0; x < sepChars.Count; x++){
                    result.Add(sepChars[x]);
                }
            }
            return result;
        }

        // Adds all the doubled integers together.
        public static long addImportantDoubleDigits(string subject){
            long result = 0;
            List<long> doubles = doubleImportantNumbers(subject);
            List<string> digits = numArrToStringArr(doubles);
            for (int i = 0; i < digits.Count; i++){
                int num = int.Parse(digits[i]);
                long longNum = Convert.ToInt64(num);
                result = result + num;
            }
            return result;
        }

        // Gets the last item from a list of strings.
        public static string getLast(List<string> subject){
            int lastIndex = subject.Count - 1;
            return subject[lastIndex];
        }

        // Validates an IMEI numer with the Luhn algorithm.
        // Returns "false" if the number isn't valid
        // or not of the correct length or contains
        // other characters besides numbers.
        public static bool validateIMEI(string subject){
            bool result = false;
            int stdLen = 15;
            List<string> imeiChars = cleanSplit(subject);
            if (isNumberSequence(subject) && 
                imeiChars.Count == stdLen
            ){
                string checkDigit = getLast(imeiChars);
                long sum = addImportantDoubleDigits(subject) + addTrashNumbers(subject);
                long computedCD = 10 - (sum%10);
                if (checkDigit == computedCD.ToString()){
                    result = true;
                }
                else {}
            }
            else {}            
            return result;
        }
    }
}