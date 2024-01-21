namespace FactorialService;

public class FactorialLogic
{
    public static int GetFactorialValue(int n){
        if (n < 0){
            return 0;
        } else if (n == 0 || n == 1){
            return 1;
        } else {
            return n * GetFactorialValue(n-1);
        }
    }
}
