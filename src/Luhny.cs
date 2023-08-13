namespace LuhnyLib{
    public class Luhny{
        public static List<long> removeLast(List<long> arr){
            int lastIndex = arr.Count - 1;
            arr.RemoveAt(lastIndex);
            return arr;
        }
        public static List<string> cleanSplit(
            string subject
        ) {
            List<string> result = new List<string>();
            foreach(char c in subject){
                result.Add(c.ToString());
            }
            return result;
        }
        public static bool isInt(string subject){
            bool result = long.TryParse(subject, out _);
            return result;
        }
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
        public static List<long> doubleImportantNumbers(string subject){
            List<long> importantNums = getImportantNumbers(subject);
            List<long> result = new List<long>();
            for (int i = 0; i < importantNums.Count;i++){
                result.Add(importantNums[i]*2);
            }
            return result;
        }
        public static long addTrashNumbers(string subject){
            long result = 0;
            List<long> garbage = getTrashNumbers(subject);
            for (int i =0; i < garbage.Count;i++){
                long longInt = Convert.ToInt64(garbage[i]);
                result = result + longInt;
            }
            return result;
        }
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
        public static string getLast(List<string> subject){
            int lastIndex = subject.Count - 1;
            return subject[lastIndex];
        }
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